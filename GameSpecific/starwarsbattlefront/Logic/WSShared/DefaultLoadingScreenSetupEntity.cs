using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DefaultLoadingScreenSetupEntityData))]
	public class DefaultLoadingScreenSetupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DefaultLoadingScreenSetupEntityData>
	{
		public new FrostySdk.Ebx.DefaultLoadingScreenSetupEntityData Data => data as FrostySdk.Ebx.DefaultLoadingScreenSetupEntityData;
		public override string DisplayName => "DefaultLoadingScreenSetup";

		public DefaultLoadingScreenSetupEntity(FrostySdk.Ebx.DefaultLoadingScreenSetupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

