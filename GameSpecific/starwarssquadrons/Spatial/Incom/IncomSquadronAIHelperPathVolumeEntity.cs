using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSquadronAIHelperPathVolumeEntityData))]
	public class IncomSquadronAIHelperPathVolumeEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.IncomSquadronAIHelperPathVolumeEntityData>
	{
		public new FrostySdk.Ebx.IncomSquadronAIHelperPathVolumeEntityData Data => data as FrostySdk.Ebx.IncomSquadronAIHelperPathVolumeEntityData;

		public IncomSquadronAIHelperPathVolumeEntity(FrostySdk.Ebx.IncomSquadronAIHelperPathVolumeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

