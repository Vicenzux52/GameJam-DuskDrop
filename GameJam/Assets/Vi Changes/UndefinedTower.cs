using System.Collections.Generic;
using UnityEngine;

public class UndefinedTower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject PrefabOptions;
    Color OriginalColor;
    public bool selected = false;
    void Start()
    {
        PrefabOptions.SetActive(false);
        OriginalColor = gameObject.GetComponent<Renderer>().material.color;
        Nexus.Self.AddSelf(this);
    }
    void OnDestroy()
    {
        Nexus.Self.Select(this);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        gameObject.GetComponent<Renderer>().material.color = new Color(OriginalColor.r-0.2f , OriginalColor.g-0.2f , OriginalColor.b-0.2f, OriginalColor.a); // Change color to yellow when hovered
    }

    void OnMouseExit()
    {
        gameObject.GetComponent<Renderer>().material.color = OriginalColor; // Revert to original color when not hovered
        
    }
    void OnMouseUp()
    {
        PrefabOptions.SetActive(true);
    }
}
