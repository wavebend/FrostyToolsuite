using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.WSObjectiveDisplayEntityData))]
	public class WSObjectiveDisplayEntity : LogicReferenceObject, IEntityData<FrostySdk.Ebx.WSObjectiveDisplayEntityData>
	{
		public new FrostySdk.Ebx.WSObjectiveDisplayEntityData Data => data as FrostySdk.Ebx.WSObjectiveDisplayEntityData;

		public WSObjectiveDisplayEntity(FrostySdk.Ebx.WSObjectiveDisplayEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

