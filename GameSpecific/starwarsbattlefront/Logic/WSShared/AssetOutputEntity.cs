using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AssetOutputEntityData))]
	public class AssetOutputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AssetOutputEntityData>
	{
		public new FrostySdk.Ebx.AssetOutputEntityData Data => data as FrostySdk.Ebx.AssetOutputEntityData;
		public override string DisplayName => "AssetOutput";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AssetOutputEntity(FrostySdk.Ebx.AssetOutputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

