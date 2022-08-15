using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementMouseAreaEntityData))]
	public class WSUIElementMouseAreaEntity : WSUIElementEntity, IEntityData<FrostySdk.Ebx.WSUIElementMouseAreaEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementMouseAreaEntityData Data => data as FrostySdk.Ebx.WSUIElementMouseAreaEntityData;
		public override string DisplayName => "WSUIElementMouseArea";

		public WSUIElementMouseAreaEntity(FrostySdk.Ebx.WSUIElementMouseAreaEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

