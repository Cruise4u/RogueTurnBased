using System;
using UnityEngine;

public abstract class BaseComponent : MonoBehaviour
{
    public ICellReference cellReference;

    public virtual void SetReference(ICellReference cellReference)
    {
        this.cellReference = cellReference;
    }

    public abstract void ExecuteLogic();

    public abstract bool IsPossibleToExecute();
}

