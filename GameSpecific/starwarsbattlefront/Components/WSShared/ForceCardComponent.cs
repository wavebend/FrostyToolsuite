
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceCardComponentData))]
	public class ForceCardComponent : GameComponent, IEntityData<FrostySdk.Ebx.ForceCardComponentData>
	{
		public new FrostySdk.Ebx.ForceCardComponentData Data => data as FrostySdk.Ebx.ForceCardComponentData;
		public override string DisplayName => "ForceCardComponent";

		public ForceCardComponent(FrostySdk.Ebx.ForceCardComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

