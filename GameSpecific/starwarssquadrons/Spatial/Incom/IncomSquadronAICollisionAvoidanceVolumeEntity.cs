using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceVolumeEntityData))]
	public class IncomSquadronAICollisionAvoidanceVolumeEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceVolumeEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceVolumeEntityData Data => data as FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceVolumeEntityData;

		public IncomSquadronAICollisionAvoidanceVolumeEntity(FrostySdk.Ebx.IncomSquadronAICollisionAvoidanceVolumeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

