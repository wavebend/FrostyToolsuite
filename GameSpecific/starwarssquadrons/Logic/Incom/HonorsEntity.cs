using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HonorsEntityData))]
	public class HonorsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HonorsEntityData>
	{
		public new FrostySdk.Ebx.HonorsEntityData Data => data as FrostySdk.Ebx.HonorsEntityData;
		public override string DisplayName => "Honors";

		public HonorsEntity(FrostySdk.Ebx.HonorsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

