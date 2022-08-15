using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinebitSpectatorPOIListenerEntityData))]
	public class CinebitSpectatorPOIListenerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CinebitSpectatorPOIListenerEntityData>
	{
		public new FrostySdk.Ebx.CinebitSpectatorPOIListenerEntityData Data => data as FrostySdk.Ebx.CinebitSpectatorPOIListenerEntityData;
		public override string DisplayName => "CinebitSpectatorPOIListener";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CinebitSpectatorPOIListenerEntity(FrostySdk.Ebx.CinebitSpectatorPOIListenerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

