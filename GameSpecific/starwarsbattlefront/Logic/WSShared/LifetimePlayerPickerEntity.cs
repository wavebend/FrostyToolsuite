using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.LifetimePlayerPickerEntityData))]
	public class LifetimePlayerPickerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.LifetimePlayerPickerEntityData>
	{
		public new FrostySdk.Ebx.LifetimePlayerPickerEntityData Data => data as FrostySdk.Ebx.LifetimePlayerPickerEntityData;
		public override string DisplayName => "LifetimePlayerPicker";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public LifetimePlayerPickerEntity(FrostySdk.Ebx.LifetimePlayerPickerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

