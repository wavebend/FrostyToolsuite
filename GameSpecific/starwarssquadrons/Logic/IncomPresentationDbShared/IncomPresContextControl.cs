using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomPresContextControlData))]
	public class IncomPresContextControl : LogicEntity, IEntityData<FrostySdk.Ebx.IncomPresContextControlData>
	{
		public new FrostySdk.Ebx.IncomPresContextControlData Data => data as FrostySdk.Ebx.IncomPresContextControlData;
		public override string DisplayName => "IncomPresContextControl";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomPresContextControl(FrostySdk.Ebx.IncomPresContextControlData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

