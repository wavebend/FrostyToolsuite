using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.QueryFireProjectileEntityData))]
	public class QueryFireProjectileEntity : LogicEntity, IEntityData<FrostySdk.Ebx.QueryFireProjectileEntityData>
	{
		public new FrostySdk.Ebx.QueryFireProjectileEntityData Data => data as FrostySdk.Ebx.QueryFireProjectileEntityData;
		public override string DisplayName => "QueryFireProjectile";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public QueryFireProjectileEntity(FrostySdk.Ebx.QueryFireProjectileEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

