using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VOBanksHandlerEntityData))]
	public class VOBanksHandlerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VOBanksHandlerEntityData>
	{
		public new FrostySdk.Ebx.VOBanksHandlerEntityData Data => data as FrostySdk.Ebx.VOBanksHandlerEntityData;
		public override string DisplayName => "VOBanksHandler";

		public VOBanksHandlerEntity(FrostySdk.Ebx.VOBanksHandlerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

