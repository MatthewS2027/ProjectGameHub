using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private Player player;

    // variable to hold mouse dir and mouse world pos
    private Vector2 mouseDir;
    private Vector3 mouseWorldPos;

    //Allow public access to mouse dir
    public Vector2 MouseDir => mouseDir;
    public Vector3 MouseWorldPos => mouseWorldPos;

    //Cache main camera reference

    private Camera cam;
    private void Awake()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseScreen = Input.mousePosition;  // mouseScreen is temp variable to hold mouse pos in screen space
        mouseWorldPos = cam.ScreenToWorldPoint(mouseScreen);    // convert mouse pos to world space
        mouseWorldPos.z = 0f; // 2D game

        mouseDir = (mouseWorldPos - player.transform.position).normalized; // calculate mouse dir
        
    }
}
