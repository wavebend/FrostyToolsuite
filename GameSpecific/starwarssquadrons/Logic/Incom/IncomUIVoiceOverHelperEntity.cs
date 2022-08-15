using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomUIVoiceOverHelperEntityData))]
	public class IncomUIVoiceOverHelperEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomUIVoiceOverHelperEntityData>
	{
		public new FrostySdk.Ebx.IncomUIVoiceOverHelperEntityData Data => data as FrostySdk.Ebx.IncomUIVoiceOverHelperEntityData;
		public override string DisplayName => "IncomUIVoiceOverHelper";

		public IncomUIVoiceOverHelperEntity(FrostySdk.Ebx.IncomUIVoiceOverHelperEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

