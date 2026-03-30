using System;
using Unity.Behavior;
using UnityEngine;
using Action = Unity.Behavior.Action;
using Unity.Properties;

[Serializable, GeneratePropertyBag]
[NodeDescription(name: "Modify Variable", story: "[float] add [amount]", category: "Action/Blackboard", id: "ce53e50faa87641ff5be186168134e57")]
public partial class ModifyVariableAction : Action
{
    [SerializeReference] public BlackboardVariable<float> Float;
    [SerializeReference] public BlackboardVariable<float> Amount;

    protected override Status OnStart()
    {
        Float.Value += Amount.Value;
        return Status.Success;
    }
}

