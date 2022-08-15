using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.InVRWorldMarkerEntityData))]
	public class InVRWorldMarkerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.InVRWorldMarkerEntityData>
	{
		public new FrostySdk.Ebx.InVRWorldMarkerEntityData Data => data as FrostySdk.Ebx.InVRWorldMarkerEntityData;
		public override string DisplayName => "InVRWorldMarker";

		public InVRWorldMarkerEntity(FrostySdk.Ebx.InVRWorldMarkerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

