using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomMatchSetupEntityData))]
	public class CustomMatchSetupEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomMatchSetupEntityData>
	{
		public new FrostySdk.Ebx.CustomMatchSetupEntityData Data => data as FrostySdk.Ebx.CustomMatchSetupEntityData;
		public override string DisplayName => "CustomMatchSetup";

		public CustomMatchSetupEntity(FrostySdk.Ebx.CustomMatchSetupEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

