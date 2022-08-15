using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.HubListElementData))]
	public class HubListElement : ListElement, IEntityData<FrostySdk.Ebx.HubListElementData>
	{
		public new FrostySdk.Ebx.HubListElementData Data => data as FrostySdk.Ebx.HubListElementData;
		public override string DisplayName => "HubListElement";

		public HubListElement(FrostySdk.Ebx.HubListElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

