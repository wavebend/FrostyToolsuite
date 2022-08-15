using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.PrivateMatchEntityData))]
	public class PrivateMatchEntity : LogicEntity, IEntityData<FrostySdk.Ebx.PrivateMatchEntityData>
	{
		public new FrostySdk.Ebx.PrivateMatchEntityData Data => data as FrostySdk.Ebx.PrivateMatchEntityData;
		public override string DisplayName => "PrivateMatch";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public PrivateMatchEntity(FrostySdk.Ebx.PrivateMatchEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

