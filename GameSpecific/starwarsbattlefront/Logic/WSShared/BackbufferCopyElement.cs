using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.BackbufferCopyElementData))]
	public class BackbufferCopyElement : WSUISoloBatchableElement, IEntityData<FrostySdk.Ebx.BackbufferCopyElementData>
	{
		public new FrostySdk.Ebx.BackbufferCopyElementData Data => data as FrostySdk.Ebx.BackbufferCopyElementData;
		public override string DisplayName => "BackbufferCopyElement";

		public BackbufferCopyElement(FrostySdk.Ebx.BackbufferCopyElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

