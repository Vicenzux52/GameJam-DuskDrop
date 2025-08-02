using UnityEngine;
using UnityEngine.UI;

public class LilyPadInTheMoon : MonoBehaviour
{
    public Texture2D LilyPadTexture;
    public Texture2D MoonLilyPadTexture;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.GetComponent<Renderer>().material.mainTexture = LilyPadTexture;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("LilyPadInTheMoon: OnTriggerEnter called with " + other.name);
        if (other.CompareTag("MoonLight"))
        {
            transform.GetComponent<Renderer>().material.mainTexture = MoonLilyPadTexture;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("MoonLight"))
        {
            transform.GetComponent<Renderer>().material.mainTexture = LilyPadTexture;
        }
    }
}
