using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
#if !SWBF
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CallFunctionEntityData))]
	public class CallFunctionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CallFunctionEntityData>
	{
		public new FrostySdk.Ebx.CallFunctionEntityData Data => data as FrostySdk.Ebx.CallFunctionEntityData;
		public override string DisplayName => "CallFunction";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CallFunctionEntity(FrostySdk.Ebx.CallFunctionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
#endif
}

