using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LocatorCollectionEntityData))]
	public class LocatorCollectionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LocatorCollectionEntityData>
	{
		public new FrostySdk.Ebx.LocatorCollectionEntityData Data => data as FrostySdk.Ebx.LocatorCollectionEntityData;
		public override string DisplayName => "LocatorCollection";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public LocatorCollectionEntity(FrostySdk.Ebx.LocatorCollectionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

