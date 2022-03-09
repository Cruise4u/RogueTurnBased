using System.Collections;
using UnityEngine;

[CreateAssetMenu()]
public class BasicAbility : Ability,IDamage
{
    public override void DoAbility(ITarget target)
    {
        var singleTarget = (ITargetSingleActor)target;
        DoDamage(singleTarget.GetSingleTargetActor());
    }

    public void DoDamage(IDamagable damagable)
    {
        damagable.TakeDamage(AbilityData.power);
    }

}