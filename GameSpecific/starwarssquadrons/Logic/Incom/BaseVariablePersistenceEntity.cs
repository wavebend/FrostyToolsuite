using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BaseVariablePersistenceEntityData))]
	public class BaseVariablePersistenceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BaseVariablePersistenceEntityData>
	{
		public new FrostySdk.Ebx.BaseVariablePersistenceEntityData Data => data as FrostySdk.Ebx.BaseVariablePersistenceEntityData;
		public override string DisplayName => "BaseVariablePersistence";

		public BaseVariablePersistenceEntity(FrostySdk.Ebx.BaseVariablePersistenceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

