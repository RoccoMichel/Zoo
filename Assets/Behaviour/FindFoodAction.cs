using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Find Food", story: "Set [Target] to one of tag [tagString]", category: "Action", id: "3eeb620e8777eda70f655159e99f50d6")]
public partial class FindFoodAction : Action
{
    [SerializeReference] public BlackboardVariable<GameObject> Target;
    [SerializeReference] public BlackboardVariable<string> TagString;

    protected override Status OnStart()
    {
        GameObject[] allFood = GameObject.FindGameObjectsWithTag(TagString);

        if (allFood == null || allFood.Length == 0) return Status.Failure;

        Target.Value = allFood[UnityEngine.Random.Range(0, allFood.Length)];
        return Status.Success;
    }
}

