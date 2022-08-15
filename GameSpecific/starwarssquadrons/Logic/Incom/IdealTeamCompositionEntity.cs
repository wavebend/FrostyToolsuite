using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IdealTeamCompositionEntityData))]
	public class IdealTeamCompositionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IdealTeamCompositionEntityData>
	{
		public new FrostySdk.Ebx.IdealTeamCompositionEntityData Data => data as FrostySdk.Ebx.IdealTeamCompositionEntityData;
		public override string DisplayName => "IdealTeamComposition";

		public IdealTeamCompositionEntity(FrostySdk.Ebx.IdealTeamCompositionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

