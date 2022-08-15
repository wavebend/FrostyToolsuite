
namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUITargetBracketHelperComponentData))]
	public class IncomUITargetBracketHelperComponent : GameComponent, IEntityData<FrostySdk.Ebx.IncomUITargetBracketHelperComponentData>
	{
		public new FrostySdk.Ebx.IncomUITargetBracketHelperComponentData Data => data as FrostySdk.Ebx.IncomUITargetBracketHelperComponentData;
		public override string DisplayName => "IncomUITargetBracketHelperComponent";

		public IncomUITargetBracketHelperComponent(FrostySdk.Ebx.IncomUITargetBracketHelperComponentData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

