using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GetSquadmateCommMessageMetaDataData))]
	public class GetSquadmateCommMessageMetaData : LogicEntity, IEntityData<FrostySdk.Ebx.GetSquadmateCommMessageMetaDataData>
	{
		public new FrostySdk.Ebx.GetSquadmateCommMessageMetaDataData Data => data as FrostySdk.Ebx.GetSquadmateCommMessageMetaDataData;
		public override string DisplayName => "GetSquadmateCommMessageMetaData";

		public GetSquadmateCommMessageMetaData(FrostySdk.Ebx.GetSquadmateCommMessageMetaDataData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

