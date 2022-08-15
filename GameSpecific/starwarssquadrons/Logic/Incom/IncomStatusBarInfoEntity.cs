using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomStatusBarInfoEntityData))]
	public class IncomStatusBarInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomStatusBarInfoEntityData>
	{
		public new FrostySdk.Ebx.IncomStatusBarInfoEntityData Data => data as FrostySdk.Ebx.IncomStatusBarInfoEntityData;
		public override string DisplayName => "IncomStatusBarInfo";

		public IncomStatusBarInfoEntity(FrostySdk.Ebx.IncomStatusBarInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

