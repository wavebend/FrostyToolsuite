
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipCinebitCameraComponentData))]
	public class StarshipCinebitCameraComponent : CinebitCameraComponent, IEntityData<FrostySdk.Ebx.StarshipCinebitCameraComponentData>
	{
		public new FrostySdk.Ebx.StarshipCinebitCameraComponentData Data => data as FrostySdk.Ebx.StarshipCinebitCameraComponentData;
		public override string DisplayName => "StarshipCinebitCameraComponent";

		public StarshipCinebitCameraComponent(FrostySdk.Ebx.StarshipCinebitCameraComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

