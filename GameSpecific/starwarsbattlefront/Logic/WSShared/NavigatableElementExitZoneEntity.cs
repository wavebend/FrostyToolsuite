using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.NavigatableElementExitZoneEntityData))]
	public class NavigatableElementExitZoneEntity : NavigatableElementEntity, IEntityData<FrostySdk.Ebx.NavigatableElementExitZoneEntityData>
	{
		public new FrostySdk.Ebx.NavigatableElementExitZoneEntityData Data => data as FrostySdk.Ebx.NavigatableElementExitZoneEntityData;
		public override string DisplayName => "NavigatableElementExitZone";

		public NavigatableElementExitZoneEntity(FrostySdk.Ebx.NavigatableElementExitZoneEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

