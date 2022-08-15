using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DefaultStarshipKitHelperEntityData))]
	public class DefaultStarshipKitHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DefaultStarshipKitHelperEntityData>
	{
		public new FrostySdk.Ebx.DefaultStarshipKitHelperEntityData Data => data as FrostySdk.Ebx.DefaultStarshipKitHelperEntityData;
		public override string DisplayName => "DefaultStarshipKitHelper";

		public DefaultStarshipKitHelperEntity(FrostySdk.Ebx.DefaultStarshipKitHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

