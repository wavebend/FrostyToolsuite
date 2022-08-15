using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LevelInformationEntityData))]
	public class LevelInformationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LevelInformationEntityData>
	{
		public new FrostySdk.Ebx.LevelInformationEntityData Data => data as FrostySdk.Ebx.LevelInformationEntityData;
		public override string DisplayName => "LevelInformation";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public LevelInformationEntity(FrostySdk.Ebx.LevelInformationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

