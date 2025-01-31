using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Slider slider;
    private float hunger = 100;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("DecreaseHunger", 1, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            IncreaseHunger();
        }
    }

    private void DecreaseHunger()
    {
        hunger -= 0.5f;
        slider.value = hunger;
    }
    private void IncreaseHunger()
    {
        hunger += 20;
        slider.value = hunger;
    }

}
