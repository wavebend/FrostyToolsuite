
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceCardUnlockComponentData))]
	public class ForceCardUnlockComponent : UnlockComponent, IEntityData<FrostySdk.Ebx.ForceCardUnlockComponentData>
	{
		public new FrostySdk.Ebx.ForceCardUnlockComponentData Data => data as FrostySdk.Ebx.ForceCardUnlockComponentData;
		public override string DisplayName => "ForceCardUnlockComponent";

		public ForceCardUnlockComponent(FrostySdk.Ebx.ForceCardUnlockComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

