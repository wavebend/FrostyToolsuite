using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SchedulableEntityData))]
	public class SchedulableEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SchedulableEntityData>
	{
		public new FrostySdk.Ebx.SchedulableEntityData Data => data as FrostySdk.Ebx.SchedulableEntityData;
		public override string DisplayName => "Schedulable";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SchedulableEntity(FrostySdk.Ebx.SchedulableEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

