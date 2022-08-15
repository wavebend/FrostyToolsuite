using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RagdollPhysicsBodyData))]
	public class RagdollPhysicsBody : PhysicsBody, IEntityData<FrostySdk.Ebx.RagdollPhysicsBodyData>
	{
		public new FrostySdk.Ebx.RagdollPhysicsBodyData Data => data as FrostySdk.Ebx.RagdollPhysicsBodyData;
		public override string DisplayName => "RagdollPhysicsBody";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public RagdollPhysicsBody(FrostySdk.Ebx.RagdollPhysicsBodyData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

