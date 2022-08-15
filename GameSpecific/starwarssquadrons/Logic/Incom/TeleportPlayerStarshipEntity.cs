using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TeleportPlayerStarshipEntityData))]
	public class TeleportPlayerStarshipEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TeleportPlayerStarshipEntityData>
	{
		public new FrostySdk.Ebx.TeleportPlayerStarshipEntityData Data => data as FrostySdk.Ebx.TeleportPlayerStarshipEntityData;
		public override string DisplayName => "TeleportPlayerStarship";

		public TeleportPlayerStarshipEntity(FrostySdk.Ebx.TeleportPlayerStarshipEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

