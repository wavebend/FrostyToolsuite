using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.InstantActionsListEntityData))]
	public class InstantActionsListEntity : LogicEntity, IEntityData<FrostySdk.Ebx.InstantActionsListEntityData>
	{
		public new FrostySdk.Ebx.InstantActionsListEntityData Data => data as FrostySdk.Ebx.InstantActionsListEntityData;
		public override string DisplayName => "InstantActionsList";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public InstantActionsListEntity(FrostySdk.Ebx.InstantActionsListEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

