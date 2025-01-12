using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class LeverControl : MonoBehaviour
{

    private Animator leverAnimation;
    public Slider leverSlider;

    void Awake()
    {
        leverAnimation = gameObject.GetComponent<Animator>();
        leverAnimation.speed = 0;
    }

    // Update is called once per frame
    public void sliderChanged(){
        leverAnimation.SetFloat("State",leverSlider.value);
    }   
}
