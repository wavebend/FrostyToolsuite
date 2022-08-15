using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomPlayerIngameInfoEntityData))]
	public class IncomPlayerIngameInfoEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomPlayerIngameInfoEntityData>
	{
		public new FrostySdk.Ebx.IncomPlayerIngameInfoEntityData Data => data as FrostySdk.Ebx.IncomPlayerIngameInfoEntityData;
		public override string DisplayName => "IncomPlayerIngameInfo";

		public IncomPlayerIngameInfoEntity(FrostySdk.Ebx.IncomPlayerIngameInfoEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

