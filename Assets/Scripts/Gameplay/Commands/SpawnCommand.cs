public class SpawnCommand : ICommand
{
    private IGridContext gridReference;

    public SpawnCommand()
    {
        gridReference = ReferenceManager.gridReference;
    }

    public void Execute(ICommandContext context)
    {
        var spawnContext = (ISpawnContext)context;
        //spawnContext.Spawn();
    }


}