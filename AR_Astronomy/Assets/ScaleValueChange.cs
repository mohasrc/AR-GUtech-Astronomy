using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScaleValueChange : MonoBehaviour
{
    public Slider slider;
    public TextMeshProUGUI sliderText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sliderText.text = "Scale " + Mathf.RoundToInt(slider.value * 100) + "%";
    }
}
