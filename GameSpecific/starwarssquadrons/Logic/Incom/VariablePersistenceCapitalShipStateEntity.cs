using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VariablePersistenceCapitalShipStateEntityData))]
	public class VariablePersistenceCapitalShipStateEntity : BaseVariablePersistenceEntity, IEntityData<FrostySdk.Ebx.VariablePersistenceCapitalShipStateEntityData>
	{
		public new FrostySdk.Ebx.VariablePersistenceCapitalShipStateEntityData Data => data as FrostySdk.Ebx.VariablePersistenceCapitalShipStateEntityData;
		public override string DisplayName => "VariablePersistenceCapitalShipState";

		public VariablePersistenceCapitalShipStateEntity(FrostySdk.Ebx.VariablePersistenceCapitalShipStateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

