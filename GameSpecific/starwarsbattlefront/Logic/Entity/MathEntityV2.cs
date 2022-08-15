using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MathEntityV2Data))]
	public class MathEntityV2 : LogicEntity, IEntityData<FrostySdk.Ebx.MathEntityV2Data>
	{
		public new FrostySdk.Ebx.MathEntityV2Data Data => data as FrostySdk.Ebx.MathEntityV2Data;
		public override string DisplayName => "MathEntityV2";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public MathEntityV2(FrostySdk.Ebx.MathEntityV2Data inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

