using System.Collections;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    public abstract AbilityData AbilityData { get; }
    public abstract TargetingType targetingType { get; }
}

