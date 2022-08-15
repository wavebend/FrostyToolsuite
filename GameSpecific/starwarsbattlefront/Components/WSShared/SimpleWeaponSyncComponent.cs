
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SimpleWeaponSyncComponentData))]
	public class SimpleWeaponSyncComponent : GameComponent, IEntityData<FrostySdk.Ebx.SimpleWeaponSyncComponentData>
	{
		public new FrostySdk.Ebx.SimpleWeaponSyncComponentData Data => data as FrostySdk.Ebx.SimpleWeaponSyncComponentData;
		public override string DisplayName => "SimpleWeaponSyncComponent";

		public SimpleWeaponSyncComponent(FrostySdk.Ebx.SimpleWeaponSyncComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

