
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PilotCustomizationComponentData))]
	public class PilotCustomizationComponent : CharacterCustomizationComponent, IEntityData<FrostySdk.Ebx.PilotCustomizationComponentData>
	{
		public new FrostySdk.Ebx.PilotCustomizationComponentData Data => data as FrostySdk.Ebx.PilotCustomizationComponentData;
		public override string DisplayName => "PilotCustomizationComponent";

		public PilotCustomizationComponent(FrostySdk.Ebx.PilotCustomizationComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

