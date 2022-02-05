using System.Collections;
using UnityEngine;

public class GlobalReferenceFactory : IReferenceFactory
{
    public IGridContext CreateGridContext()
    {
        return new GridContext();
    }

}