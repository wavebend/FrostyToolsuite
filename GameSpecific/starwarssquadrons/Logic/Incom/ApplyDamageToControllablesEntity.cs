using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ApplyDamageToControllablesEntityData))]
	public class ApplyDamageToControllablesEntity : LogicEntity, IEntityData<FrostySdk.Ebx.ApplyDamageToControllablesEntityData>
	{
		public new FrostySdk.Ebx.ApplyDamageToControllablesEntityData Data => data as FrostySdk.Ebx.ApplyDamageToControllablesEntityData;
		public override string DisplayName => "ApplyDamageToControllables";

		public ApplyDamageToControllablesEntity(FrostySdk.Ebx.ApplyDamageToControllablesEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

