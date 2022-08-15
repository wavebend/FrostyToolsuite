using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomStarshipDataOwnerLinkEntityData))]
	public class IncomStarshipDataOwnerLinkEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomStarshipDataOwnerLinkEntityData>
	{
		public new FrostySdk.Ebx.IncomStarshipDataOwnerLinkEntityData Data => data as FrostySdk.Ebx.IncomStarshipDataOwnerLinkEntityData;
		public override string DisplayName => "IncomStarshipDataOwnerLink";

		public IncomStarshipDataOwnerLinkEntity(FrostySdk.Ebx.IncomStarshipDataOwnerLinkEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

