using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomPlayerProfileDataEntityData))]
	public class IncomPlayerProfileDataEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomPlayerProfileDataEntityData>
	{
		public new FrostySdk.Ebx.IncomPlayerProfileDataEntityData Data => data as FrostySdk.Ebx.IncomPlayerProfileDataEntityData;
		public override string DisplayName => "IncomPlayerProfileData";

		public IncomPlayerProfileDataEntity(FrostySdk.Ebx.IncomPlayerProfileDataEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

