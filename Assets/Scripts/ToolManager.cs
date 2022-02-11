using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToolManager : MonoBehaviour
{
    [SerializeField] GameObject toolScreen;
    [SerializeField] GameObject toolsButton;

    [SerializeField] Slider quantitySlider;
    [SerializeField] TextMeshProUGUI quantityText;

    [SerializeField] Slider rotationSlider;
    [SerializeField] TextMeshProUGUI rotationText;

    bool zoneTL, zoneBL, zoneTR, zoneBR;

    private void Awake()
    {
        toolsButton.SetActive(true);
        toolScreen.SetActive(false);
    }
    public void Update()
    {
        UpdateSliders();
    }
    
    //set zone to spawn characters
    public void SetTopLeft()
    {
        zoneTL = true;
    }
    public void SetBottomLeft()
    {
        zoneBL = true;
    }
    public void SetTopRight()
    {
        zoneTR = true;
    }
    public void SetBottomRight()
    {
        zoneBR = true;
    }
    // visualizes slider position to text
    void UpdateSliders()
    {
        quantityText.text = quantitySlider.value.ToString();
        rotationText.text = rotationSlider.value.ToString();
    }
    public void ShowTools()
    {
        toolScreen.SetActive(true);
        toolsButton.SetActive(false);
    }
    public void Apply()
    {
        toolScreen.SetActive(false);
        toolsButton.SetActive(true);
    }
    public void ExitTool()
    {
        toolScreen.SetActive(false);
        toolsButton.SetActive(true);
    }
}
