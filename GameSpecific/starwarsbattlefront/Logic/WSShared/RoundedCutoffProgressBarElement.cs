using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RoundedCutoffProgressBarElementData))]
	public class RoundedCutoffProgressBarElement : WSUIBatchableElement, IEntityData<FrostySdk.Ebx.RoundedCutoffProgressBarElementData>
	{
		public new FrostySdk.Ebx.RoundedCutoffProgressBarElementData Data => data as FrostySdk.Ebx.RoundedCutoffProgressBarElementData;
		public override string DisplayName => "RoundedCutoffProgressBarElement";

		public RoundedCutoffProgressBarElement(FrostySdk.Ebx.RoundedCutoffProgressBarElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

