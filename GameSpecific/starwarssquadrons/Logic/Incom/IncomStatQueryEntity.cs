using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomStatQueryEntityData))]
	public class IncomStatQueryEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomStatQueryEntityData>
	{
		public new FrostySdk.Ebx.IncomStatQueryEntityData Data => data as FrostySdk.Ebx.IncomStatQueryEntityData;
		public override string DisplayName => "IncomStatQuery";

		public IncomStatQueryEntity(FrostySdk.Ebx.IncomStatQueryEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

