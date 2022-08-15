using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceTargetingMenuSelectedIndexEntityData))]
	public class ForceTargetingMenuSelectedIndexEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ForceTargetingMenuSelectedIndexEntityData>
	{
		public new FrostySdk.Ebx.ForceTargetingMenuSelectedIndexEntityData Data => data as FrostySdk.Ebx.ForceTargetingMenuSelectedIndexEntityData;
		public override string DisplayName => "ForceTargetingMenuSelectedIndex";

		public ForceTargetingMenuSelectedIndexEntity(FrostySdk.Ebx.ForceTargetingMenuSelectedIndexEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

