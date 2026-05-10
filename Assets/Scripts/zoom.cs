using UnityEngine;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] private Camera fpsCamera;
    [SerializeField] private float zoomFOV = 20f;
    [SerializeField] private float defaultFOV = 60f;
    [SerializeField] private float zoomSpeed = 10f;

    void Update()
    {
        // 1 = Right Mouse Button
        if (Input.GetMouseButton(1))
        {
            // Zoom In
            fpsCamera.fieldOfView = Mathf.Lerp(fpsCamera.fieldOfView, zoomFOV, Time.deltaTime * zoomSpeed);
        }
        else
        {
            // Zoom Out
            fpsCamera.fieldOfView = Mathf.Lerp(fpsCamera.fieldOfView, defaultFOV, Time.deltaTime * zoomSpeed);
        }
    }
}
