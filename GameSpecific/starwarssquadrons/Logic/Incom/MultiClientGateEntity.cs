using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MultiClientGateEntityData))]
	public class MultiClientGateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MultiClientGateEntityData>
	{
		public new FrostySdk.Ebx.MultiClientGateEntityData Data => data as FrostySdk.Ebx.MultiClientGateEntityData;
		public override string DisplayName => "MultiClientGate";

		public MultiClientGateEntity(FrostySdk.Ebx.MultiClientGateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

