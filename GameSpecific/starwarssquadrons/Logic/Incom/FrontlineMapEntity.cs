using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FrontlineMapEntityData))]
	public class FrontlineMapEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FrontlineMapEntityData>
	{
		public new FrostySdk.Ebx.FrontlineMapEntityData Data => data as FrostySdk.Ebx.FrontlineMapEntityData;
		public override string DisplayName => "FrontlineMap";

		public FrontlineMapEntity(FrostySdk.Ebx.FrontlineMapEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

