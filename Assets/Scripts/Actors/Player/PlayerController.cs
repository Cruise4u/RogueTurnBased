using System.Collections;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public ActorCommandManager actorCommandManager;

    public void Init()
    {
        actorCommandManager.Init();
    }

    public void Something(int orderIndex)
    {
        switch(orderIndex)
        {
            case 0:
                actorCommandManager.ExecuteCommandOfType(actorCommandManager.moveCommand);
                break;
        }
    }

    public void Start()
    {
        Init();
    }
}