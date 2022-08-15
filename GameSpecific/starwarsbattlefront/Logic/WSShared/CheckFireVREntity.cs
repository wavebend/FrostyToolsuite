using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CheckFireVREntityData))]
	public class CheckFireVREntity : LogicEntity, IEntityData<FrostySdk.Ebx.CheckFireVREntityData>
	{
		public new FrostySdk.Ebx.CheckFireVREntityData Data => data as FrostySdk.Ebx.CheckFireVREntityData;
		public override string DisplayName => "CheckFireVR";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CheckFireVREntity(FrostySdk.Ebx.CheckFireVREntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

