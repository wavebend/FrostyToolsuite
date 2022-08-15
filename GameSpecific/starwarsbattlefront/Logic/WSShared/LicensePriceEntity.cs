using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LicensePriceEntityData))]
	public class LicensePriceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LicensePriceEntityData>
	{
		public new FrostySdk.Ebx.LicensePriceEntityData Data => data as FrostySdk.Ebx.LicensePriceEntityData;
		public override string DisplayName => "LicensePrice";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public LicensePriceEntity(FrostySdk.Ebx.LicensePriceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

