using System;
using System.Collections;
using UnityEngine;

public class MoveCommand : ICommand
{
    private Transform transform;
    private IPositionContext positionContext;
    private int x;
    private int y;

    public MoveCommand(Transform transform)
    {
        this.transform = transform;
    }

    public void SetupCoordinates(int x,int y)
    {
        this.x = x;
        this.y = y;
    }

    public void Execute()
    {
        positionContext.Move(positionContext.x,positionContext.y, false);
    }

}
