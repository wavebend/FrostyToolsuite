
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ResupplyComponentData))]
	public class ResupplyComponent : GameComponent, IEntityData<FrostySdk.Ebx.ResupplyComponentData>
	{
		public new FrostySdk.Ebx.ResupplyComponentData Data => data as FrostySdk.Ebx.ResupplyComponentData;
		public override string DisplayName => "ResupplyComponent";

		public ResupplyComponent(FrostySdk.Ebx.ResupplyComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

