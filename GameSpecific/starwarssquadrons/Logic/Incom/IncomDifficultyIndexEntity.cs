using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomDifficultyIndexEntityData))]
	public class IncomDifficultyIndexEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomDifficultyIndexEntityData>
	{
		public new FrostySdk.Ebx.IncomDifficultyIndexEntityData Data => data as FrostySdk.Ebx.IncomDifficultyIndexEntityData;
		public override string DisplayName => "IncomDifficultyIndex";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomDifficultyIndexEntity(FrostySdk.Ebx.IncomDifficultyIndexEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

