using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IsLinkedControllablePingedEntityData))]
	public class IsLinkedControllablePingedEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IsLinkedControllablePingedEntityData>
	{
		public new FrostySdk.Ebx.IsLinkedControllablePingedEntityData Data => data as FrostySdk.Ebx.IsLinkedControllablePingedEntityData;
		public override string DisplayName => "IsLinkedControllablePinged";

		public IsLinkedControllablePingedEntity(FrostySdk.Ebx.IsLinkedControllablePingedEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

