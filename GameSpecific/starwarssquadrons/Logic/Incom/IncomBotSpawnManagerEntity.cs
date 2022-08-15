using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomBotSpawnManagerEntityData))]
	public class IncomBotSpawnManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomBotSpawnManagerEntityData>
	{
		public new FrostySdk.Ebx.IncomBotSpawnManagerEntityData Data => data as FrostySdk.Ebx.IncomBotSpawnManagerEntityData;
		public override string DisplayName => "IncomBotSpawnManager";

		public IncomBotSpawnManagerEntity(FrostySdk.Ebx.IncomBotSpawnManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

