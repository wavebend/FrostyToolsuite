using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TargetOverideEntityData))]
	public class TargetOverideEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TargetOverideEntityData>
	{
		public new FrostySdk.Ebx.TargetOverideEntityData Data => data as FrostySdk.Ebx.TargetOverideEntityData;
		public override string DisplayName => "TargetOveride";

		public TargetOverideEntity(FrostySdk.Ebx.TargetOverideEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

