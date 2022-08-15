using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SoldierBlueprintSpawnEntityData))]
	public class SoldierBlueprintSpawnEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SoldierBlueprintSpawnEntityData>
	{
		public new FrostySdk.Ebx.SoldierBlueprintSpawnEntityData Data => data as FrostySdk.Ebx.SoldierBlueprintSpawnEntityData;
		public override string DisplayName => "SoldierBlueprintSpawn";

		public SoldierBlueprintSpawnEntity(FrostySdk.Ebx.SoldierBlueprintSpawnEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

