using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIMouseWheelControlHelperEntityData))]
	public class IncomUIMouseWheelControlHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIMouseWheelControlHelperEntityData>
	{
		public new FrostySdk.Ebx.IncomUIMouseWheelControlHelperEntityData Data => data as FrostySdk.Ebx.IncomUIMouseWheelControlHelperEntityData;
		public override string DisplayName => "IncomUIMouseWheelControlHelper";

		public IncomUIMouseWheelControlHelperEntity(FrostySdk.Ebx.IncomUIMouseWheelControlHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

