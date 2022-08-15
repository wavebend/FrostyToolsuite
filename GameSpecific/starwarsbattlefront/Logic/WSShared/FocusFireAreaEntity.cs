using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FocusFireAreaEntityData))]
	public class FocusFireAreaEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FocusFireAreaEntityData>
	{
		public new FrostySdk.Ebx.FocusFireAreaEntityData Data => data as FrostySdk.Ebx.FocusFireAreaEntityData;
		public override string DisplayName => "FocusFireArea";

		public FocusFireAreaEntity(FrostySdk.Ebx.FocusFireAreaEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

