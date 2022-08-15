
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipWeaponComponentData))]
	public class StarshipWeaponComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipWeaponComponentData>
	{
		public new FrostySdk.Ebx.StarshipWeaponComponentData Data => data as FrostySdk.Ebx.StarshipWeaponComponentData;
		public override string DisplayName => "StarshipWeaponComponent";

		public StarshipWeaponComponent(FrostySdk.Ebx.StarshipWeaponComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

