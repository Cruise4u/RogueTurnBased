using System.Collections;
using UnityEngine;

public class LevelCommandManager : CommandManager
{
    public SpawnCommand spawnCommand;

    public override void ExecuteCommandOfType(ICommand command)
    {
        switch (command)
        {
            case SpawnCommand:
                command.Execute(GetComponent<Spawner>());
                break;
        }
    }
}
