using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinebitOutputEntityData))]
	public class CinebitOutputEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CinebitOutputEntityData>
	{
		public new FrostySdk.Ebx.CinebitOutputEntityData Data => data as FrostySdk.Ebx.CinebitOutputEntityData;
		public override string DisplayName => "CinebitOutput";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CinebitOutputEntity(FrostySdk.Ebx.CinebitOutputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

