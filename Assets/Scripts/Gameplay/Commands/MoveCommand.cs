using System.Collections;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Transform transform;
    private IGridContext gridContext;

    public MoveCommand(Transform transform)
    {
        this.transform = transform;
        gridContext = ReferenceManager.gridReference;
    }

    public void Execute(ICommandContext context)
    {
        var positionContext = (IPositionContext)context;
        positionContext.Move(gridContext, false);
    }


}