using System.Collections;
using UnityEngine;

public class ReferenceManager : MonoBehaviour
{
    public static IReferenceGrid gridReference;

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