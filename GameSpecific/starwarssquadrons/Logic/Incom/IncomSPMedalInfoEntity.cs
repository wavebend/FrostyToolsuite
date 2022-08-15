using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSPMedalInfoEntityData))]
	public class IncomSPMedalInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSPMedalInfoEntityData>
	{
		public new FrostySdk.Ebx.IncomSPMedalInfoEntityData Data => data as FrostySdk.Ebx.IncomSPMedalInfoEntityData;
		public override string DisplayName => "IncomSPMedalInfo";

		public IncomSPMedalInfoEntity(FrostySdk.Ebx.IncomSPMedalInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

