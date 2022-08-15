using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineMatchTimerEntityData))]
	public class FrontlineMatchTimerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FrontlineMatchTimerEntityData>
	{
		public new FrostySdk.Ebx.FrontlineMatchTimerEntityData Data => data as FrostySdk.Ebx.FrontlineMatchTimerEntityData;
		public override string DisplayName => "FrontlineMatchTimer";

		public FrontlineMatchTimerEntity(FrostySdk.Ebx.FrontlineMatchTimerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

