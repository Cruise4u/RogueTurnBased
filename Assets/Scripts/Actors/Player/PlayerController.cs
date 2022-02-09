using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{














    //public override void SetupCommands()
    //{
    //    commandInvoker = new CommandInvoker();
    //    // ID -> 0
    //    commandInvoker.AddCommand(new MoveCommand(transform));
    //    // ID -> 1
    //}
}









public class CommandInvoker
{
    public List<ICommand> commandList;

    public void AddCommand(ICommand command)
    {
        commandList.Add(command);
    }

    public void RemoveCommand(ICommand command)
    {
        commandList.Remove(command);
    }

    public void InvokeCommand(int id)
    {
        commandList[id].Execute();
    }


}