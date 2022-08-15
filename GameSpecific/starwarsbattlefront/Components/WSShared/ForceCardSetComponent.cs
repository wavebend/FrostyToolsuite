
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceCardSetComponentData))]
	public class ForceCardSetComponent : GameComponent, IEntityData<FrostySdk.Ebx.ForceCardSetComponentData>
	{
		public new FrostySdk.Ebx.ForceCardSetComponentData Data => data as FrostySdk.Ebx.ForceCardSetComponentData;
		public override string DisplayName => "ForceCardSetComponent";

		public ForceCardSetComponent(FrostySdk.Ebx.ForceCardSetComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

