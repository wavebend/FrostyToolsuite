using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomIsGameViewEntityData))]
	public class IncomIsGameViewEntity : LogicEntity, IEntityData<FrostySdk.Ebx.IncomIsGameViewEntityData>
	{
		public new FrostySdk.Ebx.IncomIsGameViewEntityData Data => data as FrostySdk.Ebx.IncomIsGameViewEntityData;
		public override string DisplayName => "IncomIsGameView";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomIsGameViewEntity(FrostySdk.Ebx.IncomIsGameViewEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

