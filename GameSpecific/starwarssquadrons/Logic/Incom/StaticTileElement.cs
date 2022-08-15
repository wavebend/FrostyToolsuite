using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StaticTileElementData))]
	public class StaticTileElement : TileElementBase, IEntityData<FrostySdk.Ebx.StaticTileElementData>
	{
		public new FrostySdk.Ebx.StaticTileElementData Data => data as FrostySdk.Ebx.StaticTileElementData;
		public override string DisplayName => "StaticTileElement";

		public StaticTileElement(FrostySdk.Ebx.StaticTileElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

