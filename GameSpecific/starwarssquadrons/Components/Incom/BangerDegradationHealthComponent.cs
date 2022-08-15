
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BangerDegradationHealthComponentData))]
	public class BangerDegradationHealthComponent : BangerHealthComponent, IEntityData<FrostySdk.Ebx.BangerDegradationHealthComponentData>
	{
		public new FrostySdk.Ebx.BangerDegradationHealthComponentData Data => data as FrostySdk.Ebx.BangerDegradationHealthComponentData;
		public override string DisplayName => "BangerDegradationHealthComponent";

		public BangerDegradationHealthComponent(FrostySdk.Ebx.BangerDegradationHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

