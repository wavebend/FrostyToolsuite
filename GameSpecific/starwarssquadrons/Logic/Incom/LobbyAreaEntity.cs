using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LobbyAreaEntityData))]
	public class LobbyAreaEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LobbyAreaEntityData>
	{
		public new FrostySdk.Ebx.LobbyAreaEntityData Data => data as FrostySdk.Ebx.LobbyAreaEntityData;
		public override string DisplayName => "LobbyArea";

		public LobbyAreaEntity(FrostySdk.Ebx.LobbyAreaEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

