using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Nexus : MonoBehaviour
{
    public static Nexus Self { get; private set; }
    [SerializeField] int life = 10;
    [SerializeField] Spawner spawner;
    [SerializeField] MoonLightMovement moon;
    List<UndefinedTower> options = new List<UndefinedTower>();
    moon moonJust;
    public void AddSelf(UndefinedTower option)
    {
        options.Add(option);
    }
    public void AddSelf(Spawner spawner)
    {
        this.spawner = spawner;
    }
    public void AddSelf(MoonLightMovement moon)
    {
        this.moon = moon;
    }
    public void AddSelf(moon moon)
    {
        this.moonJust = moon;
    }
    public void Select(UndefinedTower me)
    {
        options.Remove(me);
        if (options.Count == 0) StartCombat();
    }
    void Awake()
    {
        if (Self == null)
        {
            Self = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void StartCombat()
    {
        if (spawner != null) spawner.StartCombat();
        if (moon != null) moon.StartCombat();
        if (moonJust != null) moonJust.StartCombat();
    }
    public void Harm(int damage)
    {
        life -= damage;
        if (life < 1)
        {
            SceneManager.LoadScene("Lose");
        }
    }
#if UNITY_EDITOR
    public bool run = false;
    void Update()
    {
        if (run)
        {
            run = false;
            StartCombat();
        }
    }
#endif
}
