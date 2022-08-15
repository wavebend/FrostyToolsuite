using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PurchaseLicenseEntityData))]
	public class PurchaseLicenseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PurchaseLicenseEntityData>
	{
		public new FrostySdk.Ebx.PurchaseLicenseEntityData Data => data as FrostySdk.Ebx.PurchaseLicenseEntityData;
		public override string DisplayName => "PurchaseLicense";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PurchaseLicenseEntity(FrostySdk.Ebx.PurchaseLicenseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

