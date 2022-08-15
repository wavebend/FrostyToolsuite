using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomStarshipAreaAffectorEntityData))]
	public class IncomStarshipAreaAffectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomStarshipAreaAffectorEntityData>
	{
		public new FrostySdk.Ebx.IncomStarshipAreaAffectorEntityData Data => data as FrostySdk.Ebx.IncomStarshipAreaAffectorEntityData;
		public override string DisplayName => "IncomStarshipAreaAffector";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomStarshipAreaAffectorEntity(FrostySdk.Ebx.IncomStarshipAreaAffectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

