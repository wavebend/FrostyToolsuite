using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HeadListFilterEntityData))]
	public class HeadListFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HeadListFilterEntityData>
	{
		public new FrostySdk.Ebx.HeadListFilterEntityData Data => data as FrostySdk.Ebx.HeadListFilterEntityData;
		public override string DisplayName => "HeadListFilter";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public HeadListFilterEntity(FrostySdk.Ebx.HeadListFilterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

