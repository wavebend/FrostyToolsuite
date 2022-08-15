using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HeadOutOfBoundsDetectionEntityData))]
	public class HeadOutOfBoundsDetectionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HeadOutOfBoundsDetectionEntityData>
	{
		public new FrostySdk.Ebx.HeadOutOfBoundsDetectionEntityData Data => data as FrostySdk.Ebx.HeadOutOfBoundsDetectionEntityData;
		public override string DisplayName => "HeadOutOfBoundsDetection";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public HeadOutOfBoundsDetectionEntity(FrostySdk.Ebx.HeadOutOfBoundsDetectionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

