using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.OpenVrButtonInputEntityData))]
	public class OpenVrButtonInputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.OpenVrButtonInputEntityData>
	{
		public new FrostySdk.Ebx.OpenVrButtonInputEntityData Data => data as FrostySdk.Ebx.OpenVrButtonInputEntityData;
		public override string DisplayName => "OpenVrButtonInput";

		public OpenVrButtonInputEntity(FrostySdk.Ebx.OpenVrButtonInputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

