using System;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public GameObject prefab;
    public Transform spawnPoint;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnShoot(InputValue value)
    {
        Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }
}
