using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomCinebitSpectatorPOIInfoEntityData))]
	public class IncomCinebitSpectatorPOIInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomCinebitSpectatorPOIInfoEntityData>
	{
		public new FrostySdk.Ebx.IncomCinebitSpectatorPOIInfoEntityData Data => data as FrostySdk.Ebx.IncomCinebitSpectatorPOIInfoEntityData;
		public override string DisplayName => "IncomCinebitSpectatorPOIInfo";

		public IncomCinebitSpectatorPOIInfoEntity(FrostySdk.Ebx.IncomCinebitSpectatorPOIInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

