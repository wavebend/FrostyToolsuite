using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HitSoloPVBProgressionCapEntityData))]
	public class HitSoloPVBProgressionCapEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HitSoloPVBProgressionCapEntityData>
	{
		public new FrostySdk.Ebx.HitSoloPVBProgressionCapEntityData Data => data as FrostySdk.Ebx.HitSoloPVBProgressionCapEntityData;
		public override string DisplayName => "HitSoloPVBProgressionCap";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public HitSoloPVBProgressionCapEntity(FrostySdk.Ebx.HitSoloPVBProgressionCapEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

