
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ConductorNodeComponentData))]
	public class ConductorNodeComponent : GameComponent, IEntityData<FrostySdk.Ebx.ConductorNodeComponentData>
	{
		public new FrostySdk.Ebx.ConductorNodeComponentData Data => data as FrostySdk.Ebx.ConductorNodeComponentData;
		public override string DisplayName => "ConductorNodeComponent";

		public ConductorNodeComponent(FrostySdk.Ebx.ConductorNodeComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

