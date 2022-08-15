using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HeadBodyComboVerifierEntityData))]
	public class HeadBodyComboVerifierEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HeadBodyComboVerifierEntityData>
	{
		public new FrostySdk.Ebx.HeadBodyComboVerifierEntityData Data => data as FrostySdk.Ebx.HeadBodyComboVerifierEntityData;
		public override string DisplayName => "HeadBodyComboVerifier";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public HeadBodyComboVerifierEntity(FrostySdk.Ebx.HeadBodyComboVerifierEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

