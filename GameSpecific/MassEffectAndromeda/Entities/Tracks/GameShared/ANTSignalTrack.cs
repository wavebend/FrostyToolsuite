
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ANTSignalTrackData))]
	public class ANTSignalTrack : LinkTrack, IEntityData<FrostySdk.Ebx.ANTSignalTrackData>
	{
		public new FrostySdk.Ebx.ANTSignalTrackData Data => data as FrostySdk.Ebx.ANTSignalTrackData;
		public override string DisplayName => "ANTSignalTrack";
		public override string Icon => "Images/Tracks/AntTrack.png";

		public ANTSignalTrack(FrostySdk.Ebx.ANTSignalTrackData inData, Entity inParent)
			: base(inData, inParent)
		{
			foreach (var objRef in Data.SignalTracks)
			{
				AddTrack(objRef);
			}
		}
	}
}
