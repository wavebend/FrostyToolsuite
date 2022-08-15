using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HutContractsEntityData))]
	public class HutContractsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HutContractsEntityData>
	{
		public new FrostySdk.Ebx.HutContractsEntityData Data => data as FrostySdk.Ebx.HutContractsEntityData;
		public override string DisplayName => "HutContracts";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public HutContractsEntity(FrostySdk.Ebx.HutContractsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

