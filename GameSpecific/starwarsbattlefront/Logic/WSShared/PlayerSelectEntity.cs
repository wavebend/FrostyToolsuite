using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PlayerSelectEntityData))]
	public class PlayerSelectEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PlayerSelectEntityData>
	{
		public new FrostySdk.Ebx.PlayerSelectEntityData Data => data as FrostySdk.Ebx.PlayerSelectEntityData;
		public override string DisplayName => "PlayerSelect";

		public PlayerSelectEntity(FrostySdk.Ebx.PlayerSelectEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

