using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SimpleSpawnHelperEntityData))]
	public class SimpleSpawnHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SimpleSpawnHelperEntityData>
	{
		public new FrostySdk.Ebx.SimpleSpawnHelperEntityData Data => data as FrostySdk.Ebx.SimpleSpawnHelperEntityData;
		public override string DisplayName => "SimpleSpawnHelper";

		public SimpleSpawnHelperEntity(FrostySdk.Ebx.SimpleSpawnHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

