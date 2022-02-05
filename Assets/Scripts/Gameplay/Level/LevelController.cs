using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : BaseCommandController
{
    public override void SetupCommands()
    {
        commandInvoker = new CommandInvoker();

        // ID -> 0
        commandInvoker.AddCommand(new SpawnCommand(0, GetComponent<Spawner>()));
        // ID -> 1
    }
}

public abstract class BaseCommandController : MonoBehaviour
{
    public CommandInvoker commandInvoker;

    public abstract void SetupCommands();
    public void RequestCommand(int id)
    {
        commandInvoker.InvokeCommand(id);
    }
}