using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ObjectPoolManagerData))]
	public class ObjectPoolManager : LogicEntity, IEntityData<FrostySdk.Ebx.ObjectPoolManagerData>
	{
		public new FrostySdk.Ebx.ObjectPoolManagerData Data => data as FrostySdk.Ebx.ObjectPoolManagerData;
		public override string DisplayName => "ObjectPoolManager";

		public ObjectPoolManager(FrostySdk.Ebx.ObjectPoolManagerData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

