using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UnlockFilterEntityData))]
	public class UnlockFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UnlockFilterEntityData>
	{
		public new FrostySdk.Ebx.UnlockFilterEntityData Data => data as FrostySdk.Ebx.UnlockFilterEntityData;
		public override string DisplayName => "UnlockFilter";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UnlockFilterEntity(FrostySdk.Ebx.UnlockFilterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

