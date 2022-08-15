using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.NavigatableElementBlockerZoneEntityData))]
	public class NavigatableElementBlockerZoneEntity : NavigatableElementEntity, IEntityData<FrostySdk.Ebx.NavigatableElementBlockerZoneEntityData>
	{
		public new FrostySdk.Ebx.NavigatableElementBlockerZoneEntityData Data => data as FrostySdk.Ebx.NavigatableElementBlockerZoneEntityData;
		public override string DisplayName => "NavigatableElementBlockerZone";

		public NavigatableElementBlockerZoneEntity(FrostySdk.Ebx.NavigatableElementBlockerZoneEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

