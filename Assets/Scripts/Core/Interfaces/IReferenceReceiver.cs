using System.Collections;
using UnityEngine;

//Observer
public interface IReferenceReceiver
{
    void GetNotified(Cell cell);
}
