using System.Collections;
using UnityEngine;

public class GlobalReferenceFactory : IReferenceFactory
{
    public IGridReference CreateGridContext()
    {
        return new GridReference();
    }

}