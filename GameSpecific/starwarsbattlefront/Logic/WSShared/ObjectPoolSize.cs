using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ObjectPoolSizeData))]
	public class ObjectPoolSize : LogicEntity, IEntityData<FrostySdk.Ebx.ObjectPoolSizeData>
	{
		public new FrostySdk.Ebx.ObjectPoolSizeData Data => data as FrostySdk.Ebx.ObjectPoolSizeData;
		public override string DisplayName => "ObjectPoolSize";

		public ObjectPoolSize(FrostySdk.Ebx.ObjectPoolSizeData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

