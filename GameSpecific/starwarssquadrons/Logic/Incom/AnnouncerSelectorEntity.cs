using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AnnouncerSelectorEntityData))]
	public class AnnouncerSelectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AnnouncerSelectorEntityData>
	{
		public new FrostySdk.Ebx.AnnouncerSelectorEntityData Data => data as FrostySdk.Ebx.AnnouncerSelectorEntityData;
		public override string DisplayName => "AnnouncerSelector";

		public AnnouncerSelectorEntity(FrostySdk.Ebx.AnnouncerSelectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

