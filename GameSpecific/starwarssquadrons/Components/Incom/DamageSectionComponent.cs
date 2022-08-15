
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DamageSectionComponentData))]
	public class DamageSectionComponent : RadarTargetComponent, IEntityData<FrostySdk.Ebx.DamageSectionComponentData>
	{
		public new FrostySdk.Ebx.DamageSectionComponentData Data => data as FrostySdk.Ebx.DamageSectionComponentData;
		public override string DisplayName => "DamageSectionComponent";

		public DamageSectionComponent(FrostySdk.Ebx.DamageSectionComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

