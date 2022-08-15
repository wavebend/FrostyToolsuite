using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomSPGameControllerEntityData))]
	public class IncomSPGameControllerEntity : BaseControllerEntity, IEntityData<FrostySdk.Ebx.IncomSPGameControllerEntityData>
	{
		public new FrostySdk.Ebx.IncomSPGameControllerEntityData Data => data as FrostySdk.Ebx.IncomSPGameControllerEntityData;
		public override string DisplayName => "IncomSPGameController";

		public IncomSPGameControllerEntity(FrostySdk.Ebx.IncomSPGameControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

