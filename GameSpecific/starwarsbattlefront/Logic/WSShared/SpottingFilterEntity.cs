using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SpottingFilterEntityData))]
	public class SpottingFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SpottingFilterEntityData>
	{
		public new FrostySdk.Ebx.SpottingFilterEntityData Data => data as FrostySdk.Ebx.SpottingFilterEntityData;
		public override string DisplayName => "SpottingFilter";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SpottingFilterEntity(FrostySdk.Ebx.SpottingFilterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

