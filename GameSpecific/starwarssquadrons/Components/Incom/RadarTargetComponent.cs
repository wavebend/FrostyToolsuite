
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RadarTargetComponentData))]
	public class RadarTargetComponent : GameComponent, IEntityData<FrostySdk.Ebx.RadarTargetComponentData>
	{
		public new FrostySdk.Ebx.RadarTargetComponentData Data => data as FrostySdk.Ebx.RadarTargetComponentData;
		public override string DisplayName => "RadarTargetComponent";

		public RadarTargetComponent(FrostySdk.Ebx.RadarTargetComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

