using System.Collections;
using UnityEngine;

public class ReferenceManager : MonoBehaviour
{
    public static IGridContext gridReference;

    public void Start()
    {
        Init();
    }

    public void Init()
    {
        CreateReferenceFactory(new GlobalReferenceFactory());
    }
    public void CreateReferenceFactory(IReferenceFactory factory)
    {
        gridReference = factory.CreateGridReference();
    }

}

