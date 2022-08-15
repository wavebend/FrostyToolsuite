using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomCinebitOutputEntityData))]
	public class IncomCinebitOutputEntity : CinebitOutputEntity, IEntityData<FrostySdk.Ebx.IncomCinebitOutputEntityData>
	{
		public new FrostySdk.Ebx.IncomCinebitOutputEntityData Data => data as FrostySdk.Ebx.IncomCinebitOutputEntityData;
		public override string DisplayName => "IncomCinebitOutput";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomCinebitOutputEntity(FrostySdk.Ebx.IncomCinebitOutputEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

