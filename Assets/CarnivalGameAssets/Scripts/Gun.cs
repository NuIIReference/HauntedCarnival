using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Gun : MonoBehaviour
{
    [SerializeField]
    Transform gunTip;

    private void Awake()
    {
        PlayerInputActions inputActions = new PlayerInputActions();
        inputActions.Player.Enable();
        inputActions.Player.Fire.performed += Fire;
    }

    public void Fire(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Shoot - " + context.phase);

            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit hit, 100f))
            {
                if (hit.collider.CompareTag("Target"))
                {
                    Debug.Log("Hit Target");
                    hit.transform.GetChild(0).localScale += Vector3.one * .5f;
                }
            }
        }
    }
}
