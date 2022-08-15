using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierOcclusionEntityData))]
	public class SoldierOcclusionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SoldierOcclusionEntityData>
	{
		public new FrostySdk.Ebx.SoldierOcclusionEntityData Data => data as FrostySdk.Ebx.SoldierOcclusionEntityData;
		public override string DisplayName => "SoldierOcclusion";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SoldierOcclusionEntity(FrostySdk.Ebx.SoldierOcclusionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

