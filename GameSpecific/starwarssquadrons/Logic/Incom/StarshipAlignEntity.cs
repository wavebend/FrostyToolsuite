using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.StarshipAlignEntityData))]
	public class StarshipAlignEntity : LogicEntity, IEntityData<FrostySdk.Ebx.StarshipAlignEntityData>
	{
		public new FrostySdk.Ebx.StarshipAlignEntityData Data => data as FrostySdk.Ebx.StarshipAlignEntityData;
		public override string DisplayName => "StarshipAlign";

		public StarshipAlignEntity(FrostySdk.Ebx.StarshipAlignEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

