using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomNextMultiplayerLevelEntityData))]
	public class IncomNextMultiplayerLevelEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomNextMultiplayerLevelEntityData>
	{
		public new FrostySdk.Ebx.IncomNextMultiplayerLevelEntityData Data => data as FrostySdk.Ebx.IncomNextMultiplayerLevelEntityData;
		public override string DisplayName => "IncomNextMultiplayerLevel";

		public IncomNextMultiplayerLevelEntity(FrostySdk.Ebx.IncomNextMultiplayerLevelEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

