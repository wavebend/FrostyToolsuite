
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ApplyAffectorsProjectileBehaviourComponentData))]
	public class ApplyAffectorsProjectileBehaviourComponent : GameComponent, IEntityData<FrostySdk.Ebx.ApplyAffectorsProjectileBehaviourComponentData>
	{
		public new FrostySdk.Ebx.ApplyAffectorsProjectileBehaviourComponentData Data => data as FrostySdk.Ebx.ApplyAffectorsProjectileBehaviourComponentData;
		public override string DisplayName => "ApplyAffectorsProjectileBehaviourComponent";

		public ApplyAffectorsProjectileBehaviourComponent(FrostySdk.Ebx.ApplyAffectorsProjectileBehaviourComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

