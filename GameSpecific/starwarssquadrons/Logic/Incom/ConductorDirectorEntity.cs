using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ConductorDirectorEntityData))]
	public class ConductorDirectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ConductorDirectorEntityData>
	{
		public new FrostySdk.Ebx.ConductorDirectorEntityData Data => data as FrostySdk.Ebx.ConductorDirectorEntityData;
		public override string DisplayName => "ConductorDirector";

		public ConductorDirectorEntity(FrostySdk.Ebx.ConductorDirectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

