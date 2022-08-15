using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomPresObjectQueryData))]
	public class IncomPresObjectQuery : LogicEntity, IEntityData<FrostySdk.Ebx.IncomPresObjectQueryData>
	{
		public new FrostySdk.Ebx.IncomPresObjectQueryData Data => data as FrostySdk.Ebx.IncomPresObjectQueryData;
		public override string DisplayName => "IncomPresObjectQuery";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomPresObjectQuery(FrostySdk.Ebx.IncomPresObjectQueryData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

