using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SetSkillCardEntityData))]
	public class SetSkillCardEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SetSkillCardEntityData>
	{
		public new FrostySdk.Ebx.SetSkillCardEntityData Data => data as FrostySdk.Ebx.SetSkillCardEntityData;
		public override string DisplayName => "SetSkillCard";

		public SetSkillCardEntity(FrostySdk.Ebx.SetSkillCardEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

