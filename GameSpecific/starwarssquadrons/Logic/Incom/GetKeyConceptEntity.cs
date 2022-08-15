using System.Collections.Generic;

namespace LevelEditorPlugin.Entities
{
	[EntityBinding(DataType = typeof(FrostySdk.Ebx.GetKeyConceptEntityData))]
	public class GetKeyConceptEntity : LogicEntity, IEntityData<FrostySdk.Ebx.GetKeyConceptEntityData>
	{
		public new FrostySdk.Ebx.GetKeyConceptEntityData Data => data as FrostySdk.Ebx.GetKeyConceptEntityData;
		public override string DisplayName => "GetKeyConcept";

		public GetKeyConceptEntity(FrostySdk.Ebx.GetKeyConceptEntityData inData, Entity inParent)
			: base(inData, inParent)
		{
		}
	}
}

