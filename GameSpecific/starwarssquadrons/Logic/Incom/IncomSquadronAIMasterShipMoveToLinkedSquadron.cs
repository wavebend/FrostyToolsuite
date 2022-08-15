using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIMasterShipMoveToLinkedSquadronData))]
	public class IncomSquadronAIMasterShipMoveToLinkedSquadron : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIMasterShipMoveToLinkedSquadronData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIMasterShipMoveToLinkedSquadronData Data => data as FrostySdk.Ebx.IncomSquadronAIMasterShipMoveToLinkedSquadronData;
		public override string DisplayName => "IncomSquadronAIMasterShipMoveToLinkedSquadron";

		public IncomSquadronAIMasterShipMoveToLinkedSquadron(FrostySdk.Ebx.IncomSquadronAIMasterShipMoveToLinkedSquadronData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

