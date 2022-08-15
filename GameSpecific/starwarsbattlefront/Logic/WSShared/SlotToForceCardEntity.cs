using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SlotToForceCardEntityData))]
	public class SlotToForceCardEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SlotToForceCardEntityData>
	{
		public new FrostySdk.Ebx.SlotToForceCardEntityData Data => data as FrostySdk.Ebx.SlotToForceCardEntityData;
		public override string DisplayName => "SlotToForceCard";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SlotToForceCardEntity(FrostySdk.Ebx.SlotToForceCardEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

