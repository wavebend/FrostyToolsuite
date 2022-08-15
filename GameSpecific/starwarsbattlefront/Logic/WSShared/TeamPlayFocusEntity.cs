using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TeamPlayFocusEntityData))]
	public class TeamPlayFocusEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TeamPlayFocusEntityData>
	{
		public new FrostySdk.Ebx.TeamPlayFocusEntityData Data => data as FrostySdk.Ebx.TeamPlayFocusEntityData;
		public override string DisplayName => "TeamPlayFocus";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public TeamPlayFocusEntity(FrostySdk.Ebx.TeamPlayFocusEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

