using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomGameControllerEntityData))]
	public class IncomGameControllerEntity : BaseControllerEntity, IEntityData<FrostySdk.Ebx.IncomGameControllerEntityData>
	{
		public new FrostySdk.Ebx.IncomGameControllerEntityData Data => data as FrostySdk.Ebx.IncomGameControllerEntityData;
		public override string DisplayName => "IncomGameController";

		public IncomGameControllerEntity(FrostySdk.Ebx.IncomGameControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

