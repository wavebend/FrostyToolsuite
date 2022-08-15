using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EndOfRoundMedalsEntityData))]
	public class EndOfRoundMedalsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EndOfRoundMedalsEntityData>
	{
		public new FrostySdk.Ebx.EndOfRoundMedalsEntityData Data => data as FrostySdk.Ebx.EndOfRoundMedalsEntityData;
		public override string DisplayName => "EndOfRoundMedals";

		public EndOfRoundMedalsEntity(FrostySdk.Ebx.EndOfRoundMedalsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

