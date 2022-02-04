using System.Collections;
using UnityEngine;

[RequireComponent(typeof(LevelCommandManager))]
public class LevelController : MonoBehaviour
{
    public LevelCommandManager levelCommandManager;

    public void Something(int orderIndex)
    {
        switch (orderIndex)
        {
            case 0:
                levelCommandManager.ExecuteCommandOfType(levelCommandManager.spawnCommand);
                break;
        }
    }
}