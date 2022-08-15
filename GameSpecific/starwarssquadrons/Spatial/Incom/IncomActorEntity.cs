using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomActorEntityData))]
	public class IncomActorEntity : ActorEntity, IEntityData<FrostySdk.Ebx.IncomActorEntityData>
	{
		public new FrostySdk.Ebx.IncomActorEntityData Data => data as FrostySdk.Ebx.IncomActorEntityData;
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public IncomActorEntity(FrostySdk.Ebx.IncomActorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

