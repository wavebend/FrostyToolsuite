using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSpawnHelperEntityData))]
	public class IncomSpawnHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSpawnHelperEntityData>
	{
		public new FrostySdk.Ebx.IncomSpawnHelperEntityData Data => data as FrostySdk.Ebx.IncomSpawnHelperEntityData;
		public override string DisplayName => "IncomSpawnHelper";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomSpawnHelperEntity(FrostySdk.Ebx.IncomSpawnHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

