using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.UnlockToggleEntityData))]
	public class UnlockToggleEntity : LogicEntity, IEntityData<FrostySdk.Ebx.UnlockToggleEntityData>
	{
		public new FrostySdk.Ebx.UnlockToggleEntityData Data => data as FrostySdk.Ebx.UnlockToggleEntityData;
		public override string DisplayName => "UnlockToggle";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public UnlockToggleEntity(FrostySdk.Ebx.UnlockToggleEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

