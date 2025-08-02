using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Tree : GenericTower
{
    GameObject tree = null;
    new void Start()
    {
        base.Start();
    }
    public override void Run()
    {
        Debug.Log("runtree");
        Spawn();
    }
    public override void Spawn()
    {
        Debug.Log("nnnnnnnn");
        if (tree == null) {tree = Instantiate(UnitPrefab, spawnpoint.transform.position, Quaternion.identity);
        tree.transform.localScale = new Vector3(144,144,144);}
    }
    public override void Restart()
    {
        if (tree != null) Destroy(tree, 2);
    }
}
