using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SequenceData))]
	public class Sequence : SequenceEntity, IEntityData<FrostySdk.Ebx.SequenceData>
	{
		public new FrostySdk.Ebx.SequenceData Data => data as FrostySdk.Ebx.SequenceData;
		public override string DisplayName => "Sequence";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public Sequence(FrostySdk.Ebx.SequenceData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

