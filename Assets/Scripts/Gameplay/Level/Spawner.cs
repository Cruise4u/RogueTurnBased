using UnityEngine;

public class Spawner : MonoBehaviour, ISpawnContext
{
    public SpawnerData spawnerData;

    public void Spawn(int actorID)
    {
        Instantiate(spawnerData.spawnInstanceArray[actorID]);
    }
}