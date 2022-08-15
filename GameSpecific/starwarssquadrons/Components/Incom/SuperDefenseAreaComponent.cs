
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SuperDefenseAreaComponentData))]
	public class SuperDefenseAreaComponent : GameComponent, IEntityData<FrostySdk.Ebx.SuperDefenseAreaComponentData>
	{
		public new FrostySdk.Ebx.SuperDefenseAreaComponentData Data => data as FrostySdk.Ebx.SuperDefenseAreaComponentData;
		public override string DisplayName => "SuperDefenseAreaComponent";

		public SuperDefenseAreaComponent(FrostySdk.Ebx.SuperDefenseAreaComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

