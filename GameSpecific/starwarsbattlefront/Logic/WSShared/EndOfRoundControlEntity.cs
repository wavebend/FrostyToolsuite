using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EndOfRoundControlEntityData))]
	public class EndOfRoundControlEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EndOfRoundControlEntityData>
	{
		public new FrostySdk.Ebx.EndOfRoundControlEntityData Data => data as FrostySdk.Ebx.EndOfRoundControlEntityData;
		public override string DisplayName => "EndOfRoundControl";

		public EndOfRoundControlEntity(FrostySdk.Ebx.EndOfRoundControlEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

