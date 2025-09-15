using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using Frosty.Core;
using FrostySdk;
using FrostySdk.IO;
using FrostySdk.Managers.Entries;
using FrostySdk.Resources;
using MeshSetPlugin.Resources;

namespace UnifyAssetsPlugin
{
    public static class UnifyAssets
    {
        public static readonly List<string> LinkedAssets = new List<string>();
        private static List<string> chunkDiffList = new List<string>();

        public static readonly string DisplayName = ProfilesLibrary.DisplayName.Replace("\u2122", "");
        public static string GameVersion = "Steam";
		
        public static bool CheckChunks(bool isSteam)
        {
            LinkedAssets.Clear();
			
            if (!isSteam)
            {
                GameVersion = "EA";
            }
            
            string chunksPath = $"UnifyAssetsPlugin.Resources.{ProfilesLibrary.CacheName}-{GameVersion}-Chunks.txt";

            using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().GetManifestResourceStream(chunksPath)))
            {
                string listLine;
                
                while ((listLine = reader.ReadLine()) != null)
                {
                    chunkDiffList.Add(listLine);
                }
            }
            
            foreach (ResAssetEntry entry in App.AssetManager.EnumerateRes(modifiedOnly: true))
            {
                foreach (AssetEntry linkedEntry in entry.LinkedAssets)
                {
                    if (linkedEntry is ChunkAssetEntry && chunkDiffList.Contains(linkedEntry.Name))
                    {
                        if (!LinkedAssets.Contains(entry.Filename))
                        {
                            LinkedAssets.Add(entry.Filename);
                        }
                    }
                }
            }
            
            LinkedAssets.Sort();
            
            return LinkedAssets.Count == 0;
        }
		
        public static void UnifyChunks()
        {
            foreach (EbxAssetEntry entry in App.AssetManager.EnumerateEbx(modifiedOnly: true))
            {
                if (LinkedAssets.Contains(entry.Filename))
                {
                    EbxAsset asset = App.AssetManager.GetEbx(entry);
                    dynamic root = asset.RootObject;
                    
                    if (entry.Type == "SkinnedMeshAsset")
                    {
                        ResAssetEntry resEntry = App.AssetManager.GetResEntry(root.MeshSetResource);
                        MeshSet meshSet = App.AssetManager.GetResAs<MeshSet>(resEntry);
                        
                        foreach (var lod in meshSet.Lods)
                        {
                            lod.Name = resEntry.Name;

                            if (chunkDiffList.Contains(lod.ChunkId.ToString()))
                            {
                                ChunkAssetEntry lodChunk = App.AssetManager.GetChunkEntry(lod.ChunkId);
                                ChunkAssetEntry newChunkEntry = ReplaceChunk(entry.Filename, lodChunk);
                                lod.ChunkId = newChunkEntry.Id;
                                resEntry.ReplaceAsset(newChunkEntry, lodChunk);
                                
                                App.AssetManager.RevertAsset(lodChunk);
                            }
                        }

                        App.AssetManager.ModifyRes(resEntry.Name, meshSet);
                        App.AssetManager.ModifyEbx(entry.Name, asset);
                    }
                    else if (entry.Type == "TextureAsset")
                    {
                        ResAssetEntry resEntry = App.AssetManager.GetResEntry(root.Resource);
                        Texture texture = App.AssetManager.GetResAs<Texture>(resEntry);
                        ChunkAssetEntry chunkEntry = App.AssetManager.GetChunkEntry(texture.ChunkId);

                        if (chunkDiffList.Contains(chunkEntry.Id.ToString()))
                        {
                            ChunkAssetEntry newChunkEntry = ReplaceChunk(entry.Filename, chunkEntry, (texture.Flags.HasFlag(TextureFlags.OnDemandLoaded) || texture.Type != TextureType.TT_2d) ? null : texture);
                            texture.ChunkId = newChunkEntry.Id;
                        
                            resEntry.ReplaceAsset(newChunkEntry, chunkEntry);
                        
                            App.AssetManager.RevertAsset(chunkEntry);
                            
                            App.AssetManager.ModifyEbx(entry.Name, asset);
                            App.AssetManager.ModifyRes(resEntry.Name, texture);
                        }
                    }
                    
                    App.EditorWindow.DataExplorer.RefreshItems();
                }
            }
        }

        private static ChunkAssetEntry ReplaceChunk(string entryFilename, ChunkAssetEntry entry, Texture texture = null)
        {
            byte[] random = new byte[16];
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            while (true)
            {
                rng.GetBytes(random);

                random[15] |= 1;

                if (App.AssetManager.GetChunkEntry(new Guid(random)) == null)
                {
                    break;
                }

                App.Logger.Log($"Randomised onto old guid: {random}");
            }
            
            Guid newGuid;
            using (NativeReader reader = new NativeReader(App.AssetManager.GetChunk(entry)))
            {
                newGuid = App.AssetManager.AddChunk(reader.ReadToEnd(), new Guid(random), texture, entry.EnumerateBundles().ToArray());
            }

            ChunkAssetEntry newEntry = App.AssetManager.GetChunkEntry(newGuid);
            foreach (int sbId in entry.SuperBundles)
            {
                newEntry.AddToSuperBundle(sbId);
            }

            App.Logger.Log($"{entryFilename}: Replaced chunk {entry.Name} with {newGuid}");
            
            return newEntry;
        }
    }
}
