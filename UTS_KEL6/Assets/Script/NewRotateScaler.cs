using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewRotateScaler : MonoBehaviour
{
    public Slider RotateSlider;
    public Slider ScaleSlider;
    public float scaleMinValue;
    public float scaleMaxValue;
    public float rotMinValue;
    public float rotMaxValue;

    // Start is called before the first frame update
    void Start()
    {
        ScaleSlider.minValue = scaleMinValue;
        ScaleSlider.maxValue = scaleMaxValue;

        ScaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);


        RotateSlider.minValue = rotMinValue;
        RotateSlider.maxValue = rotMaxValue;

        RotateSlider.onValueChanged.AddListener(RotateSliderUpdate);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }

    void RotateSliderUpdate(float value)
    {
        transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);
    }
}
