using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FloatToIntEntityData))]
	public class FloatToIntEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FloatToIntEntityData>
	{
		public new FrostySdk.Ebx.FloatToIntEntityData Data => data as FrostySdk.Ebx.FloatToIntEntityData;
		public override string DisplayName => "FloatToInt";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public FloatToIntEntity(FrostySdk.Ebx.FloatToIntEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

