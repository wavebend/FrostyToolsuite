using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSchematicAttributesEntityData))]
	public class IncomSchematicAttributesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSchematicAttributesEntityData>
	{
		public new FrostySdk.Ebx.IncomSchematicAttributesEntityData Data => data as FrostySdk.Ebx.IncomSchematicAttributesEntityData;
		public override string DisplayName => "IncomSchematicAttributes";

		public IncomSchematicAttributesEntity(FrostySdk.Ebx.IncomSchematicAttributesEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

