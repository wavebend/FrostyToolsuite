using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DroidVOInfoRelayEntityData))]
	public class DroidVOInfoRelayEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DroidVOInfoRelayEntityData>
	{
		public new FrostySdk.Ebx.DroidVOInfoRelayEntityData Data => data as FrostySdk.Ebx.DroidVOInfoRelayEntityData;
		public override string DisplayName => "DroidVOInfoRelay";

		public DroidVOInfoRelayEntity(FrostySdk.Ebx.DroidVOInfoRelayEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

