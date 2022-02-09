using System.Collections;
using UnityEngine;

public interface ICommandInvokerContext
{
    void InvokeCommand(string commandName,ICommandContext commandContext);
}