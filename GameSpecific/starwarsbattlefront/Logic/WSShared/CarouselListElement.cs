using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CarouselListElementData))]
	public class CarouselListElement : ListElement, IEntityData<FrostySdk.Ebx.CarouselListElementData>
	{
		public new FrostySdk.Ebx.CarouselListElementData Data => data as FrostySdk.Ebx.CarouselListElementData;
		public override string DisplayName => "CarouselListElement";

		public CarouselListElement(FrostySdk.Ebx.CarouselListElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

