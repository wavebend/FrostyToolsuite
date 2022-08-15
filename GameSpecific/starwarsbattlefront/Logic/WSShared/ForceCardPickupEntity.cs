using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceCardPickupEntityData))]
	public class ForceCardPickupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ForceCardPickupEntityData>
	{
		public new FrostySdk.Ebx.ForceCardPickupEntityData Data => data as FrostySdk.Ebx.ForceCardPickupEntityData;
		public override string DisplayName => "ForceCardPickup";

		public ForceCardPickupEntity(FrostySdk.Ebx.ForceCardPickupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

