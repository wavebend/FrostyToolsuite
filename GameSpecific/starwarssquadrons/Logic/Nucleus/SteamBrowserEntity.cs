using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SteamBrowserEntityData))]
	public class SteamBrowserEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SteamBrowserEntityData>
	{
		public new FrostySdk.Ebx.SteamBrowserEntityData Data => data as FrostySdk.Ebx.SteamBrowserEntityData;
		public override string DisplayName => "SteamBrowser";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SteamBrowserEntity(FrostySdk.Ebx.SteamBrowserEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

