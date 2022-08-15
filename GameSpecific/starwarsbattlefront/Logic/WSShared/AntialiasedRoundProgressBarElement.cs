using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.AntialiasedRoundProgressBarElementData))]
	public class AntialiasedRoundProgressBarElement : WSUISoloBatchableElement, IEntityData<FrostySdk.Ebx.AntialiasedRoundProgressBarElementData>
	{
		public new FrostySdk.Ebx.AntialiasedRoundProgressBarElementData Data => data as FrostySdk.Ebx.AntialiasedRoundProgressBarElementData;
		public override string DisplayName => "AntialiasedRoundProgressBarElement";

		public AntialiasedRoundProgressBarElement(FrostySdk.Ebx.AntialiasedRoundProgressBarElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

