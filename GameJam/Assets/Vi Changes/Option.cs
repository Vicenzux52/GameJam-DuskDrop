using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject CupuacuPrefab;
    public GameObject GuaranaPrefab;
    public GameObject JabuticabaPrefab;
    public GameObject LoboPrefab;
    public GameObject OncaPrefab;
    public GameObject SapoPrefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f, transform.localScale.z * 1.1f);
        transform.parent.GetComponent<OptionOpen>().DontClose = true; // Prevent the option from closing when hovered
    }
    void OnMouseExit()
    {
        transform.localScale = new Vector3(transform.localScale.x / 1.1f, transform.localScale.y / 1.1f, transform.localScale.z / 1.1f);
        transform.parent.GetComponent<OptionOpen>().DontClose = false; // Prevent the option from closing when hovered
    }
    void OnMouseUp()
    {
        if (gameObject.name == "CupuacuOption")
        {
            Instantiate(CupuacuPrefab, transform.parent.parent.position, Quaternion.identity);
            Destroy(transform.parent.parent.gameObject);
        }
        else if (gameObject.name == "GuaranaOption")
        {
            Instantiate(GuaranaPrefab, transform.parent.parent.position, Quaternion.identity);
            Destroy(transform.parent.parent.gameObject);
        }
        else if (gameObject.name == "JabuticabaOption")
        {
            Instantiate(JabuticabaPrefab, transform.parent.parent.position, Quaternion.identity);
            Destroy(transform.parent.parent.gameObject);
        }
        else if (gameObject.name == "LoboOption ")
        {
            Instantiate(LoboPrefab, transform.parent.parent.position, Quaternion.identity);
            Destroy(transform.parent.parent.gameObject);
        }
        else if (gameObject.name == "OncaOption")
        {
            Instantiate(OncaPrefab, transform.parent.parent.position, Quaternion.identity);
            Destroy(transform.parent.parent.gameObject);
        }
        else if (gameObject.name == "SapoOption")
        {
            Instantiate(SapoPrefab, transform.parent.parent.position, Quaternion.identity);
            Destroy(transform.parent.parent.gameObject);
        }
    }
}
