using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIRewardTrackEntityData))]
	public class IncomUIRewardTrackEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIRewardTrackEntityData>
	{
		public new FrostySdk.Ebx.IncomUIRewardTrackEntityData Data => data as FrostySdk.Ebx.IncomUIRewardTrackEntityData;
		public override string DisplayName => "IncomUIRewardTrack";

		public IncomUIRewardTrackEntity(FrostySdk.Ebx.IncomUIRewardTrackEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

