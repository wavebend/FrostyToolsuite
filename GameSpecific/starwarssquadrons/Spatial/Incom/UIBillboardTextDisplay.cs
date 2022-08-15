using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UIBillboardTextDisplayData))]
	public class UIBillboardTextDisplay : SpatialEntity, IEntityData<FrostySdk.Ebx.UIBillboardTextDisplayData>
	{
		public new FrostySdk.Ebx.UIBillboardTextDisplayData Data => data as FrostySdk.Ebx.UIBillboardTextDisplayData;

		public UIBillboardTextDisplay(FrostySdk.Ebx.UIBillboardTextDisplayData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

