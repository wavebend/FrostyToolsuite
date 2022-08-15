
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ResupplyDroidComponentData))]
	public class ResupplyDroidComponent : ProximityProjectileComponent, IEntityData<FrostySdk.Ebx.ResupplyDroidComponentData>
	{
		public new FrostySdk.Ebx.ResupplyDroidComponentData Data => data as FrostySdk.Ebx.ResupplyDroidComponentData;
		public override string DisplayName => "ResupplyDroidComponent";

		public ResupplyDroidComponent(FrostySdk.Ebx.ResupplyDroidComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

