using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinebitInputHandlerEntityData))]
	public class CinebitInputHandlerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CinebitInputHandlerEntityData>
	{
		public new FrostySdk.Ebx.CinebitInputHandlerEntityData Data => data as FrostySdk.Ebx.CinebitInputHandlerEntityData;
		public override string DisplayName => "CinebitInputHandler";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CinebitInputHandlerEntity(FrostySdk.Ebx.CinebitInputHandlerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

