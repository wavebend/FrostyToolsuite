using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PartBoneData))]
	public class PartBone : LogicEntity, IEntityData<FrostySdk.Ebx.PartBoneData>
	{
		public new FrostySdk.Ebx.PartBoneData Data => data as FrostySdk.Ebx.PartBoneData;
		public override string DisplayName => "PartBone";

		public PartBone(FrostySdk.Ebx.PartBoneData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

