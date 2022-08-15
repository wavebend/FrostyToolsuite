using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.IncomCinebitSpectatorManagerEntityData))]
	public class IncomCinebitSpectatorManagerEntity : CinebitSpectatorManagerEntity, IEntityData<FrostySdk.Ebx.IncomCinebitSpectatorManagerEntityData>
	{
		public new FrostySdk.Ebx.IncomCinebitSpectatorManagerEntityData Data => data as FrostySdk.Ebx.IncomCinebitSpectatorManagerEntityData;
		public override string DisplayName => "IncomCinebitSpectatorManager";

		public IncomCinebitSpectatorManagerEntity(FrostySdk.Ebx.IncomCinebitSpectatorManagerEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

