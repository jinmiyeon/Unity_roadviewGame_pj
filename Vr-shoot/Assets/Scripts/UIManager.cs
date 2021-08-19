using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    // Start is called before the first frame update

    private Button worldSpaceButton;
    [SerializeField]
    private Text worldSpaceText;
    [SerializeField]
    private Button activeScreenSpaceCameraCanvasButton;
    [SerializeField]
    private GameObject screenSpaceCameraCanvas;
    [SerializeField]
    private Button screenSpaceCameraButton;

    void Start()
    {
        worldSpaceButton.onClick.AddListener(() =>
        {
            worldSpaceText.text = "world Space Canvas\nButton Clicked";

        });

        activeScreenSpaceCameraCanvasButton.onClick.AddListener(() =>
            {
                screenSpaceCameraCanvas.SetActive(true);
            });
        screenSpaceCameraButton.onClick.AddListener(() =>
            {
                screenSpaceCameraCanvas.SetActive(false);
            });

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
