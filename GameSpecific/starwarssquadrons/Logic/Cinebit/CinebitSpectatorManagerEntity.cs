using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinebitSpectatorManagerEntityData))]
	public class CinebitSpectatorManagerEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CinebitSpectatorManagerEntityData>
	{
		public new FrostySdk.Ebx.CinebitSpectatorManagerEntityData Data => data as FrostySdk.Ebx.CinebitSpectatorManagerEntityData;
		public override string DisplayName => "CinebitSpectatorManager";

		public CinebitSpectatorManagerEntity(FrostySdk.Ebx.CinebitSpectatorManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

