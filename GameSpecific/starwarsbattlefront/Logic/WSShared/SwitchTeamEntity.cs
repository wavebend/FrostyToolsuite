using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SwitchTeamEntityData))]
	public class SwitchTeamEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SwitchTeamEntityData>
	{
		public new FrostySdk.Ebx.SwitchTeamEntityData Data => data as FrostySdk.Ebx.SwitchTeamEntityData;
		public override string DisplayName => "SwitchTeam";

		public SwitchTeamEntity(FrostySdk.Ebx.SwitchTeamEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

