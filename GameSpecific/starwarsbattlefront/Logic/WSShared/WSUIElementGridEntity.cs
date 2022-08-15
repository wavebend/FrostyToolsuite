using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementGridEntityData))]
	public class WSUIElementGridEntity : WSUIElementEntity, IEntityData<FrostySdk.Ebx.WSUIElementGridEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementGridEntityData Data => data as FrostySdk.Ebx.WSUIElementGridEntityData;
		public override string DisplayName => "WSUIElementGrid";

		public WSUIElementGridEntity(FrostySdk.Ebx.WSUIElementGridEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

