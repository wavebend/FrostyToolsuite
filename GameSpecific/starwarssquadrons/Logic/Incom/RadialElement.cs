using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RadialElementData))]
	public class RadialElement : WSUIElementEntity, IEntityData<FrostySdk.Ebx.RadialElementData>
	{
		public new FrostySdk.Ebx.RadialElementData Data => data as FrostySdk.Ebx.RadialElementData;
		public override string DisplayName => "RadialElement";

		public RadialElement(FrostySdk.Ebx.RadialElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

