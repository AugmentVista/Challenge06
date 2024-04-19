using UnityEngine;
using UnityEngine.UI;

public class ColorSlider : MonoBehaviour
{
    public Slider redSlider;
    public Slider greenSlider;
    public Slider blueSlider;
    public Slider alphaSlider;
    public Image targetImage;

    void Start()
    {
        redSlider.onValueChanged.AddListener(UpdateColor);
        greenSlider.onValueChanged.AddListener(UpdateColor);
        blueSlider.onValueChanged.AddListener(UpdateColor);
        alphaSlider.onValueChanged.AddListener(UpdateColor);
    }

    void UpdateColor(float value)
    {
        float red = redSlider.value;
        float green = greenSlider.value;
        float blue = blueSlider.value;
        float alpha = alphaSlider.value;

        targetImage.color = new Color(red, green, blue, alpha);
    }
}