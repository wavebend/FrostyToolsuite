
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomMissileHealthComponentData))]
	public class IncomMissileHealthComponent : GameHealthComponent, IEntityData<FrostySdk.Ebx.IncomMissileHealthComponentData>
	{
		public new FrostySdk.Ebx.IncomMissileHealthComponentData Data => data as FrostySdk.Ebx.IncomMissileHealthComponentData;
		public override string DisplayName => "IncomMissileHealthComponent";

		public IncomMissileHealthComponent(FrostySdk.Ebx.IncomMissileHealthComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

