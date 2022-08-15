using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinebitDebugManagerEntityData))]
	public class CinebitDebugManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CinebitDebugManagerEntityData>
	{
		public new FrostySdk.Ebx.CinebitDebugManagerEntityData Data => data as FrostySdk.Ebx.CinebitDebugManagerEntityData;
		public override string DisplayName => "CinebitDebugManager";

		public CinebitDebugManagerEntity(FrostySdk.Ebx.CinebitDebugManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

