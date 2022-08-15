
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomStaticModelHealthComponentData))]
	public class IncomStaticModelHealthComponent : StaticModelHealthComponent, IEntityData<FrostySdk.Ebx.IncomStaticModelHealthComponentData>
	{
		public new FrostySdk.Ebx.IncomStaticModelHealthComponentData Data => data as FrostySdk.Ebx.IncomStaticModelHealthComponentData;
		public override string DisplayName => "IncomStaticModelHealthComponent";

		public IncomStaticModelHealthComponent(FrostySdk.Ebx.IncomStaticModelHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

