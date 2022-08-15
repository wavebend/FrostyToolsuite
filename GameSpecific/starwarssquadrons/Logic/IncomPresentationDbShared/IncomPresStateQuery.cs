using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomPresStateQueryData))]
	public class IncomPresStateQuery : LogicEntity, IEntityData<FrostySdk.Ebx.IncomPresStateQueryData>
	{
		public new FrostySdk.Ebx.IncomPresStateQueryData Data => data as FrostySdk.Ebx.IncomPresStateQueryData;
		public override string DisplayName => "IncomPresStateQuery";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomPresStateQuery(FrostySdk.Ebx.IncomPresStateQueryData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

