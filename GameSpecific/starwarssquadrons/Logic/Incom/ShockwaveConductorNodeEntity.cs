using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ShockwaveConductorNodeEntityData))]
	public class ShockwaveConductorNodeEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ShockwaveConductorNodeEntityData>
	{
		public new FrostySdk.Ebx.ShockwaveConductorNodeEntityData Data => data as FrostySdk.Ebx.ShockwaveConductorNodeEntityData;
		public override string DisplayName => "ShockwaveConductorNode";

		public ShockwaveConductorNodeEntity(FrostySdk.Ebx.ShockwaveConductorNodeEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

