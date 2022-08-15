using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceCardManagerEntityData))]
	public class ForceCardManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ForceCardManagerEntityData>
	{
		public new FrostySdk.Ebx.ForceCardManagerEntityData Data => data as FrostySdk.Ebx.ForceCardManagerEntityData;
		public override string DisplayName => "ForceCardManager";

		public ForceCardManagerEntity(FrostySdk.Ebx.ForceCardManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

