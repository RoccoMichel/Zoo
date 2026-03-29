using System;
using System.Collections.Generic;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Set Object to Random of Array", story: "Set [Target] from [List]", category: "Action", id: "c9d96a67267024022f7a89f748a6b472")]
public partial class SetObjectToRandomOfArrayAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Target;
    [SerializeReference] public BlackboardVariable<List<GameObject>> List;

    protected override Status OnStart()
    {
        try { Target.Value = List.Value[UnityEngine.Random.Range(0, List.Value.Count)]; }
        catch { return Status.Failure; }

        return Status.Success;
    }
}

