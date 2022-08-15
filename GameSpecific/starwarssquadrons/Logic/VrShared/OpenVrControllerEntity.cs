using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.OpenVrControllerEntityData))]
	public class OpenVrControllerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.OpenVrControllerEntityData>
	{
		public new FrostySdk.Ebx.OpenVrControllerEntityData Data => data as FrostySdk.Ebx.OpenVrControllerEntityData;
		public override string DisplayName => "OpenVrController";

		public OpenVrControllerEntity(FrostySdk.Ebx.OpenVrControllerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

