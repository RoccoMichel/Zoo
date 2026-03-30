using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "take a shit", story: "shit from [transform]", category: "Action", id: "e596a4d8bc68027ffbc7b1aa9229ce86")]
public partial class TakeAShitAction : Action
{
    [SerializeReference] public BlackboardVariable<Transform> Transform;

    protected override Status OnStart()
    {
        GameObject.Instantiate(Resources.Load<GameObject>("Poop"), Transform.Value.position, UnityEngine.Random.rotation);
        return Status.Success;
    }
}