using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GenericTower : MonoBehaviour
{
    [field: SerializeField] public string TowerName { get; protected set; } = "Generic Tower";
    [field: SerializeField] public Image ImageGrid { get; protected set; }
    [field: SerializeField] public GameObject UnitPrefab { get; protected set; }
    public virtual void Initialize()
    {
        // Initialization logic for the generic tower
        Debug.Log(TowerName + " Initialized");
    }
    public virtual void Run()
    {
        // Run logic for the generic tower
        Debug.Log(TowerName + " Running");
    }
    public virtual void Spawn()
    {
        Debug.Log(TowerName + " Spawn");
    }
    public virtual void Restart()
    {
        Debug.Log(TowerName + "Restart");
    }
    /* void Start()
    {
        Initialize();
        Run();
    }  */
}
