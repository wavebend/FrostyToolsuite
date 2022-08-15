using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UintChangedEntityData))]
	public class UintChangedEntity : PropertyChangedEntity, IEntityData<FrostySdk.Ebx.UintChangedEntityData>
	{
		public new FrostySdk.Ebx.UintChangedEntityData Data => data as FrostySdk.Ebx.UintChangedEntityData;
		public override string DisplayName => "UintChanged";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UintChangedEntity(FrostySdk.Ebx.UintChangedEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

