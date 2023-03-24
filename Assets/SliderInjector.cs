using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
using Reaktion; 

public class SliderInjector : InjectorBase
{
    public float value; 

    public Slider slider; 

    void Update()
    {
        dbLevel = slider.value; 
    }
}
