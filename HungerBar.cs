using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public Slider slider;
    private float hunger;
    // Start is called before the first frame update
    void Start()
    {
        hunger = 100;
        InvokeRepeating("DecreaseHunger", 3, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void DecreaseHunger()
    {
        hunger -= 0.5f;
        slider.value = hunger;
    }
    public void IncreaseHunger()
    {
        hunger += 20;
        slider.value = hunger;
    }

}
