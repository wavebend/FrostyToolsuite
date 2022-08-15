using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ModifyStatsEntityData))]
	public class ModifyStatsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ModifyStatsEntityData>
	{
		public new FrostySdk.Ebx.ModifyStatsEntityData Data => data as FrostySdk.Ebx.ModifyStatsEntityData;
		public override string DisplayName => "ModifyStats";

		public ModifyStatsEntity(FrostySdk.Ebx.ModifyStatsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

