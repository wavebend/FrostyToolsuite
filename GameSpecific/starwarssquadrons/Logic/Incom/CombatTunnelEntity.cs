using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CombatTunnelEntityData))]
	public class CombatTunnelEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CombatTunnelEntityData>
	{
		public new FrostySdk.Ebx.CombatTunnelEntityData Data => data as FrostySdk.Ebx.CombatTunnelEntityData;
		public override string DisplayName => "CombatTunnel";

		public CombatTunnelEntity(FrostySdk.Ebx.CombatTunnelEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

