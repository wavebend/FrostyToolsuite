using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomDifficultyDataEntityData))]
	public class IncomDifficultyDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomDifficultyDataEntityData>
	{
		public new FrostySdk.Ebx.IncomDifficultyDataEntityData Data => data as FrostySdk.Ebx.IncomDifficultyDataEntityData;
		public override string DisplayName => "IncomDifficultyData";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomDifficultyDataEntity(FrostySdk.Ebx.IncomDifficultyDataEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

