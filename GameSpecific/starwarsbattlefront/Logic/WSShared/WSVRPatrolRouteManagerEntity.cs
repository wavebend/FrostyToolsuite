using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSVRPatrolRouteManagerEntityData))]
	public class WSVRPatrolRouteManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.WSVRPatrolRouteManagerEntityData>
	{
		public new FrostySdk.Ebx.WSVRPatrolRouteManagerEntityData Data => data as FrostySdk.Ebx.WSVRPatrolRouteManagerEntityData;
		public override string DisplayName => "WSVRPatrolRouteManager";

		public WSVRPatrolRouteManagerEntity(FrostySdk.Ebx.WSVRPatrolRouteManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

