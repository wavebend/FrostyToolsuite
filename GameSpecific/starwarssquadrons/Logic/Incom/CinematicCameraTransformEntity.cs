using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinematicCameraTransformEntityData))]
	public class CinematicCameraTransformEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CinematicCameraTransformEntityData>
	{
		public new FrostySdk.Ebx.CinematicCameraTransformEntityData Data => data as FrostySdk.Ebx.CinematicCameraTransformEntityData;
		public override string DisplayName => "CinematicCameraTransform";

		public CinematicCameraTransformEntity(FrostySdk.Ebx.CinematicCameraTransformEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

