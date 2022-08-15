using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.CoverPrepareFireEntityData))]
	public class CoverPrepareFireEntity : LogicEntity, IEntityData<FrostySdk.Ebx.CoverPrepareFireEntityData>
	{
		public new FrostySdk.Ebx.CoverPrepareFireEntityData Data => data as FrostySdk.Ebx.CoverPrepareFireEntityData;
		public override string DisplayName => "CoverPrepareFire";

		public CoverPrepareFireEntity(FrostySdk.Ebx.CoverPrepareFireEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

