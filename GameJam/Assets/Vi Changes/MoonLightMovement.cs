using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class MoonLightMovement : MonoBehaviour
{
    public GameObject HalfMoon;
    public GameObject FullMoon;
    public GameObject SmallMoon1;
    public GameObject SmallMoon2;
    Vector3 TargetPosition;
    Quaternion TargetRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Nexus.Self.AddSelf(this);
        HalfMoon.SetActive(false);
        FullMoon.SetActive(false);
        SmallMoon1.SetActive(false);
        SmallMoon2.SetActive(false);
    }
    public void StartCombat()
    {
        if(PlayerPrefs.GetInt("Difficulty")<2)HalfMoon.SetActive(true);
        if(PlayerPrefs.GetInt("Difficulty")==0)FullMoon.SetActive(true);
        SmallMoon1.SetActive(true);
        SmallMoon2.SetActive(true);
        TargetPosition = new Vector3(0.18f, 1, 0.18f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (TargetPosition.z != 0.18f)
            {
                TargetPosition.z = 0.18f;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (TargetPosition.x != -0.18f)
            {
                TargetPosition.x = -0.18f;
            }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (TargetPosition.z != -0.18f)
            {
                TargetPosition.z = -0.18f;
            }
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (TargetPosition.x != 0.18f)
            {
                TargetPosition.x = 0.18f;
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TargetRotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y + 90, 0);
        }
        transform.localPosition = new Vector3(Mathf.SmoothStep(transform.localPosition.x, TargetPosition.x, 0.1f),
        1, Mathf.SmoothStep(transform.localPosition.z, TargetPosition.z, 0.1f));
        transform.rotation = Quaternion.Slerp(transform.rotation, TargetRotation, 0.1f);
    }
}
