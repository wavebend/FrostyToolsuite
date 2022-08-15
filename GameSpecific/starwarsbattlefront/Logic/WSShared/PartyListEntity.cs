using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PartyListEntityData))]
	public class PartyListEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PartyListEntityData>
	{
		public new FrostySdk.Ebx.PartyListEntityData Data => data as FrostySdk.Ebx.PartyListEntityData;
		public override string DisplayName => "PartyList";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PartyListEntity(FrostySdk.Ebx.PartyListEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

