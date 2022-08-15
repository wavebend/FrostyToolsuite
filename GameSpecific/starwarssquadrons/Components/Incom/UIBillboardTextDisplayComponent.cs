
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBillboardTextDisplayComponentData))]
	public class UIBillboardTextDisplayComponent : GameComponent, IEntityData<FrostySdk.Ebx.UIBillboardTextDisplayComponentData>
	{
		public new FrostySdk.Ebx.UIBillboardTextDisplayComponentData Data => data as FrostySdk.Ebx.UIBillboardTextDisplayComponentData;
		public override string DisplayName => "UIBillboardTextDisplayComponent";

		public UIBillboardTextDisplayComponent(FrostySdk.Ebx.UIBillboardTextDisplayComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

