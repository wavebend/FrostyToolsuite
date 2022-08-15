using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceCardSlotEntityData))]
	public class ForceCardSlotEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ForceCardSlotEntityData>
	{
		public new FrostySdk.Ebx.ForceCardSlotEntityData Data => data as FrostySdk.Ebx.ForceCardSlotEntityData;
		public override string DisplayName => "ForceCardSlot";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ForceCardSlotEntity(FrostySdk.Ebx.ForceCardSlotEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

