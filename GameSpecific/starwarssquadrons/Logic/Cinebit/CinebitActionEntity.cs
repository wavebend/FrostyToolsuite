using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinebitActionEntityData))]
	public class CinebitActionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CinebitActionEntityData>
	{
		public new FrostySdk.Ebx.CinebitActionEntityData Data => data as FrostySdk.Ebx.CinebitActionEntityData;
		public override string DisplayName => "CinebitAction";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CinebitActionEntity(FrostySdk.Ebx.CinebitActionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

