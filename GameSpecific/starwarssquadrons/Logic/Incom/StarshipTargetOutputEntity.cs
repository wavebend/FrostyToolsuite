using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipTargetOutputEntityData))]
	public class StarshipTargetOutputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipTargetOutputEntityData>
	{
		public new FrostySdk.Ebx.StarshipTargetOutputEntityData Data => data as FrostySdk.Ebx.StarshipTargetOutputEntityData;
		public override string DisplayName => "StarshipTargetOutput";

		public StarshipTargetOutputEntity(FrostySdk.Ebx.StarshipTargetOutputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

