using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CockpitLocatorEntityData))]
	public class CockpitLocatorEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.CockpitLocatorEntityData>
	{
		public new FrostySdk.Ebx.CockpitLocatorEntityData Data => data as FrostySdk.Ebx.CockpitLocatorEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CockpitLocatorEntity(FrostySdk.Ebx.CockpitLocatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

