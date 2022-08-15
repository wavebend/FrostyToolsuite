using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomizeForceCardEntityData))]
	public class CustomizeForceCardEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomizeForceCardEntityData>
	{
		public new FrostySdk.Ebx.CustomizeForceCardEntityData Data => data as FrostySdk.Ebx.CustomizeForceCardEntityData;
		public override string DisplayName => "CustomizeForceCard";

		public CustomizeForceCardEntity(FrostySdk.Ebx.CustomizeForceCardEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

