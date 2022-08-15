using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AIPlayerProviderData))]
	public class AIPlayerProvider : LogicEntity, IEntityData<FrostySdk.Ebx.AIPlayerProviderData>
	{
		public new FrostySdk.Ebx.AIPlayerProviderData Data => data as FrostySdk.Ebx.AIPlayerProviderData;
		public override string DisplayName => "AIPlayerProvider";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public AIPlayerProvider(FrostySdk.Ebx.AIPlayerProviderData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

