using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CinebitInterpolatorEntityData))]
	public class CinebitInterpolatorEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CinebitInterpolatorEntityData>
	{
		public new FrostySdk.Ebx.CinebitInterpolatorEntityData Data => data as FrostySdk.Ebx.CinebitInterpolatorEntityData;
		public override string DisplayName => "CinebitInterpolator";
		public override FrostySdk.Ebx.Realm Realm => Data.Realm;

		public CinebitInterpolatorEntity(FrostySdk.Ebx.CinebitInterpolatorEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

