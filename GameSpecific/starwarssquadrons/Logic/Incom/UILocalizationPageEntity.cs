using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UILocalizationPageEntityData))]
	public class UILocalizationPageEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UILocalizationPageEntityData>
	{
		public new FrostySdk.Ebx.UILocalizationPageEntityData Data => data as FrostySdk.Ebx.UILocalizationPageEntityData;
		public override string DisplayName => "UILocalizationPage";

		public UILocalizationPageEntity(FrostySdk.Ebx.UILocalizationPageEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

