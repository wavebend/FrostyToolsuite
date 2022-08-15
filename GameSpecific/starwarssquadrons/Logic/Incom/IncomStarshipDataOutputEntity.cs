using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomStarshipDataOutputEntityData))]
	public class IncomStarshipDataOutputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomStarshipDataOutputEntityData>
	{
		public new FrostySdk.Ebx.IncomStarshipDataOutputEntityData Data => data as FrostySdk.Ebx.IncomStarshipDataOutputEntityData;
		public override string DisplayName => "IncomStarshipDataOutput";

		public IncomStarshipDataOutputEntity(FrostySdk.Ebx.IncomStarshipDataOutputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

