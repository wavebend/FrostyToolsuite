using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SuperDefenseEntityData))]
	public class SuperDefenseEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SuperDefenseEntityData>
	{
		public new FrostySdk.Ebx.SuperDefenseEntityData Data => data as FrostySdk.Ebx.SuperDefenseEntityData;
		public override string DisplayName => "SuperDefense";

		public SuperDefenseEntity(FrostySdk.Ebx.SuperDefenseEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

