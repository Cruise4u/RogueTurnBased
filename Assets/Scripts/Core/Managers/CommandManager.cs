using System.Collections;
using UnityEngine;

public abstract class CommandManager : MonoBehaviour
{
    public abstract void ExecuteCommandOfType(ICommand command);
}


