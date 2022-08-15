using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.KitHelperEntityData))]
	public class KitHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.KitHelperEntityData>
	{
		public new FrostySdk.Ebx.KitHelperEntityData Data => data as FrostySdk.Ebx.KitHelperEntityData;
		public override string DisplayName => "KitHelper";

		public KitHelperEntity(FrostySdk.Ebx.KitHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

