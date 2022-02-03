using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Subject
public interface IReferenceSender
{
    IReferenceReceiver cellReceiver {get;set;}
    void NotifyReceiver();
}
