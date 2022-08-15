
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipPowerManagementComponentData))]
	public class StarshipPowerManagementComponent : GameComponent, IEntityData<FrostySdk.Ebx.StarshipPowerManagementComponentData>
	{
		public new FrostySdk.Ebx.StarshipPowerManagementComponentData Data => data as FrostySdk.Ebx.StarshipPowerManagementComponentData;
		public override string DisplayName => "StarshipPowerManagementComponent";

		public StarshipPowerManagementComponent(FrostySdk.Ebx.StarshipPowerManagementComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

