using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomTeamEntityData))]
	public class IncomTeamEntity : TeamEntity, IEntityData<FrostySdk.Ebx.IncomTeamEntityData>
	{
		public new FrostySdk.Ebx.IncomTeamEntityData Data => data as FrostySdk.Ebx.IncomTeamEntityData;
		public override string DisplayName => "IncomTeam";

		public IncomTeamEntity(FrostySdk.Ebx.IncomTeamEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

