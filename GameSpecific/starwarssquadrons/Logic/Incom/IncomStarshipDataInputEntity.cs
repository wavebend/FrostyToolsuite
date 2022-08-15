using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomStarshipDataInputEntityData))]
	public class IncomStarshipDataInputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomStarshipDataInputEntityData>
	{
		public new FrostySdk.Ebx.IncomStarshipDataInputEntityData Data => data as FrostySdk.Ebx.IncomStarshipDataInputEntityData;
		public override string DisplayName => "IncomStarshipDataInput";

		public IncomStarshipDataInputEntity(FrostySdk.Ebx.IncomStarshipDataInputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

