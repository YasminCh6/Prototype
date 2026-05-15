using UnityEngine;
using UnityEngine.InputSystem;

public class ModeControls : MonoBehaviour
{
    public LayerMask normalLayer;
    public LayerMask mindLayer;
    
    private Camera mainCamera;

    public static bool IsMindLayer = false;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCamera = Camera.main; // Make sure the Player Camera is tagged as the main camera

        // Easier to start with a function
        SetMindLayerVisible(false);
    }

    // Update is called once per frame
    void Update()
    {
        // Consider changing this to the space bar?
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            ToggleMindLayer();
        }
    }

    // Swaps between layers
    private void ToggleMindLayer()
    {
        SetMindLayerVisible(!IsMindLayer);
    }

    // Toggles the layer's visibility based on a boolean  
    private void SetMindLayerVisible(bool isVisible)
    {
        if (isVisible)
        {
            mainCamera.cullingMask &= ~normalLayer;
            mainCamera.cullingMask |= mindLayer;
        }
        else
        {
            mainCamera.cullingMask |= normalLayer;
            mainCamera.cullingMask &= ~mindLayer;
        }

        IsMindLayer = isVisible;
    }
}
