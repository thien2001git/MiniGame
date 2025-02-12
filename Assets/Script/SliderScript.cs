using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private TextMeshProUGUI sliderText;

    public float sliderValue = 0.5f;
    void Start()
    {
        sliderText.text = sliderValue.ToString("0.00");
        slider.onValueChanged.AddListener((v) =>
        {
            sliderValue = v;
            sliderText.text = sliderValue.ToString("0.00");
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
