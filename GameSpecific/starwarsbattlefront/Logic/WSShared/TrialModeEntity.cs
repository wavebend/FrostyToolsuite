using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TrialModeEntityData))]
	public class TrialModeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TrialModeEntityData>
	{
		public new FrostySdk.Ebx.TrialModeEntityData Data => data as FrostySdk.Ebx.TrialModeEntityData;
		public override string DisplayName => "TrialMode";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public TrialModeEntity(FrostySdk.Ebx.TrialModeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

