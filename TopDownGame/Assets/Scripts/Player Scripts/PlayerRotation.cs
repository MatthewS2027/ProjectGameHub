using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{

    private Camera mainCamera;

    [SerializeField] private InputManager inputManager;


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rotation = inputManager.MouseDir;

        // Try this with inputManager.MouseDir
        // Atan2 function determines what angle produces the direction (x, y)
        // Rad2Deg converts this answer into degrees
        float rotationZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        // The statement Quaternion.Euler (x, y, z) performs a rotation about each axis in the order z, x, y.
        // Because this is a 2D game rotation about the Z axis is all that is necessary
        transform.rotation = Quaternion.Euler(0, 0, rotationZ);
    }

}
