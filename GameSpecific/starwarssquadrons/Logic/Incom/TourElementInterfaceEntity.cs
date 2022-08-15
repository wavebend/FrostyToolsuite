using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TourElementInterfaceEntityData))]
	public class TourElementInterfaceEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TourElementInterfaceEntityData>
	{
		public new FrostySdk.Ebx.TourElementInterfaceEntityData Data => data as FrostySdk.Ebx.TourElementInterfaceEntityData;
		public override string DisplayName => "TourElementInterface";

		public TourElementInterfaceEntity(FrostySdk.Ebx.TourElementInterfaceEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

