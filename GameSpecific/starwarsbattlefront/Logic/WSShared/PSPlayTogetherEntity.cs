using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PSPlayTogetherEntityData))]
	public class PSPlayTogetherEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PSPlayTogetherEntityData>
	{
		public new FrostySdk.Ebx.PSPlayTogetherEntityData Data => data as FrostySdk.Ebx.PSPlayTogetherEntityData;
		public override string DisplayName => "PSPlayTogether";

		public PSPlayTogetherEntity(FrostySdk.Ebx.PSPlayTogetherEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

