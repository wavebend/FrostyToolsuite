
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ShockwaveConductorNodeComponentData))]
	public class ShockwaveConductorNodeComponent : GameComponent, IEntityData<FrostySdk.Ebx.ShockwaveConductorNodeComponentData>
	{
		public new FrostySdk.Ebx.ShockwaveConductorNodeComponentData Data => data as FrostySdk.Ebx.ShockwaveConductorNodeComponentData;
		public override string DisplayName => "ShockwaveConductorNodeComponent";

		public ShockwaveConductorNodeComponent(FrostySdk.Ebx.ShockwaveConductorNodeComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

