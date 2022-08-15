using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PilotKitIdEntityData))]
	public class PilotKitIdEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PilotKitIdEntityData>
	{
		public new FrostySdk.Ebx.PilotKitIdEntityData Data => data as FrostySdk.Ebx.PilotKitIdEntityData;
		public override string DisplayName => "PilotKitId";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PilotKitIdEntity(FrostySdk.Ebx.PilotKitIdEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

