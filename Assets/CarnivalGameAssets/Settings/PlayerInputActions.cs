// GENERATED AUTOMATICALLY FROM 'Assets/CarnivalGameAssets/Settings/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""b94e8955-75fa-4aa4-b076-bb4ff82443e6"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""c288814b-a0a4-42ac-aee3-a2f61e5594df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FireHold"",
                    ""type"": ""Button"",
                    ""id"": ""e79cedcc-45dc-4f82-8b26-e7d0d7de8514"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""68f8daab-3595-4122-8748-1f4485bddd0f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a67ab765-f625-41e8-abf5-73073c18a214"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34ca70ef-55cd-4006-a4e4-7a034e971446"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""FireHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d41b62d-7993-4f97-92dc-697fe107a31f"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""FireHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""FirstPersonCamera"",
            ""id"": ""91717f4e-9c1f-4773-b4f0-57ed751b679e"",
            ""actions"": [
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""12e6c208-71f2-48ab-9884-117a51a1c950"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""067295a9-c682-4e7d-af34-34313ca0bc50"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""749d52df-d6d1-4fff-b8d9-f9d8dfea8bfb"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Fire = m_Player.FindAction("Fire", throwIfNotFound: true);
        m_Player_FireHold = m_Player.FindAction("FireHold", throwIfNotFound: true);
        // FirstPersonCamera
        m_FirstPersonCamera = asset.FindActionMap("FirstPersonCamera", throwIfNotFound: true);
        m_FirstPersonCamera_Fire = m_FirstPersonCamera.FindAction("Fire", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Fire;
    private readonly InputAction m_Player_FireHold;
    public struct PlayerActions
    {
        private @PlayerInputActions m_Wrapper;
        public PlayerActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_Player_Fire;
        public InputAction @FireHold => m_Wrapper.m_Player_FireHold;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFire;
                @FireHold.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireHold;
                @FireHold.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireHold;
                @FireHold.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireHold;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @FireHold.started += instance.OnFireHold;
                @FireHold.performed += instance.OnFireHold;
                @FireHold.canceled += instance.OnFireHold;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // FirstPersonCamera
    private readonly InputActionMap m_FirstPersonCamera;
    private IFirstPersonCameraActions m_FirstPersonCameraActionsCallbackInterface;
    private readonly InputAction m_FirstPersonCamera_Fire;
    public struct FirstPersonCameraActions
    {
        private @PlayerInputActions m_Wrapper;
        public FirstPersonCameraActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Fire => m_Wrapper.m_FirstPersonCamera_Fire;
        public InputActionMap Get() { return m_Wrapper.m_FirstPersonCamera; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FirstPersonCameraActions set) { return set.Get(); }
        public void SetCallbacks(IFirstPersonCameraActions instance)
        {
            if (m_Wrapper.m_FirstPersonCameraActionsCallbackInterface != null)
            {
                @Fire.started -= m_Wrapper.m_FirstPersonCameraActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_FirstPersonCameraActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_FirstPersonCameraActionsCallbackInterface.OnFire;
            }
            m_Wrapper.m_FirstPersonCameraActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
            }
        }
    }
    public FirstPersonCameraActions @FirstPersonCamera => new FirstPersonCameraActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnFire(InputAction.CallbackContext context);
        void OnFireHold(InputAction.CallbackContext context);
    }
    public interface IFirstPersonCameraActions
    {
        void OnFire(InputAction.CallbackContext context);
    }
}
