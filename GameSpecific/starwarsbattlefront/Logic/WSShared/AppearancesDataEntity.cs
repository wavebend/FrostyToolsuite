using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AppearancesDataEntityData))]
	public class AppearancesDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AppearancesDataEntityData>
	{
		public new FrostySdk.Ebx.AppearancesDataEntityData Data => data as FrostySdk.Ebx.AppearancesDataEntityData;
		public override string DisplayName => "AppearancesData";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AppearancesDataEntity(FrostySdk.Ebx.AppearancesDataEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

