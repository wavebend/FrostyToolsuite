using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomPlayVOLineEntityData))]
	public class IncomPlayVOLineEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomPlayVOLineEntityData>
	{
		public new FrostySdk.Ebx.IncomPlayVOLineEntityData Data => data as FrostySdk.Ebx.IncomPlayVOLineEntityData;
		public override string DisplayName => "IncomPlayVOLine";

		public IncomPlayVOLineEntity(FrostySdk.Ebx.IncomPlayVOLineEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

