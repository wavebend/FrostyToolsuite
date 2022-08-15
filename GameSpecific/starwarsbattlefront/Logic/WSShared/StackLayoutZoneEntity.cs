using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StackLayoutZoneEntityData))]
	public class StackLayoutZoneEntity : WSUIElementEntity, IEntityData<FrostySdk.Ebx.StackLayoutZoneEntityData>
	{
		public new FrostySdk.Ebx.StackLayoutZoneEntityData Data => data as FrostySdk.Ebx.StackLayoutZoneEntityData;
		public override string DisplayName => "StackLayoutZone";

		public StackLayoutZoneEntity(FrostySdk.Ebx.StackLayoutZoneEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

