using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Hammer : MonoBehaviour
{
    private Camera mainCamera;

    [SerializeField] private GameObject hammer;
    [SerializeField] private float swingSpeed = 5f;
    private PlayerInputActions inputActions;
    private Vector3 originalPos;
    private Vector3 hitPos;
    private Quaternion originalRot;
    private bool swinging = false;
    private bool returnHome = false;


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        inputActions = new PlayerInputActions();
        inputActions.Player.Disable();
        inputActions.FirstPersonCamera.Enable();
        inputActions.FirstPersonCamera.Fire.performed += SwingHammer;
        originalPos = hammer.transform.position;
        originalRot = hammer.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (swinging)
        {
            if (!returnHome)
            {
                hammer.transform.position = Vector3.Lerp(hammer.transform.position, hitPos, swingSpeed * Time.deltaTime);
                hammer.transform.rotation = Quaternion.Slerp(hammer.transform.rotation, 
                    Quaternion.Euler(90f, hammer.transform.rotation.y, hammer.transform.rotation.z), swingSpeed * Time.deltaTime);
            }
            else
            {
                hammer.transform.position = Vector3.Lerp(hammer.transform.position, originalPos, swingSpeed * Time.deltaTime);
                hammer.transform.rotation = Quaternion.Slerp(hammer.transform.rotation, originalRot, swingSpeed * Time.deltaTime);
            }

            if (Vector3.Distance(hammer.transform.position, hitPos) <= .1f && !returnHome)
            {                
                returnHome = true;
            }

            if (Vector3.Distance(hammer.transform.position, originalPos) <= .1f && returnHome)
            {                
                returnHome = false;
                swinging = false;
            }
        }
    }

    void SwingHammer(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Swing");

            Ray ray = mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());
            if (Physics.Raycast(ray, out RaycastHit hit, 10000f))
            {
                hitPos = hit.point;
                swinging = true;
                Debug.Log(hit.point);
            }
            else
            {
                Debug.Log("We didn't hit anything");
            }
        }
    }
}
