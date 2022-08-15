using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DioramaUnlockLookupEntityData))]
	public class DioramaUnlockLookupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DioramaUnlockLookupEntityData>
	{
		public new FrostySdk.Ebx.DioramaUnlockLookupEntityData Data => data as FrostySdk.Ebx.DioramaUnlockLookupEntityData;
		public override string DisplayName => "DioramaUnlockLookup";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DioramaUnlockLookupEntity(FrostySdk.Ebx.DioramaUnlockLookupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

