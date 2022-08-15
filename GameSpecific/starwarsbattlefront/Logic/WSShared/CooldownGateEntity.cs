using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CooldownGateEntityData))]
	public class CooldownGateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CooldownGateEntityData>
	{
		public new FrostySdk.Ebx.CooldownGateEntityData Data => data as FrostySdk.Ebx.CooldownGateEntityData;
		public override string DisplayName => "CooldownGate";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CooldownGateEntity(FrostySdk.Ebx.CooldownGateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

