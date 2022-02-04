using System.Collections;
using UnityEngine;

public class GlobalReferenceFactory : IReferenceFactory
{
    public IGridContext CreateGridReference()
    {
        return new GridReferencer();
    }


}