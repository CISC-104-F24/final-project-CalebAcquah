using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public Slider sliderForBoss;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetHealth(int health)
    {
        sliderForBoss.value = health;
    }

    public void SetMaxHealth(int health)
    {
        sliderForBoss.maxValue = health;
        sliderForBoss.value = health;
    }
}
