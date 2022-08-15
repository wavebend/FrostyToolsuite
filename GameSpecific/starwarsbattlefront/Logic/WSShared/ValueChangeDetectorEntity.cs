using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ValueChangeDetectorEntityData))]
	public class ValueChangeDetectorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ValueChangeDetectorEntityData>
	{
		public new FrostySdk.Ebx.ValueChangeDetectorEntityData Data => data as FrostySdk.Ebx.ValueChangeDetectorEntityData;
		public override string DisplayName => "ValueChangeDetector";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public ValueChangeDetectorEntity(FrostySdk.Ebx.ValueChangeDetectorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

