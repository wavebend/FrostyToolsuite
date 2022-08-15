using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineMapElementData))]
	public class FrontlineMapElement : WSUIElementEntity, IEntityData<FrostySdk.Ebx.FrontlineMapElementData>
	{
		public new FrostySdk.Ebx.FrontlineMapElementData Data => data as FrostySdk.Ebx.FrontlineMapElementData;
		public override string DisplayName => "FrontlineMapElement";

		public FrontlineMapElement(FrostySdk.Ebx.FrontlineMapElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

