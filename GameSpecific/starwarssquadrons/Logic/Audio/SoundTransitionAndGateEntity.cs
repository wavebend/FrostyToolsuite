using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoundTransitionAndGateEntityData))]
	public class SoundTransitionAndGateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SoundTransitionAndGateEntityData>
	{
		public new FrostySdk.Ebx.SoundTransitionAndGateEntityData Data => data as FrostySdk.Ebx.SoundTransitionAndGateEntityData;
		public override string DisplayName => "SoundTransitionAndGate";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SoundTransitionAndGateEntity(FrostySdk.Ebx.SoundTransitionAndGateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

