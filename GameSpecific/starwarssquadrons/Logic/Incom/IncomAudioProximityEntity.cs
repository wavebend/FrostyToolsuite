using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomAudioProximityEntityData))]
	public class IncomAudioProximityEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomAudioProximityEntityData>
	{
		public new FrostySdk.Ebx.IncomAudioProximityEntityData Data => data as FrostySdk.Ebx.IncomAudioProximityEntityData;
		public override string DisplayName => "IncomAudioProximity";

		public IncomAudioProximityEntity(FrostySdk.Ebx.IncomAudioProximityEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

