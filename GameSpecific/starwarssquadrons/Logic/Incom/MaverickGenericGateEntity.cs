using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MaverickGenericGateEntityData))]
	public class MaverickGenericGateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MaverickGenericGateEntityData>
	{
		public new FrostySdk.Ebx.MaverickGenericGateEntityData Data => data as FrostySdk.Ebx.MaverickGenericGateEntityData;
		public override string DisplayName => "MaverickGenericGate";

		public MaverickGenericGateEntity(FrostySdk.Ebx.MaverickGenericGateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

