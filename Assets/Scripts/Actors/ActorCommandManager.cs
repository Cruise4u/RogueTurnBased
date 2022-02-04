using System.Collections;
using UnityEngine;

public class ActorCommandManager : CommandManager
{
    public MoveCommand moveCommand;

    public void Init()
    {
        moveCommand = new MoveCommand(transform);
    }

    public override void ExecuteCommandOfType(ICommand command)
    {
        switch (command)
        {
            case MoveCommand:
                command.Execute(GetComponent<ActorMovement>());
                break;

        }
    }
}