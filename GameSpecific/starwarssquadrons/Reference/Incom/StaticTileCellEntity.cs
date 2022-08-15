using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StaticTileCellEntityData))]
	public class StaticTileCellEntity : LogicReferenceObject, IEntityData<FrostySdk.Ebx.StaticTileCellEntityData>
	{
		public new FrostySdk.Ebx.StaticTileCellEntityData Data => data as FrostySdk.Ebx.StaticTileCellEntityData;

		public StaticTileCellEntity(FrostySdk.Ebx.StaticTileCellEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

