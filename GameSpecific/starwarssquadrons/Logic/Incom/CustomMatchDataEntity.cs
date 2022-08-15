using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomMatchDataEntityData))]
	public class CustomMatchDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomMatchDataEntityData>
	{
		public new FrostySdk.Ebx.CustomMatchDataEntityData Data => data as FrostySdk.Ebx.CustomMatchDataEntityData;
		public override string DisplayName => "CustomMatchData";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CustomMatchDataEntity(FrostySdk.Ebx.CustomMatchDataEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

