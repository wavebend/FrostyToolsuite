
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.NetworkReplayTrackData))]
	public class NetworkReplayTrack : RecordTrackBase, IEntityData<FrostySdk.Ebx.NetworkReplayTrackData>
	{
		public new FrostySdk.Ebx.NetworkReplayTrackData Data => data as FrostySdk.Ebx.NetworkReplayTrackData;
		public override string DisplayName => "NetworkReplayTrack";

		public NetworkReplayTrack(FrostySdk.Ebx.NetworkReplayTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

