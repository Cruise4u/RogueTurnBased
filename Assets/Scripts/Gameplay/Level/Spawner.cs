using System;
using UnityEngine;

public class Spawner : MonoBehaviour,ISpawnContext
{
    public SpawnerData spawnerData;


    public void Spawn(IGridContext gridReference)
    {
        throw new NotImplementedException();
    }
}