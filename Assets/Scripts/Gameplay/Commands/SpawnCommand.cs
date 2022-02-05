public class SpawnCommand : ICommand
{
    private int actorID;
    private ISpawnContext spawnContext;

    public SpawnCommand(int actorID,ISpawnContext spawnContext)
    {
        this.actorID = actorID;
        this.spawnContext = spawnContext;
    }

    public void Execute()
    {
        spawnContext.Spawn(actorID);
    }
}