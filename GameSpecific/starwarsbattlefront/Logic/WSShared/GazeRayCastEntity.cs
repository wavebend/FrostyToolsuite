using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GazeRayCastEntityData))]
	public class GazeRayCastEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GazeRayCastEntityData>
	{
		public new FrostySdk.Ebx.GazeRayCastEntityData Data => data as FrostySdk.Ebx.GazeRayCastEntityData;
		public override string DisplayName => "GazeRayCast";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public GazeRayCastEntity(FrostySdk.Ebx.GazeRayCastEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

