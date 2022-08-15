using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DeepLinkParameterTranslatorMultiplayerEntityData))]
	public class DeepLinkParameterTranslatorMultiplayerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DeepLinkParameterTranslatorMultiplayerEntityData>
	{
		public new FrostySdk.Ebx.DeepLinkParameterTranslatorMultiplayerEntityData Data => data as FrostySdk.Ebx.DeepLinkParameterTranslatorMultiplayerEntityData;
		public override string DisplayName => "DeepLinkParameterTranslatorMultiplayer";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DeepLinkParameterTranslatorMultiplayerEntity(FrostySdk.Ebx.DeepLinkParameterTranslatorMultiplayerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

