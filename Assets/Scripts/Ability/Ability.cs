using System.Collections;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public TargetingType targetingType;

    public AbilityData AbilityData { get; }

    public abstract void DoAbility(ITarget target);




}
