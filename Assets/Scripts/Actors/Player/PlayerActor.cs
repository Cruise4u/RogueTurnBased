using System.Collections;
using UnityEngine;

public class PlayerActor : MonoBehaviour /*,IActorContext*/
{
    public int actorID;
    public int ActorID { get => actorID; }

    public void Init()
    {

    }

    public GameObject GetActorObject()
    {
        return gameObject;
    }
}

//public interface IActorContext : ICommandContext
//{
//    int ActorID { get; }
//    GameObject GetActorObject();
//}
