using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.NavigatableElementButtonEntityData))]
	public class NavigatableElementButtonEntity : NavigatableElementEntity, IEntityData<FrostySdk.Ebx.NavigatableElementButtonEntityData>
	{
		public new FrostySdk.Ebx.NavigatableElementButtonEntityData Data => data as FrostySdk.Ebx.NavigatableElementButtonEntityData;
		public override string DisplayName => "NavigatableElementButton";

		public NavigatableElementButtonEntity(FrostySdk.Ebx.NavigatableElementButtonEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

