using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSizeBehavior : MonoBehaviour
{
    SliderScript sliderScript = null;
    void Start()
    {
        sliderScript = FindObjectOfType<SliderScript>();
    }

    void Update()
    {
        float value = sliderScript.sliderValue * 2;
        if (sliderScript.sliderValue > 0)
        {
            gameObject.transform.localScale = new Vector3(value, value, 0f);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
