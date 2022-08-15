using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.Vec4BuilderFromVec3EntityData))]
	public class Vec4BuilderFromVec3Entity : LogicEntity, IEntityData<FrostySdk.Ebx.Vec4BuilderFromVec3EntityData>
	{
		public new FrostySdk.Ebx.Vec4BuilderFromVec3EntityData Data => data as FrostySdk.Ebx.Vec4BuilderFromVec3EntityData;
		public override string DisplayName => "Vec4BuilderFromVec3";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public Vec4BuilderFromVec3Entity(FrostySdk.Ebx.Vec4BuilderFromVec3EntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

