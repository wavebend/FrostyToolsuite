using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VoEventDisablerEntityData))]
	public class VoEventDisablerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VoEventDisablerEntityData>
	{
		public new FrostySdk.Ebx.VoEventDisablerEntityData Data => data as FrostySdk.Ebx.VoEventDisablerEntityData;
		public override string DisplayName => "VoEventDisabler";

		public VoEventDisablerEntity(FrostySdk.Ebx.VoEventDisablerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

