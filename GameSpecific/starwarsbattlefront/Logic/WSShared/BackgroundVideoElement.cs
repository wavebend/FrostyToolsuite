using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BackgroundVideoElementData))]
	public class BackgroundVideoElement : WSUISoloBatchableElement, IEntityData<FrostySdk.Ebx.BackgroundVideoElementData>
	{
		public new FrostySdk.Ebx.BackgroundVideoElementData Data => data as FrostySdk.Ebx.BackgroundVideoElementData;
		public override string DisplayName => "BackgroundVideoElement";

		public BackgroundVideoElement(FrostySdk.Ebx.BackgroundVideoElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

