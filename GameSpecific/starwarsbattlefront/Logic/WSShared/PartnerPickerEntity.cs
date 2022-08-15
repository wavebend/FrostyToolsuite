using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PartnerPickerEntityData))]
	public class PartnerPickerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PartnerPickerEntityData>
	{
		public new FrostySdk.Ebx.PartnerPickerEntityData Data => data as FrostySdk.Ebx.PartnerPickerEntityData;
		public override string DisplayName => "PartnerPicker";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PartnerPickerEntity(FrostySdk.Ebx.PartnerPickerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

