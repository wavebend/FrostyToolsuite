using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TourControllerEntityData))]
	public class TourControllerEntity : ReferenceObject, IEntityData<FrostySdk.Ebx.TourControllerEntityData>
	{
		public new FrostySdk.Ebx.TourControllerEntityData Data => data as FrostySdk.Ebx.TourControllerEntityData;

		public TourControllerEntity(FrostySdk.Ebx.TourControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

