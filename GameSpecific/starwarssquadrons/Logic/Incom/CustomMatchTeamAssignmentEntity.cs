using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomMatchTeamAssignmentEntityData))]
	public class CustomMatchTeamAssignmentEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomMatchTeamAssignmentEntityData>
	{
		public new FrostySdk.Ebx.CustomMatchTeamAssignmentEntityData Data => data as FrostySdk.Ebx.CustomMatchTeamAssignmentEntityData;
		public override string DisplayName => "CustomMatchTeamAssignment";

		public CustomMatchTeamAssignmentEntity(FrostySdk.Ebx.CustomMatchTeamAssignmentEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

