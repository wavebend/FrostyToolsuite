using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VRSystemEntityData))]
	public class VRSystemEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VRSystemEntityData>
	{
		public new FrostySdk.Ebx.VRSystemEntityData Data => data as FrostySdk.Ebx.VRSystemEntityData;
		public override string DisplayName => "VRSystem";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VRSystemEntity(FrostySdk.Ebx.VRSystemEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

