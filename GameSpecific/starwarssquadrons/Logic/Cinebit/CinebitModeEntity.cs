using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinebitModeEntityData))]
	public class CinebitModeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CinebitModeEntityData>
	{
		public new FrostySdk.Ebx.CinebitModeEntityData Data => data as FrostySdk.Ebx.CinebitModeEntityData;
		public override string DisplayName => "CinebitMode";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CinebitModeEntity(FrostySdk.Ebx.CinebitModeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

