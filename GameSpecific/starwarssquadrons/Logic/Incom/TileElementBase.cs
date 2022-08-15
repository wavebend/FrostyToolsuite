using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TileElementBaseData))]
	public class TileElementBase : WSUIElementEntity, IEntityData<FrostySdk.Ebx.TileElementBaseData>
	{
		public new FrostySdk.Ebx.TileElementBaseData Data => data as FrostySdk.Ebx.TileElementBaseData;
		public override string DisplayName => "TileElementBase";

		public TileElementBase(FrostySdk.Ebx.TileElementBaseData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

