using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CountTimerEntityData))]
	public class CountTimerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CountTimerEntityData>
	{
		public new FrostySdk.Ebx.CountTimerEntityData Data => data as FrostySdk.Ebx.CountTimerEntityData;
		public override string DisplayName => "CountTimer";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CountTimerEntity(FrostySdk.Ebx.CountTimerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

