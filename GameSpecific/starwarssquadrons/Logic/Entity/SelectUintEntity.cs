using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.SelectUintEntityData))]
	public class SelectUintEntity : SelectPropertyEntity, IEntityData<FrostySdk.Ebx.SelectUintEntityData>
	{
		public new FrostySdk.Ebx.SelectUintEntityData Data => data as FrostySdk.Ebx.SelectUintEntityData;
		public override string DisplayName => "SelectUint";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public SelectUintEntity(FrostySdk.Ebx.SelectUintEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

