using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomServerSetupEntityData))]
	public class CustomServerSetupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomServerSetupEntityData>
	{
		public new FrostySdk.Ebx.CustomServerSetupEntityData Data => data as FrostySdk.Ebx.CustomServerSetupEntityData;
		public override string DisplayName => "CustomServerSetup";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CustomServerSetupEntity(FrostySdk.Ebx.CustomServerSetupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

