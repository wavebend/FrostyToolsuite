using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BaseControllerEntityData))]
	public class BaseControllerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.BaseControllerEntityData>
	{
		public new FrostySdk.Ebx.BaseControllerEntityData Data => data as FrostySdk.Ebx.BaseControllerEntityData;
		public override string DisplayName => "BaseController";

		public BaseControllerEntity(FrostySdk.Ebx.BaseControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

