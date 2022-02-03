using System.Collections;
using UnityEngine;

public class GlobalReferenceFactory : IReferenceFactory
{
    public IReferenceGrid CreateGridReference()
    {
        return new GridReferencer();
    }


}