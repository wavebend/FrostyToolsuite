using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GetPartnerEntityData))]
	public class GetPartnerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GetPartnerEntityData>
	{
		public new FrostySdk.Ebx.GetPartnerEntityData Data => data as FrostySdk.Ebx.GetPartnerEntityData;
		public override string DisplayName => "GetPartner";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public GetPartnerEntity(FrostySdk.Ebx.GetPartnerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

