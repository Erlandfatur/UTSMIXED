using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewRotateScaler : MonoBehaviour
{
    public Slider RotateSlider; // Slider untuk rotasi Y (global)
    public Slider ScaleSlider;  // Slider untuk skala
    public Slider RotateXSlider; // Slider untuk rotasi X (lokal)

    public float scaleMinValue; // Nilai minimum skala
    public float scaleMaxValue; // Nilai maksimum skala
    public float rotYMinValue; // Nilai minimum rotasi Y (global)
    public float rotYMaxValue; // Nilai maksimum rotasi Y (global)
    public float rotXMinValue; // Nilai minimum rotasi X (lokal)
    public float rotXMaxValue; // Nilai maksimum rotasi X (lokal)

    private float currentYRotation;
    private float currentXRotation;

    void Start()
    {
        // Mengatur nilai minimum dan maksimum untuk skala
        ScaleSlider.minValue = scaleMinValue;
        ScaleSlider.maxValue = scaleMaxValue;
        ScaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);

        // Mengatur nilai minimum dan maksimum untuk rotasi Y (global)
        RotateSlider.minValue = rotYMinValue;
        RotateSlider.maxValue = rotYMaxValue;
        RotateSlider.onValueChanged.AddListener(RotateSliderUpdate);

        // Mengatur nilai minimum dan maksimum untuk rotasi X (lokal)
        RotateXSlider.minValue = rotXMinValue;
        RotateXSlider.maxValue = rotXMaxValue;
        RotateXSlider.onValueChanged.AddListener(RotateXSliderUpdate);

        // Inisialisasi rotasi awal
        currentYRotation = transform.eulerAngles.y;
        currentXRotation = transform.localEulerAngles.x;
    }

    void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }

    void RotateSliderUpdate(float value)
    {
        currentYRotation = value;
        UpdateRotation();
    }

    void RotateXSliderUpdate(float value)
    {
        currentXRotation = value;
        UpdateRotation();
    }

    void UpdateRotation()
    {
        Quaternion globalYRotation = Quaternion.Euler(0, currentYRotation, 0);
        Quaternion localXRotation = Quaternion.Euler(currentXRotation, 0, 0);
        transform.rotation = globalYRotation * localXRotation;
    }
}
