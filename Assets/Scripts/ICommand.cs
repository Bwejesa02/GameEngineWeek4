using UnityEngine;

public interface ICommand
{
    void Execute();
}

public class SpawnBlockCommand : ICommand
{
    public void Execute()
    {
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = new Vector3(Random.Range(-4, 4), ModifierLoader.GetSpawnHeight(), 0);
    }
}

public class SpawnSphereCommand : ICommand
{
    public void Execute()
    {
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.GetComponent<Renderer>().material.color = Color.red;
        sphere.transform.position = new Vector3(Random.Range(-4, 4), ModifierLoader.GetSpawnHeight(), 0);
    }
}
