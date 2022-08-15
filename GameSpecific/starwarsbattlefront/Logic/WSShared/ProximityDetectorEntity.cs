using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ProximityDetectorEntityData))]
	public class ProximityDetectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ProximityDetectorEntityData>
	{
		public new FrostySdk.Ebx.ProximityDetectorEntityData Data => data as FrostySdk.Ebx.ProximityDetectorEntityData;
		public override string DisplayName => "ProximityDetector";

		public ProximityDetectorEntity(FrostySdk.Ebx.ProximityDetectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

