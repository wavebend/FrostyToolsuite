using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.VrSystemEntityData))]
	public class VrSystemEntity : LogicEntity, IEntityData<FrostySdk.Ebx.VrSystemEntityData>
	{
		public new FrostySdk.Ebx.VrSystemEntityData Data => data as FrostySdk.Ebx.VrSystemEntityData;
		public override string DisplayName => "VrSystem";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public VrSystemEntity(FrostySdk.Ebx.VrSystemEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

