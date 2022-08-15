using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.XWingVRHandlingPhysicsActionData))]
	public class XWingVRHandlingPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.XWingVRHandlingPhysicsActionData>
	{
		public new FrostySdk.Ebx.XWingVRHandlingPhysicsActionData Data => data as FrostySdk.Ebx.XWingVRHandlingPhysicsActionData;
		public override string DisplayName => "XWingVRHandlingPhysicsAction";

		public XWingVRHandlingPhysicsAction(FrostySdk.Ebx.XWingVRHandlingPhysicsActionData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

