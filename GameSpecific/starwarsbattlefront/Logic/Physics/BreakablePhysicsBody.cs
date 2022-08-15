using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BreakablePhysicsBodyData))]
	public class BreakablePhysicsBody : RigidBody, IEntityData<FrostySdk.Ebx.BreakablePhysicsBodyData>
	{
		public new FrostySdk.Ebx.BreakablePhysicsBodyData Data => data as FrostySdk.Ebx.BreakablePhysicsBodyData;
		public override string DisplayName => "BreakablePhysicsBody";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public BreakablePhysicsBody(FrostySdk.Ebx.BreakablePhysicsBodyData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

