
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SubtitleTrackData))]
	public class SubtitleTrack : TimelineTrack, IEntityData<FrostySdk.Ebx.SubtitleTrackData>
	{
		public new FrostySdk.Ebx.SubtitleTrackData Data => data as FrostySdk.Ebx.SubtitleTrackData;
		public override string DisplayName => "SubtitleTrack";

		public SubtitleTrack(FrostySdk.Ebx.SubtitleTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

