using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SecondsToDateEntityData))]
	public class SecondsToDateEntity : LogicEntity, IEntityData<FrostySdk.Ebx.SecondsToDateEntityData>
	{
		public new FrostySdk.Ebx.SecondsToDateEntityData Data => data as FrostySdk.Ebx.SecondsToDateEntityData;
		public override string DisplayName => "SecondsToDate";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SecondsToDateEntity(FrostySdk.Ebx.SecondsToDateEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

