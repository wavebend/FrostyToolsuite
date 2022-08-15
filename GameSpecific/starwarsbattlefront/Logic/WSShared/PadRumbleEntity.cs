using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PadRumbleEntityData))]
	public class PadRumbleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PadRumbleEntityData>
	{
		public new FrostySdk.Ebx.PadRumbleEntityData Data => data as FrostySdk.Ebx.PadRumbleEntityData;
		public override string DisplayName => "PadRumble";

		public PadRumbleEntity(FrostySdk.Ebx.PadRumbleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

