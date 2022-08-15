using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CompareUIntEntityData))]
	public class CompareUIntEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CompareUIntEntityData>
	{
		public new FrostySdk.Ebx.CompareUIntEntityData Data => data as FrostySdk.Ebx.CompareUIntEntityData;
		public override string DisplayName => "CompareUInt";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CompareUIntEntity(FrostySdk.Ebx.CompareUIntEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

