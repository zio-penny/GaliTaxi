//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.3
//     from Assets/Controls/GaliTaxiInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @GaliTaxiInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @GaliTaxiInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""GaliTaxiInput"",
    ""maps"": [
        {
            ""name"": ""Flight"",
            ""id"": ""21129996-e43c-46c1-a9da-eb33ebb3df6c"",
            ""actions"": [
                {
                    ""name"": ""MainThrust"",
                    ""type"": ""Value"",
                    ""id"": ""bf78e3ae-df77-4aa1-9364-24dcd7c7b4db"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Strafe"",
                    ""type"": ""Value"",
                    ""id"": ""a7dfa19c-c90e-41f3-bb10-240ec19a6c9c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Toggle Struts"",
                    ""type"": ""Button"",
                    ""id"": ""cadc1725-b3fb-4465-9220-c5812531a114"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Arm/Disarm"",
                    ""type"": ""Button"",
                    ""id"": ""04e5a412-4a52-46cc-92d6-3f991b26083b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""75caba3e-b937-4e59-a879-ba2a484a5d42"",
                    ""path"": ""<Gamepad>/leftStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MainThrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b6d08e22-4ccf-4fec-b58b-ababa9d84a8f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MainThrust"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f671d7a5-de73-481b-b5bc-71531abebb32"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MainThrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3c9b9d88-7231-40f5-b6f1-2bd5b5e76f96"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MainThrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0f34dfe4-89a9-4d0d-b3dd-f69dbf468165"",
                    ""path"": ""<HID::Thrustmaster TWCS Throttle>/z"",
                    ""interactions"": """",
                    ""processors"": ""Invert"",
                    ""groups"": """",
                    ""action"": ""MainThrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26a0e493-90ac-4e55-9842-fdbf8ed960f0"",
                    ""path"": ""<Gamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""27e146aa-81e7-4bf5-ab56-36246d889e1c"",
                    ""path"": ""<HID::VKB-Sim © Alex Oz 2021  VKBsim Gladiator NXT R  >/rz"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b2754e5a-96ff-4b1d-9d53-9f1d8141cbb6"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""fd0ef1dc-6970-45dc-83b0-d7b7677bd1a8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9bae79df-1dfe-42ef-8176-6c49df4fcb5f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""834c04a8-9843-4976-aa9c-cfff325d99b8"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Toggle Struts"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3f04d1a-154d-4b67-bceb-11383decf0c9"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Arm/Disarm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Humanoid"",
            ""id"": ""3d836d20-6c8e-4a1a-92bf-fc9eb017938d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""f8504971-04a3-4769-a56e-3d96f2841448"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""444a9863-b935-4b4c-b7d7-d218e1195413"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""fb6913bd-3f70-41d5-ba04-605631acf154"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7ce33497-48a2-483a-8dbd-c6f25c58eb8d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f486da69-f8c5-4189-99f5-675f40e2700a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""891a34db-764b-47cf-83ad-87ffa06d237a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""24171679-553d-4c00-92cd-57520f3d680c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f17619a8-107e-4d57-91b3-96f9139c498d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""06a7325c-97fb-46e3-99ac-19bfcac6a084"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d6f2b633-83b7-4e45-adc9-4df7eed3e2f0"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69559379-33b5-4050-9cf9-08af9cad0b4c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0b2b3580-0693-4b6d-9060-f5cb77f3512b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b08ae50-70ee-475f-a684-3317600506f0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Flight
        m_Flight = asset.FindActionMap("Flight", throwIfNotFound: true);
        m_Flight_MainThrust = m_Flight.FindAction("MainThrust", throwIfNotFound: true);
        m_Flight_Strafe = m_Flight.FindAction("Strafe", throwIfNotFound: true);
        m_Flight_ToggleStruts = m_Flight.FindAction("Toggle Struts", throwIfNotFound: true);
        m_Flight_ArmDisarm = m_Flight.FindAction("Arm/Disarm", throwIfNotFound: true);
        // Humanoid
        m_Humanoid = asset.FindActionMap("Humanoid", throwIfNotFound: true);
        m_Humanoid_Move = m_Humanoid.FindAction("Move", throwIfNotFound: true);
        m_Humanoid_Interact = m_Humanoid.FindAction("Interact", throwIfNotFound: true);
        m_Humanoid_Jump = m_Humanoid.FindAction("Jump", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Flight
    private readonly InputActionMap m_Flight;
    private List<IFlightActions> m_FlightActionsCallbackInterfaces = new List<IFlightActions>();
    private readonly InputAction m_Flight_MainThrust;
    private readonly InputAction m_Flight_Strafe;
    private readonly InputAction m_Flight_ToggleStruts;
    private readonly InputAction m_Flight_ArmDisarm;
    public struct FlightActions
    {
        private @GaliTaxiInput m_Wrapper;
        public FlightActions(@GaliTaxiInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MainThrust => m_Wrapper.m_Flight_MainThrust;
        public InputAction @Strafe => m_Wrapper.m_Flight_Strafe;
        public InputAction @ToggleStruts => m_Wrapper.m_Flight_ToggleStruts;
        public InputAction @ArmDisarm => m_Wrapper.m_Flight_ArmDisarm;
        public InputActionMap Get() { return m_Wrapper.m_Flight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlightActions set) { return set.Get(); }
        public void AddCallbacks(IFlightActions instance)
        {
            if (instance == null || m_Wrapper.m_FlightActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_FlightActionsCallbackInterfaces.Add(instance);
            @MainThrust.started += instance.OnMainThrust;
            @MainThrust.performed += instance.OnMainThrust;
            @MainThrust.canceled += instance.OnMainThrust;
            @Strafe.started += instance.OnStrafe;
            @Strafe.performed += instance.OnStrafe;
            @Strafe.canceled += instance.OnStrafe;
            @ToggleStruts.started += instance.OnToggleStruts;
            @ToggleStruts.performed += instance.OnToggleStruts;
            @ToggleStruts.canceled += instance.OnToggleStruts;
            @ArmDisarm.started += instance.OnArmDisarm;
            @ArmDisarm.performed += instance.OnArmDisarm;
            @ArmDisarm.canceled += instance.OnArmDisarm;
        }

        private void UnregisterCallbacks(IFlightActions instance)
        {
            @MainThrust.started -= instance.OnMainThrust;
            @MainThrust.performed -= instance.OnMainThrust;
            @MainThrust.canceled -= instance.OnMainThrust;
            @Strafe.started -= instance.OnStrafe;
            @Strafe.performed -= instance.OnStrafe;
            @Strafe.canceled -= instance.OnStrafe;
            @ToggleStruts.started -= instance.OnToggleStruts;
            @ToggleStruts.performed -= instance.OnToggleStruts;
            @ToggleStruts.canceled -= instance.OnToggleStruts;
            @ArmDisarm.started -= instance.OnArmDisarm;
            @ArmDisarm.performed -= instance.OnArmDisarm;
            @ArmDisarm.canceled -= instance.OnArmDisarm;
        }

        public void RemoveCallbacks(IFlightActions instance)
        {
            if (m_Wrapper.m_FlightActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IFlightActions instance)
        {
            foreach (var item in m_Wrapper.m_FlightActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_FlightActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public FlightActions @Flight => new FlightActions(this);

    // Humanoid
    private readonly InputActionMap m_Humanoid;
    private List<IHumanoidActions> m_HumanoidActionsCallbackInterfaces = new List<IHumanoidActions>();
    private readonly InputAction m_Humanoid_Move;
    private readonly InputAction m_Humanoid_Interact;
    private readonly InputAction m_Humanoid_Jump;
    public struct HumanoidActions
    {
        private @GaliTaxiInput m_Wrapper;
        public HumanoidActions(@GaliTaxiInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Humanoid_Move;
        public InputAction @Interact => m_Wrapper.m_Humanoid_Interact;
        public InputAction @Jump => m_Wrapper.m_Humanoid_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Humanoid; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HumanoidActions set) { return set.Get(); }
        public void AddCallbacks(IHumanoidActions instance)
        {
            if (instance == null || m_Wrapper.m_HumanoidActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_HumanoidActionsCallbackInterfaces.Add(instance);
            @Move.started += instance.OnMove;
            @Move.performed += instance.OnMove;
            @Move.canceled += instance.OnMove;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
        }

        private void UnregisterCallbacks(IHumanoidActions instance)
        {
            @Move.started -= instance.OnMove;
            @Move.performed -= instance.OnMove;
            @Move.canceled -= instance.OnMove;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
        }

        public void RemoveCallbacks(IHumanoidActions instance)
        {
            if (m_Wrapper.m_HumanoidActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IHumanoidActions instance)
        {
            foreach (var item in m_Wrapper.m_HumanoidActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_HumanoidActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public HumanoidActions @Humanoid => new HumanoidActions(this);
    public interface IFlightActions
    {
        void OnMainThrust(InputAction.CallbackContext context);
        void OnStrafe(InputAction.CallbackContext context);
        void OnToggleStruts(InputAction.CallbackContext context);
        void OnArmDisarm(InputAction.CallbackContext context);
    }
    public interface IHumanoidActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
