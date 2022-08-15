using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ConductorNodeEntityData))]
	public class ConductorNodeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ConductorNodeEntityData>
	{
		public new FrostySdk.Ebx.ConductorNodeEntityData Data => data as FrostySdk.Ebx.ConductorNodeEntityData;
		public override string DisplayName => "ConductorNode";

		public ConductorNodeEntity(FrostySdk.Ebx.ConductorNodeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

