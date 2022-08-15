using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineMapStatusOutputEntityData))]
	public class FrontlineMapStatusOutputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FrontlineMapStatusOutputEntityData>
	{
		public new FrostySdk.Ebx.FrontlineMapStatusOutputEntityData Data => data as FrostySdk.Ebx.FrontlineMapStatusOutputEntityData;
		public override string DisplayName => "FrontlineMapStatusOutput";

		public FrontlineMapStatusOutputEntity(FrostySdk.Ebx.FrontlineMapStatusOutputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

