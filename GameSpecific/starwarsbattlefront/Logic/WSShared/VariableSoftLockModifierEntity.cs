using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VariableSoftLockModifierEntityData))]
	public class VariableSoftLockModifierEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VariableSoftLockModifierEntityData>
	{
		public new FrostySdk.Ebx.VariableSoftLockModifierEntityData Data => data as FrostySdk.Ebx.VariableSoftLockModifierEntityData;
		public override string DisplayName => "VariableSoftLockModifier";

		public VariableSoftLockModifierEntity(FrostySdk.Ebx.VariableSoftLockModifierEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

