using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TileElementData))]
	public class TileElement : TileElementBase, IEntityData<FrostySdk.Ebx.TileElementData>
	{
		public new FrostySdk.Ebx.TileElementData Data => data as FrostySdk.Ebx.TileElementData;
		public override string DisplayName => "TileElement";

		public TileElement(FrostySdk.Ebx.TileElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

