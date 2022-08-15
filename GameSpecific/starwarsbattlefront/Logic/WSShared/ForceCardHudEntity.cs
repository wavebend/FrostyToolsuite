using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceCardHudEntityData))]
	public class ForceCardHudEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ForceCardHudEntityData>
	{
		public new FrostySdk.Ebx.ForceCardHudEntityData Data => data as FrostySdk.Ebx.ForceCardHudEntityData;
		public override string DisplayName => "ForceCardHud";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ForceCardHudEntity(FrostySdk.Ebx.ForceCardHudEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

