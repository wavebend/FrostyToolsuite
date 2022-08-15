using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UICrosshairEntityData))]
	public class UICrosshairEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UICrosshairEntityData>
	{
		public new FrostySdk.Ebx.UICrosshairEntityData Data => data as FrostySdk.Ebx.UICrosshairEntityData;
		public override string DisplayName => "UICrosshair";

		public UICrosshairEntity(FrostySdk.Ebx.UICrosshairEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

