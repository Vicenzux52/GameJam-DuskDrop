using UnityEngine;

public class Animal : GenericTower
{
    int amountSpawned;
    new void Start()
    {
        base.Start();
    }
    public override void Run()
    {
        Spawn();
    }
    public override void Spawn()
    {
        Instantiate(UnitPrefab, transform.position, Quaternion.identity);
    }
}
