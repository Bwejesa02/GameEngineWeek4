using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    public void SpawnBlock()
    {
        ICommand cmd = new SpawnBlockCommand();
        cmd.Execute();
    }

    public void SpawnSphere()
    {
        ICommand cmd = new SpawnSphereCommand();
        cmd.Execute();
    }
}
