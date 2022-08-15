using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VoiceOverGameStateWriterEntityData))]
	public class VoiceOverGameStateWriterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VoiceOverGameStateWriterEntityData>
	{
		public new FrostySdk.Ebx.VoiceOverGameStateWriterEntityData Data => data as FrostySdk.Ebx.VoiceOverGameStateWriterEntityData;
		public override string DisplayName => "VoiceOverGameStateWriter";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VoiceOverGameStateWriterEntity(FrostySdk.Ebx.VoiceOverGameStateWriterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

