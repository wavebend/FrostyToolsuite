using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VariablePersistenceFloatEntityData))]
	public class VariablePersistenceFloatEntity : BaseVariablePersistenceEntity, IEntityData<FrostySdk.Ebx.VariablePersistenceFloatEntityData>
	{
		public new FrostySdk.Ebx.VariablePersistenceFloatEntityData Data => data as FrostySdk.Ebx.VariablePersistenceFloatEntityData;
		public override string DisplayName => "VariablePersistenceFloat";

		public VariablePersistenceFloatEntity(FrostySdk.Ebx.VariablePersistenceFloatEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

