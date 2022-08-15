using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomPresContextRegistrarData))]
	public class IncomPresContextRegistrar : LogicEntity, IEntityData<FrostySdk.Ebx.IncomPresContextRegistrarData>
	{
		public new FrostySdk.Ebx.IncomPresContextRegistrarData Data => data as FrostySdk.Ebx.IncomPresContextRegistrarData;
		public override string DisplayName => "IncomPresContextRegistrar";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomPresContextRegistrar(FrostySdk.Ebx.IncomPresContextRegistrarData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

