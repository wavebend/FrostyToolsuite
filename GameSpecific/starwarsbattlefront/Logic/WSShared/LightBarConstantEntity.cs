using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LightBarConstantEntityData))]
	public class LightBarConstantEntity : LightBarEntity, IEntityData<FrostySdk.Ebx.LightBarConstantEntityData>
	{
		public new FrostySdk.Ebx.LightBarConstantEntityData Data => data as FrostySdk.Ebx.LightBarConstantEntityData;
		public override string DisplayName => "LightBarConstant";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public LightBarConstantEntity(FrostySdk.Ebx.LightBarConstantEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

