using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SchedulableRimeListAdapterEntityData))]
	public class SchedulableRimeListAdapterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SchedulableRimeListAdapterEntityData>
	{
		public new FrostySdk.Ebx.SchedulableRimeListAdapterEntityData Data => data as FrostySdk.Ebx.SchedulableRimeListAdapterEntityData;
		public override string DisplayName => "SchedulableRimeListAdapter";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SchedulableRimeListAdapterEntity(FrostySdk.Ebx.SchedulableRimeListAdapterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

