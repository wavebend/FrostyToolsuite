using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HostedBehaviourLoaderEntityData))]
	public class HostedBehaviourLoaderEntity : LogicReferenceObject, IEntityData<FrostySdk.Ebx.HostedBehaviourLoaderEntityData>
	{
		public new FrostySdk.Ebx.HostedBehaviourLoaderEntityData Data => data as FrostySdk.Ebx.HostedBehaviourLoaderEntityData;

		public HostedBehaviourLoaderEntity(FrostySdk.Ebx.HostedBehaviourLoaderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

