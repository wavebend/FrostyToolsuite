using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClientGetOfferConfigListEntityData))]
	public class ClientGetOfferConfigListEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ClientGetOfferConfigListEntityData>
	{
		public new FrostySdk.Ebx.ClientGetOfferConfigListEntityData Data => data as FrostySdk.Ebx.ClientGetOfferConfigListEntityData;
		public override string DisplayName => "ClientGetOfferConfigList";

		public ClientGetOfferConfigListEntity(FrostySdk.Ebx.ClientGetOfferConfigListEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

