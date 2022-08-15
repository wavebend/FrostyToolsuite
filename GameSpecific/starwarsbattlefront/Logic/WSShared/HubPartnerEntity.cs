using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubPartnerEntityData))]
	public class HubPartnerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HubPartnerEntityData>
	{
		public new FrostySdk.Ebx.HubPartnerEntityData Data => data as FrostySdk.Ebx.HubPartnerEntityData;
		public override string DisplayName => "HubPartner";

		public HubPartnerEntity(FrostySdk.Ebx.HubPartnerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

