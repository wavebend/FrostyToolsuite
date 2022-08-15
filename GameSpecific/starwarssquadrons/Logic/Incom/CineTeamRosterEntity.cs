using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CineTeamRosterEntityData))]
	public class CineTeamRosterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CineTeamRosterEntityData>
	{
		public new FrostySdk.Ebx.CineTeamRosterEntityData Data => data as FrostySdk.Ebx.CineTeamRosterEntityData;
		public override string DisplayName => "CineTeamRoster";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CineTeamRosterEntity(FrostySdk.Ebx.CineTeamRosterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

