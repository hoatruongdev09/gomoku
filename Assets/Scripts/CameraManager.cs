using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour {
    public Camera MainCamera { get => mainCamera; }
    public Vector3 Position { get => transform.position; set => transform.position = value; }

    [SerializeField] private Camera mainCamera;
}