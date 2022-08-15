using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomLocatorComponentToSpatialEntityData))]
	public class IncomLocatorComponentToSpatialEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.IncomLocatorComponentToSpatialEntityData>
	{
		public new FrostySdk.Ebx.IncomLocatorComponentToSpatialEntityData Data => data as FrostySdk.Ebx.IncomLocatorComponentToSpatialEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomLocatorComponentToSpatialEntity(FrostySdk.Ebx.IncomLocatorComponentToSpatialEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

