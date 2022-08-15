using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FaceAnimationLoaderEntityData))]
	public class FaceAnimationLoaderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FaceAnimationLoaderEntityData>
	{
		public new FrostySdk.Ebx.FaceAnimationLoaderEntityData Data => data as FrostySdk.Ebx.FaceAnimationLoaderEntityData;
		public override string DisplayName => "FaceAnimationLoader";

		public FaceAnimationLoaderEntity(FrostySdk.Ebx.FaceAnimationLoaderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

