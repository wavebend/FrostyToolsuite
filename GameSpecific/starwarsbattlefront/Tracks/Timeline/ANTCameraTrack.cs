
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ANTCameraTrackData))]
	public class ANTCameraTrack : EntityTrack, IEntityData<FrostySdk.Ebx.ANTCameraTrackData>
	{
		public new FrostySdk.Ebx.ANTCameraTrackData Data => data as FrostySdk.Ebx.ANTCameraTrackData;
		public override string DisplayName => "ANTCameraTrack";

		public ANTCameraTrack(FrostySdk.Ebx.ANTCameraTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

