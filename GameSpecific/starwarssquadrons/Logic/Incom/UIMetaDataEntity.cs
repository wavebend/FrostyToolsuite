using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIMetaDataEntityData))]
	public class UIMetaDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UIMetaDataEntityData>
	{
		public new FrostySdk.Ebx.UIMetaDataEntityData Data => data as FrostySdk.Ebx.UIMetaDataEntityData;
		public override string DisplayName => "UIMetaData";

		public UIMetaDataEntity(FrostySdk.Ebx.UIMetaDataEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

