using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DistributedStringsBuilderEntityData))]
	public class DistributedStringsBuilderEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DistributedStringsBuilderEntityData>
	{
		public new FrostySdk.Ebx.DistributedStringsBuilderEntityData Data => data as FrostySdk.Ebx.DistributedStringsBuilderEntityData;
		public override string DisplayName => "DistributedStringsBuilder";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DistributedStringsBuilderEntity(FrostySdk.Ebx.DistributedStringsBuilderEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

