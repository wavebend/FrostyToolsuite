using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UintHubEntityData))]
	public class UintHubEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UintHubEntityData>
	{
		public new FrostySdk.Ebx.UintHubEntityData Data => data as FrostySdk.Ebx.UintHubEntityData;
		public override string DisplayName => "UintHub";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UintHubEntity(FrostySdk.Ebx.UintHubEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

