using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomLevelInfoEntityData))]
	public class IncomLevelInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomLevelInfoEntityData>
	{
		public new FrostySdk.Ebx.IncomLevelInfoEntityData Data => data as FrostySdk.Ebx.IncomLevelInfoEntityData;
		public override string DisplayName => "IncomLevelInfo";

		public IncomLevelInfoEntity(FrostySdk.Ebx.IncomLevelInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

