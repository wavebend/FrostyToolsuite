using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ApplyJoystickOverridesEntityData))]
	public class ApplyJoystickOverridesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ApplyJoystickOverridesEntityData>
	{
		public new FrostySdk.Ebx.ApplyJoystickOverridesEntityData Data => data as FrostySdk.Ebx.ApplyJoystickOverridesEntityData;
		public override string DisplayName => "ApplyJoystickOverrides";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ApplyJoystickOverridesEntity(FrostySdk.Ebx.ApplyJoystickOverridesEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

