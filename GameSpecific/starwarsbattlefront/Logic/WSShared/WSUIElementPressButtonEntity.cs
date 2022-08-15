using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSUIElementPressButtonEntityData))]
	public class WSUIElementPressButtonEntity : WSUIElementEntity, IEntityData<FrostySdk.Ebx.WSUIElementPressButtonEntityData>
	{
		public new FrostySdk.Ebx.WSUIElementPressButtonEntityData Data => data as FrostySdk.Ebx.WSUIElementPressButtonEntityData;
		public override string DisplayName => "WSUIElementPressButton";

		public WSUIElementPressButtonEntity(FrostySdk.Ebx.WSUIElementPressButtonEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

