using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TargettingProjectionEntityData))]
	public class TargettingProjectionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TargettingProjectionEntityData>
	{
		public new FrostySdk.Ebx.TargettingProjectionEntityData Data => data as FrostySdk.Ebx.TargettingProjectionEntityData;
		public override string DisplayName => "TargettingProjection";

		public TargettingProjectionEntity(FrostySdk.Ebx.TargettingProjectionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

