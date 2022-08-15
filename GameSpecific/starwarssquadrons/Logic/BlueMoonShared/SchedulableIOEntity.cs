using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SchedulableIOEntityData))]
	public class SchedulableIOEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SchedulableIOEntityData>
	{
		public new FrostySdk.Ebx.SchedulableIOEntityData Data => data as FrostySdk.Ebx.SchedulableIOEntityData;
		public override string DisplayName => "SchedulableIO";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SchedulableIOEntity(FrostySdk.Ebx.SchedulableIOEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

