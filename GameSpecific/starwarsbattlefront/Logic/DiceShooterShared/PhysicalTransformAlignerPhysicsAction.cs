using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PhysicalTransformAlignerPhysicsActionData))]
	public class PhysicalTransformAlignerPhysicsAction : PhysicsActionBase, IEntityData<FrostySdk.Ebx.PhysicalTransformAlignerPhysicsActionData>
	{
		public new FrostySdk.Ebx.PhysicalTransformAlignerPhysicsActionData Data => data as FrostySdk.Ebx.PhysicalTransformAlignerPhysicsActionData;
		public override string DisplayName => "PhysicalTransformAlignerPhysicsAction";

		public PhysicalTransformAlignerPhysicsAction(FrostySdk.Ebx.PhysicalTransformAlignerPhysicsActionData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

