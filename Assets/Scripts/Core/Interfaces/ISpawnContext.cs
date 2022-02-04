public interface ISpawnContext : ICommandContext
{
    void Spawn(IGridContext gridReference);
}