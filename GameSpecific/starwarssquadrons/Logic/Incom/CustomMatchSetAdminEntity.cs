using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomMatchSetAdminEntityData))]
	public class CustomMatchSetAdminEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomMatchSetAdminEntityData>
	{
		public new FrostySdk.Ebx.CustomMatchSetAdminEntityData Data => data as FrostySdk.Ebx.CustomMatchSetAdminEntityData;
		public override string DisplayName => "CustomMatchSetAdmin";

		public CustomMatchSetAdminEntity(FrostySdk.Ebx.CustomMatchSetAdminEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

