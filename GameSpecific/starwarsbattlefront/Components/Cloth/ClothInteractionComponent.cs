
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ClothInteractionComponentData))]
	public class ClothInteractionComponent : Component, IEntityData<FrostySdk.Ebx.ClothInteractionComponentData>
	{
		public new FrostySdk.Ebx.ClothInteractionComponentData Data => data as FrostySdk.Ebx.ClothInteractionComponentData;
		public override string DisplayName => "ClothInteractionComponent";

		public ClothInteractionComponent(FrostySdk.Ebx.ClothInteractionComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

