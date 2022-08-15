using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LobbyCustomizationEntityData))]
	public class LobbyCustomizationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LobbyCustomizationEntityData>
	{
		public new FrostySdk.Ebx.LobbyCustomizationEntityData Data => data as FrostySdk.Ebx.LobbyCustomizationEntityData;
		public override string DisplayName => "LobbyCustomization";

		public LobbyCustomizationEntity(FrostySdk.Ebx.LobbyCustomizationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

