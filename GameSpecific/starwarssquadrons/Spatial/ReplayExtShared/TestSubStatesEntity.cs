using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TestSubStatesEntityData))]
	public class TestSubStatesEntity : SpatialEntity, IEntityData<FrostySdk.Ebx.TestSubStatesEntityData>
	{
		public new FrostySdk.Ebx.TestSubStatesEntityData Data => data as FrostySdk.Ebx.TestSubStatesEntityData;

		public TestSubStatesEntity(FrostySdk.Ebx.TestSubStatesEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

