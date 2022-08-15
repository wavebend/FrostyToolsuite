using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CompleteSPMedalEntityData))]
	public class CompleteSPMedalEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CompleteSPMedalEntityData>
	{
		public new FrostySdk.Ebx.CompleteSPMedalEntityData Data => data as FrostySdk.Ebx.CompleteSPMedalEntityData;
		public override string DisplayName => "CompleteSPMedal";

		public CompleteSPMedalEntity(FrostySdk.Ebx.CompleteSPMedalEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

