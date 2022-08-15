using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WeaponBoneLocatorEntityData))]
	public class WeaponBoneLocatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WeaponBoneLocatorEntityData>
	{
		public new FrostySdk.Ebx.WeaponBoneLocatorEntityData Data => data as FrostySdk.Ebx.WeaponBoneLocatorEntityData;
		public override string DisplayName => "WeaponBoneLocator";

		public WeaponBoneLocatorEntity(FrostySdk.Ebx.WeaponBoneLocatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

