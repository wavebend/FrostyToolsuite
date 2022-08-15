
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.QuadEffectComponentData))]
	public class QuadEffectComponent : VisualEnvironmentComponent, IEntityData<FrostySdk.Ebx.QuadEffectComponentData>
	{
		public new FrostySdk.Ebx.QuadEffectComponentData Data => data as FrostySdk.Ebx.QuadEffectComponentData;
		public override string DisplayName => "QuadEffectComponent";

		public QuadEffectComponent(FrostySdk.Ebx.QuadEffectComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

