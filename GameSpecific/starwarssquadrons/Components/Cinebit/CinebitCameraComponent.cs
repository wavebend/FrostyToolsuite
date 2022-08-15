
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinebitCameraComponentData))]
	public class CinebitCameraComponent : GameComponent, IEntityData<FrostySdk.Ebx.CinebitCameraComponentData>
	{
		public new FrostySdk.Ebx.CinebitCameraComponentData Data => data as FrostySdk.Ebx.CinebitCameraComponentData;
		public override string DisplayName => "CinebitCameraComponent";

		public CinebitCameraComponent(FrostySdk.Ebx.CinebitCameraComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

