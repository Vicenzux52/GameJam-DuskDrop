using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class MoonLightMovement : MonoBehaviour
{
    public GameObject HalfMoon;
    public GameObject FullMoon;
    Vector3 TargetPosition;
    public int LimitX = 4;
    public int LimitZ = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HalfMoon.SetActive(false);
        FullMoon.SetActive(false);
        TargetPosition = new Vector3(0, 3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (TargetPosition.z + 2 <= LimitZ)
            {
                TargetPosition += new Vector3(0, 0, 2);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (TargetPosition.x - 2 >= -LimitX)
            {
                TargetPosition += new Vector3(-2, 0, 0);
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (TargetPosition.z - 2 >= 0)
            {
                TargetPosition += new Vector3(0, 0, -2);
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (TargetPosition.x + 2 <= 0)
            {
                TargetPosition += new Vector3(2, 0, 0);
            }
        }
        transform.position = new Vector3(Mathf.SmoothStep(transform.position.x, TargetPosition.x, 0.1f),
        3, Mathf.SmoothStep(transform.position.z, TargetPosition.z, 0.1f));
    }
}
