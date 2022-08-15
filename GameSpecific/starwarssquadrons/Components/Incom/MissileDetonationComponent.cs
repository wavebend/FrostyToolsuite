
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MissileDetonationComponentData))]
	public class MissileDetonationComponent : GameComponent, IEntityData<FrostySdk.Ebx.MissileDetonationComponentData>
	{
		public new FrostySdk.Ebx.MissileDetonationComponentData Data => data as FrostySdk.Ebx.MissileDetonationComponentData;
		public override string DisplayName => "MissileDetonationComponent";

		public MissileDetonationComponent(FrostySdk.Ebx.MissileDetonationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

