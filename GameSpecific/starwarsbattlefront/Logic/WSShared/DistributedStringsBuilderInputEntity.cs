using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DistributedStringsBuilderInputEntityData))]
	public class DistributedStringsBuilderInputEntity : DistributedStringsBuilderEntity, IEntityData<FrostySdk.Ebx.DistributedStringsBuilderInputEntityData>
	{
		public new FrostySdk.Ebx.DistributedStringsBuilderInputEntityData Data => data as FrostySdk.Ebx.DistributedStringsBuilderInputEntityData;
		public override string DisplayName => "DistributedStringsBuilderInput";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DistributedStringsBuilderInputEntity(FrostySdk.Ebx.DistributedStringsBuilderInputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

