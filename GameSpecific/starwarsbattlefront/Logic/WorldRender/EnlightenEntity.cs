using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.EnlightenEntityData))]
	public class EnlightenEntity : LogicEntity, IEntityData<FrostySdk.Ebx.EnlightenEntityData>
	{
		public new FrostySdk.Ebx.EnlightenEntityData Data => data as FrostySdk.Ebx.EnlightenEntityData;
		public override string DisplayName => "Enlighten";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public EnlightenEntity(FrostySdk.Ebx.EnlightenEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

