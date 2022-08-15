using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SelectDesignerEnumerationEntityData))]
	public class SelectDesignerEnumerationEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SelectDesignerEnumerationEntityData>
	{
		public new FrostySdk.Ebx.SelectDesignerEnumerationEntityData Data => data as FrostySdk.Ebx.SelectDesignerEnumerationEntityData;
		public override string DisplayName => "SelectDesignerEnumeration";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SelectDesignerEnumerationEntity(FrostySdk.Ebx.SelectDesignerEnumerationEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

