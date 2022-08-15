using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.MaverickProfanityFilterEntityData))]
	public class MaverickProfanityFilterEntity : LogicEntity, IEntityData<FrostySdk.Ebx.MaverickProfanityFilterEntityData>
	{
		public new FrostySdk.Ebx.MaverickProfanityFilterEntityData Data => data as FrostySdk.Ebx.MaverickProfanityFilterEntityData;
		public override string DisplayName => "MaverickProfanityFilter";

		public MaverickProfanityFilterEntity(FrostySdk.Ebx.MaverickProfanityFilterEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

