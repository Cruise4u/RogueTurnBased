using UnityEngine;

public class Spawner : MonoBehaviour
{
    public SpawnerData spawnerData;

    public void Spawn(int actorID,IGridReference gridReference,int x,int y)
    {
        var instance = Instantiate(spawnerData.spawnInstanceArray[actorID]);
        var cell = gridReference.CellArray[x, y];
        instance.GetComponent<Movement>().Move(cell, true);
    }
}