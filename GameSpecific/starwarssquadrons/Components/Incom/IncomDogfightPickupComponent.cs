
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomDogfightPickupComponentData))]
	public class IncomDogfightPickupComponent : GameComponent, IEntityData<FrostySdk.Ebx.IncomDogfightPickupComponentData>
	{
		public new FrostySdk.Ebx.IncomDogfightPickupComponentData Data => data as FrostySdk.Ebx.IncomDogfightPickupComponentData;
		public override string DisplayName => "IncomDogfightPickupComponent";

		public IncomDogfightPickupComponent(FrostySdk.Ebx.IncomDogfightPickupComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

