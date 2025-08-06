using Unity.VisualScripting;
using UnityEngine;

public class Option : MonoBehaviour
{
    public GameObject CupuacuPrefab;
    public GameObject GuaranaPrefab;
    public GameObject JabuticabaPrefab;
    public GameObject LoboPrefab;
    public GameObject OncaPrefab;
    public GameObject SapoPrefab;
    public GameObject spUnit;
    OptionOpen father;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        father = transform.parent.GetComponent<OptionOpen>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        transform.localScale = new Vector3(transform.localScale.x * 1.1f, transform.localScale.y * 1.1f, transform.localScale.z * 1.1f);
        father.DontClose = true; // Prevent the option from closing when hovered
    }
    void OnMouseExit()
    {
        transform.localScale = new Vector3(transform.localScale.x / 1.1f, transform.localScale.y / 1.1f, transform.localScale.z / 1.1f);
        father.DontClose = false; // Prevent the option from closing when hovered
    }
    void OnMouseUp()
    {
        if (gameObject.name == "CupuacuOption")
        {
            GameObject temp = Instantiate(CupuacuPrefab, transform.parent.parent.position, Quaternion.identity);
            temp.GetComponent<GenericTower>().spawnpoint = spUnit;
            temp.transform.localScale = new Vector3(200, 100, 200);
            Destroy(transform.parent.parent.gameObject);
        }
        else if (gameObject.name == "GuaranaOption")
        {
            GameObject temp = Instantiate(GuaranaPrefab, transform.parent.parent.position, Quaternion.identity);
            temp.GetComponent<GenericTower>().spawnpoint = spUnit;
            temp.transform.localScale = new Vector3(200, 100, 200);
            Destroy(transform.parent.parent.gameObject);
        }
        else if (gameObject.name == "JabuticabaOption")
        {
            GameObject temp = Instantiate(JabuticabaPrefab, transform.parent.parent.position, Quaternion.identity);
            temp.GetComponent<GenericTower>().spawnpoint = spUnit;
            temp.transform.localScale = new Vector3(200, 100, 200);
            Destroy(transform.parent.parent.gameObject);
        }
        else if (gameObject.name == "LoboOption")
        {
            GameObject temp = Instantiate(LoboPrefab, transform.parent.parent.position, Quaternion.identity);
            temp.GetComponent<GenericTower>().spawnpoint = spUnit;
            temp.transform.localScale = new Vector3(200, 100, 200);
            Destroy(transform.parent.parent.gameObject);
        }
        else if (gameObject.name == "OncaOption")
        {
            GameObject temp = Instantiate(OncaPrefab, transform.parent.parent.position, Quaternion.identity);
            temp.GetComponent<GenericTower>().spawnpoint = spUnit;
            temp.transform.localScale = new Vector3(200, 100, 200);
            Destroy(transform.parent.parent.gameObject);
        }
        else if (gameObject.name == "SapoOption")
        {
            GameObject temp = Instantiate(SapoPrefab, transform.parent.parent.position, Quaternion.identity);
            temp.GetComponent<GenericTower>().spawnpoint = spUnit;
            temp.transform.localScale = new Vector3(200, 100, 200);
            Destroy(transform.parent.parent.gameObject);
        }
    }
}
