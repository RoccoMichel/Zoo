using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Random Proceed", story: "[percentage] % of continue", category: "Flow", id: "df8f26fea52701138de0b4a38b332c66")]
public partial class RandomProceedAction : Action
{
    [SerializeReference] public BlackboardVariable<int> Percentage;

    protected override Status OnStart()
    {
        if (UnityEngine.Random.Range(0, 100) < Percentage) return Status.Success;
        else return Status.Failure;
    }
}

