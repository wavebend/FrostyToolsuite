using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DefaultPilotKitHelperEntityData))]
	public class DefaultPilotKitHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DefaultPilotKitHelperEntityData>
	{
		public new FrostySdk.Ebx.DefaultPilotKitHelperEntityData Data => data as FrostySdk.Ebx.DefaultPilotKitHelperEntityData;
		public override string DisplayName => "DefaultPilotKitHelper";

		public DefaultPilotKitHelperEntity(FrostySdk.Ebx.DefaultPilotKitHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

