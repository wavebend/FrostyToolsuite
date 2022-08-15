using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VRBlueprintSpawnerEntityData))]
	public class VRBlueprintSpawnerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VRBlueprintSpawnerEntityData>
	{
		public new FrostySdk.Ebx.VRBlueprintSpawnerEntityData Data => data as FrostySdk.Ebx.VRBlueprintSpawnerEntityData;
		public override string DisplayName => "VRBlueprintSpawner";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VRBlueprintSpawnerEntity(FrostySdk.Ebx.VRBlueprintSpawnerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

