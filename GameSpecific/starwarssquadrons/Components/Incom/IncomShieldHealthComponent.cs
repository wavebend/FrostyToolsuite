
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomShieldHealthComponentData))]
	public class IncomShieldHealthComponent : ShieldHealthComponent, IEntityData<FrostySdk.Ebx.IncomShieldHealthComponentData>
	{
		public new FrostySdk.Ebx.IncomShieldHealthComponentData Data => data as FrostySdk.Ebx.IncomShieldHealthComponentData;
		public override string DisplayName => "IncomShieldHealthComponent";

		public IncomShieldHealthComponent(FrostySdk.Ebx.IncomShieldHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

