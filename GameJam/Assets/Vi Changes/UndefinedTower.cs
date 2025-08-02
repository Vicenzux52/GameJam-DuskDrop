using UnityEngine;

public class UndefinedTower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject PrefabOptions;
    void Start()
    {
        PrefabOptions.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseUp()
    {
        PrefabOptions.SetActive(true);
    }
}
