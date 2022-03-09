using System.Collections;
using UnityEngine;

public class ReferenceManager : MonoBehaviour
{
    public static IGridReference gridContext;

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
        gridContext =  factory.CreateGridContext();
    }

}

