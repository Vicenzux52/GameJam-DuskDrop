using System.Collections.Generic;
using UnityEngine;

public class OptionOpen : MonoBehaviour
{
    Vector3 OriginalScale;
    public bool DontClose = false;
    bool MouseExit = false;
    public bool selected = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OriginalScale = transform.localScale;
        transform.localScale = Vector3.zero; // Start with scale zero
        this.gameObject.SetActive(false); // Deactivate the object initially
    }
    public void Select()
    {
        selected = true;
    }
    // Update is called once per frame
    void Update()
    {
        // Gradually increase the scale to the original scale
        if (transform.localScale.x < OriginalScale.x)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, OriginalScale, Time.deltaTime * 25);
        }
        else
        {
            transform.localScale = OriginalScale; // Ensure it reaches the original scale
        }
        if (MouseExit && !DontClose)
        {
            if (transform.localScale.x > OriginalScale.x*0.1f)
            {
                transform.localScale = Vector3.Lerp(Vector3.zero, transform.localScale, Time.deltaTime * 12);
            }
            else
            {
                Debug.Log("Deactivating OptionOpen");
                transform.localScale = Vector3.zero; // Ensure it reaches the original scale
                DontClose = false;
                MouseExit = false;
                gameObject.SetActive(false); // Deactivate the object when scale is zero
            }
        }
    }

    void OnMouseExit()
    {
        MouseExit = true;
    }
    void OnMouseEnter()
    {
        MouseExit = false;
    }
}
