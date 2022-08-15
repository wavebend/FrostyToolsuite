using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.FirstPartyWebBrowserEntityData))]
	public class FirstPartyWebBrowserEntity : LogicEntity, IEntityData<FrostySdk.Ebx.FirstPartyWebBrowserEntityData>
	{
		public new FrostySdk.Ebx.FirstPartyWebBrowserEntityData Data => data as FrostySdk.Ebx.FirstPartyWebBrowserEntityData;
		public override string DisplayName => "FirstPartyWebBrowser";

		public FirstPartyWebBrowserEntity(FrostySdk.Ebx.FirstPartyWebBrowserEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

