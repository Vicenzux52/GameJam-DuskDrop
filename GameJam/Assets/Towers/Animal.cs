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
        GameObject temp = Instantiate(UnitPrefab, spawnpoint.transform.position, Quaternion.identity);
        temp.transform.localScale = new Vector3(144,144,144);
    }
}
