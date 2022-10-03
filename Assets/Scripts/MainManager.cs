using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Text descriptionText;


    public void CirclePanel()
    {
        Circle circle = new Circle("blue", "circle");
        panel.SetActive(true);

        descriptionText.text = circle.DisplayText() + circle.DefineYourSelf();
    }

    public void RectanglePanel()
    {
        Rectangle rectangle = new Rectangle("red", "rectangle");
        panel.SetActive(true);

        descriptionText.text = rectangle.DisplayText() + rectangle.DefineYourSelf();
    }

    public void TrianglePanel()
    {
        Triangle triangle = new Triangle("black", "triangle");
        panel.SetActive(true);

        descriptionText.text = triangle.DisplayText() + triangle.DefineYourSelf();
    }

    public void ClosePanel()
    {
        panel.SetActive(false);
    }

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
