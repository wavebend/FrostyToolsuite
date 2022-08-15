using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GameEventsListElementData))]
	public class GameEventsListElement : WSUIElementEntity, IEntityData<FrostySdk.Ebx.GameEventsListElementData>
	{
		public new FrostySdk.Ebx.GameEventsListElementData Data => data as FrostySdk.Ebx.GameEventsListElementData;
		public override string DisplayName => "GameEventsListElement";

		public GameEventsListElement(FrostySdk.Ebx.GameEventsListElementData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

