using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomGameModeSelectFloatEntityData))]
	public class IncomGameModeSelectFloatEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomGameModeSelectFloatEntityData>
	{
		public new FrostySdk.Ebx.IncomGameModeSelectFloatEntityData Data => data as FrostySdk.Ebx.IncomGameModeSelectFloatEntityData;
		public override string DisplayName => "IncomGameModeSelectFloat";

		public IncomGameModeSelectFloatEntity(FrostySdk.Ebx.IncomGameModeSelectFloatEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

