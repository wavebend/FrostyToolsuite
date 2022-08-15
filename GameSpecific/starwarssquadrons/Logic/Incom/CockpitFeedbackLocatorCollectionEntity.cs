using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CockpitFeedbackLocatorCollectionEntityData))]
	public class CockpitFeedbackLocatorCollectionEntity : LocatorCollectionEntity, IEntityData<FrostySdk.Ebx.CockpitFeedbackLocatorCollectionEntityData>
	{
		public new FrostySdk.Ebx.CockpitFeedbackLocatorCollectionEntityData Data => data as FrostySdk.Ebx.CockpitFeedbackLocatorCollectionEntityData;
		public override string DisplayName => "CockpitFeedbackLocatorCollection";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CockpitFeedbackLocatorCollectionEntity(FrostySdk.Ebx.CockpitFeedbackLocatorCollectionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

