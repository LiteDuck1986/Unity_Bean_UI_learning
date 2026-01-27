using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{

    public GameObject bean;
    public GameObject teddy;
    public GameObject car;
    public GameObject granny;
    public GameObject toggleLeft;
    public GameObject toggleRight;
    public Image characterImage;
    public Sprite[] characterSprites;
    public Slider sizeSlider;
    public Slider rotationSlider;

    public void ToggleBean(bool value)
    {
        bean.SetActive(value);
        toggleLeft.GetComponent<Toggle>().interactable = value;
        toggleRight.GetComponent<Toggle>().interactable = value;
    }

    public void ToggleFlip(bool value)
    {
        if (toggleLeft.GetComponent<Toggle>().isOn)
        {
            bean.transform.localScale = new Vector2(1, 1);
        }

        if (toggleRight.GetComponent<Toggle>().isOn)
        {
            bean.transform.localScale = new Vector2(-1, 1);
        }
    }

    public void ToggleTeddy(bool value)
    {
        teddy.SetActive(value);
    }

    public void ToggleCar(bool value)
    {
        car.SetActive(value);
    }

    public void ToggleGranny(bool value)
    {
        granny.SetActive(value);
    }

    public void ChangeCharacterImage(int index)
    {
        characterImage.GetComponent<Image>().sprite = characterSprites[index];
    }

    public void ChangeRotation()
    {
        float rotationValue = rotationSlider.GetComponent<Slider>().value;
        characterImage.transform.localRotation = Quaternion.Euler(0, 0, 360 * rotationValue);
    }

    public void ChangeSize()
    {
        float sizeValue = sizeSlider.GetComponent<Slider>().value;
        characterImage.transform.localScale = new Vector2(2f * sizeValue, 2f * sizeValue);
    }

}
