using UnityEditor;
using UnityEngine;

public interface ICommandContext
{

}

public interface ICommand
{
    void Execute();
}
