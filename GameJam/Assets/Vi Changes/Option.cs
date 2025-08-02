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
        transform.localScale = new Vector3(transform.localScale.x * 1.2f, transform.localScale.y * 1.2f, transform.localScale.z * 1.2f);
    }
    void OnMouseExit()
    {
        transform.localScale = new Vector3(transform.localScale.x / 1.2f, transform.localScale.y / 1.2f, transform.localScale.z / 1.2f);
    }
    void OnMouseUp()
    {
        if (gameObject.GetComponent<Material>().name == "Cupuacu")
        {
            Instantiate(CupuacuPrefab, transform.parent.parent.position, Quaternion.identity);
        }
        else if (gameObject.GetComponent<Material>().name == "Guarana")
        {
            Instantiate(GuaranaPrefab, transform.parent.parent.position, Quaternion.identity);
        }
        else if (gameObject.GetComponent<Material>().name == "Jabuticaba")
        {
            Instantiate(JabuticabaPrefab, transform.parent.parent.position, Quaternion.identity);
        }
        else if (gameObject.GetComponent<Material>().name == "Lobo")
        {
            Instantiate(LoboPrefab, transform.parent.parent.position, Quaternion.identity); 
        }
        else if (gameObject.GetComponent<Material>().name == "Onca")
        {
            Instantiate(OncaPrefab, transform.parent.parent.position, Quaternion.identity);
        }
        else if (gameObject.GetComponent<Material>().name == "Sapo")
        {
            Instantiate(SapoPrefab, transform.parent.parent.position, Quaternion.identity);
        }
    }
}
