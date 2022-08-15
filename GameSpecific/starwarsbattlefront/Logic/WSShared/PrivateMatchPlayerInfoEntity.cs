using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PrivateMatchPlayerInfoEntityData))]
	public class PrivateMatchPlayerInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PrivateMatchPlayerInfoEntityData>
	{
		public new FrostySdk.Ebx.PrivateMatchPlayerInfoEntityData Data => data as FrostySdk.Ebx.PrivateMatchPlayerInfoEntityData;
		public override string DisplayName => "PrivateMatchPlayerInfo";

		public PrivateMatchPlayerInfoEntity(FrostySdk.Ebx.PrivateMatchPlayerInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

