using UnityEngine;

public class BuffController : MonoBehaviour
{
    public static BuffController Self { get; private set; }
    public string[] buffsNames { get; private set; } = {
        "Damage Buff", //fixed
        "AtkSpeed Buff", //fixed
        "Range Buff",
        "Health Buff"
    };
    [SerializeField]
    float[] buffsValues = {
        20f, // Damage Buff fixed
        50f, // AtkSpeed Buff fixed
        30f, // Range Buff
        40f  // Health Buff
    };
    public float[] buffs { get; private set; }
    void Awake()
    {
        if (Self == null) Self = this;
        else
        {
            Destroy(this);
        }
        buffs = new float[buffsNames.Length];
        for (int i = 0; i < buffs.Length; i++)
        {
            buffs[i] = 1; // Initialize all buffs to 1
        }
    }
    public void AddBuff(int buffType)
    {
        if (buffType < 0 || buffType >= buffs.Length)
        {
            Debug.LogError("Invalid buff type: " + buffType);
            return;
        }
        buffs[buffType] += buffsValues[buffType] / 100;
    }
    public void RemoveBuff(int buffType)
    {
        if (buffType < 0 || buffType >= buffs.Length)
        {
            Debug.LogError("Invalid buff type: " + buffType);
            return;
        }
        if (buffs[buffType] > 0)
        {
            buffs[buffType] -= buffsValues[buffType] / 100;
        }
        else
        {
            Debug.LogWarning("Attempted to remove a buff that is not present: " + buffsNames[buffType]);
        }
    }
    void Start()
    {
        if (PlayerPrefs.GetInt("Difficulty") == 1)
        {
            buffs[0] = 2f; // Increase damage buff by 20% for Hard mode
        }
        else if (PlayerPrefs.GetInt("Difficulty") == 2)
        {
            buffs[0] = 3f; // Increase damage buff by 30% for Insane mode
        }
        
    }
}
