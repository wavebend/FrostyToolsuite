using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PersistentMissionsEntityData))]
	public class PersistentMissionsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PersistentMissionsEntityData>
	{
		public new FrostySdk.Ebx.PersistentMissionsEntityData Data => data as FrostySdk.Ebx.PersistentMissionsEntityData;
		public override string DisplayName => "PersistentMissions";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PersistentMissionsEntity(FrostySdk.Ebx.PersistentMissionsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

