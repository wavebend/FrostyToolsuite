using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ForceHiddenStateOnBodyPartsEntityData))]
	public class ForceHiddenStateOnBodyPartsEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ForceHiddenStateOnBodyPartsEntityData>
	{
		public new FrostySdk.Ebx.ForceHiddenStateOnBodyPartsEntityData Data => data as FrostySdk.Ebx.ForceHiddenStateOnBodyPartsEntityData;
		public override string DisplayName => "ForceHiddenStateOnBodyParts";

		public ForceHiddenStateOnBodyPartsEntity(FrostySdk.Ebx.ForceHiddenStateOnBodyPartsEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

