using System.Collections;
using UnityEngine;

public class AbilityController : MonoBehaviour
{
    public Ability ability;
    public ITarget target;


    public bool IsAbilityTargetValid()
    {
        return false;
    }

    public void UseAbility(Ability ability,TargetingType targetType)
    {
        if(ability.targetingType == targetType)
        {
            ability.DoAbility(target);
        }
    }

    public void SetTarget(ITarget target)
    {
        this.target = target;
    }

}
