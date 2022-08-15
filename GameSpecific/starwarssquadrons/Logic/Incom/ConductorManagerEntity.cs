using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ConductorManagerEntityData))]
	public class ConductorManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ConductorManagerEntityData>
	{
		public new FrostySdk.Ebx.ConductorManagerEntityData Data => data as FrostySdk.Ebx.ConductorManagerEntityData;
		public override string DisplayName => "ConductorManager";

		public ConductorManagerEntity(FrostySdk.Ebx.ConductorManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

