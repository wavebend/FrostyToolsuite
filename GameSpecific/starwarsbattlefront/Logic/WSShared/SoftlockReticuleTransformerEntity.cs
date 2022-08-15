using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoftlockReticuleTransformerEntityData))]
	public class SoftlockReticuleTransformerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SoftlockReticuleTransformerEntityData>
	{
		public new FrostySdk.Ebx.SoftlockReticuleTransformerEntityData Data => data as FrostySdk.Ebx.SoftlockReticuleTransformerEntityData;
		public override string DisplayName => "SoftlockReticuleTransformer";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SoftlockReticuleTransformerEntity(FrostySdk.Ebx.SoftlockReticuleTransformerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

