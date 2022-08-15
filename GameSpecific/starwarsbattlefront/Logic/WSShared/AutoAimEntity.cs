using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AutoAimEntityData))]
	public class AutoAimEntity : LogicEntity, IEntityData<FrostySdk.Ebx.AutoAimEntityData>
	{
		public new FrostySdk.Ebx.AutoAimEntityData Data => data as FrostySdk.Ebx.AutoAimEntityData;
		public override string DisplayName => "AutoAim";

		public AutoAimEntity(FrostySdk.Ebx.AutoAimEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

