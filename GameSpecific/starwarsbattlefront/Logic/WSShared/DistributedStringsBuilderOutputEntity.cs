using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DistributedStringsBuilderOutputEntityData))]
	public class DistributedStringsBuilderOutputEntity : DistributedStringsBuilderEntity, IEntityData<FrostySdk.Ebx.DistributedStringsBuilderOutputEntityData>
	{
		public new FrostySdk.Ebx.DistributedStringsBuilderOutputEntityData Data => data as FrostySdk.Ebx.DistributedStringsBuilderOutputEntityData;
		public override string DisplayName => "DistributedStringsBuilderOutput";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DistributedStringsBuilderOutputEntity(FrostySdk.Ebx.DistributedStringsBuilderOutputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

