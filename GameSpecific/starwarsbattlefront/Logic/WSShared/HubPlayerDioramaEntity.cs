using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubPlayerDioramaEntityData))]
	public class HubPlayerDioramaEntity : LogicEntity, IEntityData<FrostySdk.Ebx.HubPlayerDioramaEntityData>
	{
		public new FrostySdk.Ebx.HubPlayerDioramaEntityData Data => data as FrostySdk.Ebx.HubPlayerDioramaEntityData;
		public override string DisplayName => "HubPlayerDiorama";

		public HubPlayerDioramaEntity(FrostySdk.Ebx.HubPlayerDioramaEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

