using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.TractorBeamFXHelperEntityData))]
	public class TractorBeamFXHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.TractorBeamFXHelperEntityData>
	{
		public new FrostySdk.Ebx.TractorBeamFXHelperEntityData Data => data as FrostySdk.Ebx.TractorBeamFXHelperEntityData;
		public override string DisplayName => "TractorBeamFXHelper";

		public TractorBeamFXHelperEntity(FrostySdk.Ebx.TractorBeamFXHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

