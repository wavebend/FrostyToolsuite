using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DeepLinkParameterTranslatorMissionsEntityData))]
	public class DeepLinkParameterTranslatorMissionsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DeepLinkParameterTranslatorMissionsEntityData>
	{
		public new FrostySdk.Ebx.DeepLinkParameterTranslatorMissionsEntityData Data => data as FrostySdk.Ebx.DeepLinkParameterTranslatorMissionsEntityData;
		public override string DisplayName => "DeepLinkParameterTranslatorMissions";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DeepLinkParameterTranslatorMissionsEntity(FrostySdk.Ebx.DeepLinkParameterTranslatorMissionsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

