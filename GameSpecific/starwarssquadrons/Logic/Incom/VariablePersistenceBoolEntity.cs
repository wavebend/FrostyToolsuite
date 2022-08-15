using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VariablePersistenceBoolEntityData))]
	public class VariablePersistenceBoolEntity : BaseVariablePersistenceEntity, IEntityData<FrostySdk.Ebx.VariablePersistenceBoolEntityData>
	{
		public new FrostySdk.Ebx.VariablePersistenceBoolEntityData Data => data as FrostySdk.Ebx.VariablePersistenceBoolEntityData;
		public override string DisplayName => "VariablePersistenceBool";

		public VariablePersistenceBoolEntity(FrostySdk.Ebx.VariablePersistenceBoolEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

