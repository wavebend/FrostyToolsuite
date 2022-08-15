using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FlareEntityData))]
	public class FlareEntity : GrenadeEntity, IEntityData<FrostySdk.Ebx.FlareEntityData>
	{
		public new FrostySdk.Ebx.FlareEntityData Data => data as FrostySdk.Ebx.FlareEntityData;

		public FlareEntity(FrostySdk.Ebx.FlareEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

