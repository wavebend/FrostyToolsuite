using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CommSignalEntityData))]
	public class CommSignalEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CommSignalEntityData>
	{
		public new FrostySdk.Ebx.CommSignalEntityData Data => data as FrostySdk.Ebx.CommSignalEntityData;
		public override string DisplayName => "CommSignal";

		public CommSignalEntity(FrostySdk.Ebx.CommSignalEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

