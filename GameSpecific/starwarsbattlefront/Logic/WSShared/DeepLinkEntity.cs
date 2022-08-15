using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DeepLinkEntityData))]
	public class DeepLinkEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DeepLinkEntityData>
	{
		public new FrostySdk.Ebx.DeepLinkEntityData Data => data as FrostySdk.Ebx.DeepLinkEntityData;
		public override string DisplayName => "DeepLink";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DeepLinkEntity(FrostySdk.Ebx.DeepLinkEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

