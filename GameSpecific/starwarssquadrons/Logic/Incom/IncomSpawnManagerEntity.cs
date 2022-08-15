using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSpawnManagerEntityData))]
	public class IncomSpawnManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomSpawnManagerEntityData>
	{
		public new FrostySdk.Ebx.IncomSpawnManagerEntityData Data => data as FrostySdk.Ebx.IncomSpawnManagerEntityData;
		public override string DisplayName => "IncomSpawnManager";

		public IncomSpawnManagerEntity(FrostySdk.Ebx.IncomSpawnManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

