using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.DamageBasedSelectionEntityData))]
	public class DamageBasedSelectionEntity : LogicEntity, IEntityData<FrostySdk.Ebx.DamageBasedSelectionEntityData>
	{
		public new FrostySdk.Ebx.DamageBasedSelectionEntityData Data => data as FrostySdk.Ebx.DamageBasedSelectionEntityData;
		public override string DisplayName => "DamageBasedSelection";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public DamageBasedSelectionEntity(FrostySdk.Ebx.DamageBasedSelectionEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

