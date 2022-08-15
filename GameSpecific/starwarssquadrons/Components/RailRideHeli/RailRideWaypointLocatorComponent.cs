
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RailRideWaypointLocatorComponentData))]
	public class RailRideWaypointLocatorComponent : GameComponent, IEntityData<FrostySdk.Ebx.RailRideWaypointLocatorComponentData>
	{
		public new FrostySdk.Ebx.RailRideWaypointLocatorComponentData Data => data as FrostySdk.Ebx.RailRideWaypointLocatorComponentData;
		public override string DisplayName => "RailRideWaypointLocatorComponent";

		public RailRideWaypointLocatorComponent(FrostySdk.Ebx.RailRideWaypointLocatorComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

