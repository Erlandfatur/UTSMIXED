using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewRotateScaler : MonoBehaviour
{
    public Slider RotateSlider;
    public Slider ScaleSlider;
    public Slider RotateXSlider;

    public float scaleMinValue;
    public float scaleMaxValue;
    public float rotYMinValue;
    public float rotYMaxValue;
    public float rotXMinValue;
    public float rotXMaxValue;


    // Start is called before the first frame update
    void Start()
    {
        ScaleSlider.minValue = scaleMinValue;
        ScaleSlider.maxValue = scaleMaxValue;

        ScaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);


        RotateSlider.minValue = rotYMinValue;
        RotateSlider.maxValue = rotYMaxValue;

        RotateSlider.onValueChanged.AddListener(RotateSliderUpdate);

        RotateXSlider.minValue = rotXMinValue;
        RotateXSlider.maxValue = rotXMaxValue;

        RotateXSlider.onValueChanged.AddListener(RotateSliderAtas);



        
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

    void RotateSliderAtas(float x)
    {
        transform.localEulerAngles = new Vector3(x, transform.rotation.y, transform.rotation.z);
    }

}
