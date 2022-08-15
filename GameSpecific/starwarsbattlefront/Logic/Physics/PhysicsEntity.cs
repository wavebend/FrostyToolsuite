using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PhysicsEntityData))]
	public class PhysicsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PhysicsEntityData>
	{
		public new FrostySdk.Ebx.PhysicsEntityData Data => data as FrostySdk.Ebx.PhysicsEntityData;
		public override string DisplayName => "Physics";

		public PhysicsEntity(FrostySdk.Ebx.PhysicsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

