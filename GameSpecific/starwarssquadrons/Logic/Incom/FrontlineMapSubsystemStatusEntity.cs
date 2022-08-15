using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineMapSubsystemStatusEntityData))]
	public class FrontlineMapSubsystemStatusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FrontlineMapSubsystemStatusEntityData>
	{
		public new FrostySdk.Ebx.FrontlineMapSubsystemStatusEntityData Data => data as FrostySdk.Ebx.FrontlineMapSubsystemStatusEntityData;
		public override string DisplayName => "FrontlineMapSubsystemStatus";

		public FrontlineMapSubsystemStatusEntity(FrostySdk.Ebx.FrontlineMapSubsystemStatusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

