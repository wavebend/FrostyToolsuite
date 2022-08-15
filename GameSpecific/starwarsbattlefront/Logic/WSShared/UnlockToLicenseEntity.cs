using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UnlockToLicenseEntityData))]
	public class UnlockToLicenseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UnlockToLicenseEntityData>
	{
		public new FrostySdk.Ebx.UnlockToLicenseEntityData Data => data as FrostySdk.Ebx.UnlockToLicenseEntityData;
		public override string DisplayName => "UnlockToLicense";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UnlockToLicenseEntity(FrostySdk.Ebx.UnlockToLicenseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

