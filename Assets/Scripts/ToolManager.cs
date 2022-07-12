using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class ToolManager : MonoBehaviour
{
    [SerializeField] GameObject toolScreen;
    [SerializeField] GameObject toolsButton;
    Spawner spawner;

    [SerializeField] Slider quantitySlider;
    [SerializeField] TextMeshProUGUI quantityText;

    [SerializeField] Slider rotationSlider;
    [SerializeField] TextMeshProUGUI rotationText;

    bool zoneTL, zoneBL, zoneTR, zoneBR;
    int quantity, rotation;

    private void Awake()
    {
        toolsButton.SetActive(true);
        toolScreen.SetActive(false);
        spawner = FindObjectOfType<Spawner>();
    }
    public void Update()
    {
        UpdateSliders();
    }
    
    //set zone to spawn characters
    public void SetTopLeft()
    {
        zoneTL = !zoneTL;
    }
    public void SetBottomLeft()
    {
        zoneBL = !zoneBL;
    }
    public void SetTopRight()
    {
        zoneTR = !zoneTR;
    }
    public void SetBottomRight()
    {
        zoneBR = !zoneBR;
    }

    // visualizes slider position to text
    void UpdateSliders()
    {
        quantity = (int)quantitySlider.value;
        quantityText.text = quantitySlider.value.ToString();
        rotation = (int)rotationSlider.value;
        rotationText.text = rotationSlider.value.ToString();
    }



    //buttons 
    public void ShowTools()
    {
        toolScreen.SetActive(true);
        toolsButton.SetActive(false);
    }
    public void Apply()
    {
        toolScreen.SetActive(false);
        toolsButton.SetActive(true);
        spawner.Spawn(zoneTL, zoneBL, zoneTR, zoneBR, quantity, rotation);
        
    }
    public void ExitTool()
    {
        toolScreen.SetActive(false);
        toolsButton.SetActive(true);
    }

    public void QuitApp()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif        
    }
}
