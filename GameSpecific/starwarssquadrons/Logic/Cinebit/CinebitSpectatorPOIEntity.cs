using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinebitSpectatorPOIEntityData))]
	public class CinebitSpectatorPOIEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CinebitSpectatorPOIEntityData>
	{
		public new FrostySdk.Ebx.CinebitSpectatorPOIEntityData Data => data as FrostySdk.Ebx.CinebitSpectatorPOIEntityData;
		public override string DisplayName => "CinebitSpectatorPOI";

		public CinebitSpectatorPOIEntity(FrostySdk.Ebx.CinebitSpectatorPOIEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

