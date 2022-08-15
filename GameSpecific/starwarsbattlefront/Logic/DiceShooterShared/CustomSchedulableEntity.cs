using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CustomSchedulableEntityData))]
	public class CustomSchedulableEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CustomSchedulableEntityData>
	{
		public new FrostySdk.Ebx.CustomSchedulableEntityData Data => data as FrostySdk.Ebx.CustomSchedulableEntityData;
		public override string DisplayName => "CustomSchedulable";

		public CustomSchedulableEntity(FrostySdk.Ebx.CustomSchedulableEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

