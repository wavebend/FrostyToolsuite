using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LookingAtEntityData))]
	public class LookingAtEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LookingAtEntityData>
	{
		public new FrostySdk.Ebx.LookingAtEntityData Data => data as FrostySdk.Ebx.LookingAtEntityData;
		public override string DisplayName => "LookingAt";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public LookingAtEntity(FrostySdk.Ebx.LookingAtEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

