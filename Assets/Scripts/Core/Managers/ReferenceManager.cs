using System.Collections;
using UnityEngine;

public class ReferenceManager : MonoBehaviour
{
    public static IGridContext gridContext;
    public static ICommandInvokerContext commandInvokerContext;

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
        gridContext = factory.CreateGridContext();
    }

}

