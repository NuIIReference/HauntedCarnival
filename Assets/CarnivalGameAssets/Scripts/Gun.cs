using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    [SerializeField]
    bool holdToFire = true;

    [SerializeField]
    [Range(.001f, .01f)]
    float inflateSpeed = 0.01f;

    [SerializeField]
    float fireRate = .5f;

    PlayerInputActions inputActions;

    Transform ballonTransform;

    bool targetHit = false;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
        inputActions.Player.Enable();

        if (!holdToFire)
        {
            inputActions.Player.Fire.performed += Fire;
        }
        else
        {
            inputActions.Player.FireHold.started += StartFiring;
            inputActions.Player.FireHold.canceled += StopFiring;
        }
    }

    private void Update()
    {
        if (targetHit)
        {
            ballonTransform.localScale = Vector3.Lerp(ballonTransform.localScale, ballonTransform.localScale + Vector3.one, inflateSpeed);
        }        
    }

    //Used to fire the gun on mouse click
    public void Fire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit hit, 1000f))
            {
                Debug.DrawLine(Camera.main.transform.position, Camera.main.transform.forward * 1000f, Color.red);
                if (hit.collider.CompareTag("Balloon"))
                {
                    Debug.Log("Hit Target");
                    hit.collider.gameObject.SetActive(false);
                }
            }
        }
    }

    //Used to fire the gun continuously
    void HoldToFire()
    {
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit hit, 1000f))
        {
            Debug.DrawLine(Camera.main.transform.position, Camera.main.transform.forward * 1000f, Color.red);
            if (hit.collider.CompareTag("Target"))
            {
                ballonTransform = hit.transform.GetChild(0);
                targetHit = true;
            }
            else
            {
                targetHit = false;
            }
        }
    }

    void StartFiring(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            InvokeRepeating("HoldToFire", 0f, fireRate);
        }        
    }

    void StopFiring(InputAction.CallbackContext context)
    {
        if (context.canceled)
        {
            Debug.Log("Stop Firing");
            CancelInvoke();
            targetHit = false;
        }        
    }
}
