using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.ActorEntityData))]
	public class ActorEntity : GamePhysicsEntity, IEntityData<FrostySdk.Ebx.ActorEntityData>
	{
		public new FrostySdk.Ebx.ActorEntityData Data => data as FrostySdk.Ebx.ActorEntityData;

		public ActorEntity(FrostySdk.Ebx.ActorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

