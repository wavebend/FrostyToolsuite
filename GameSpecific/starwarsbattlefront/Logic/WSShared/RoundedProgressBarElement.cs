using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.RoundedProgressBarElementData))]
	public class RoundedProgressBarElement : WSUIBatchableElement, IEntityData<FrostySdk.Ebx.RoundedProgressBarElementData>
	{
		public new FrostySdk.Ebx.RoundedProgressBarElementData Data => data as FrostySdk.Ebx.RoundedProgressBarElementData;
		public override string DisplayName => "RoundedProgressBarElement";

		public RoundedProgressBarElement(FrostySdk.Ebx.RoundedProgressBarElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

