//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
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

public partial class @GaliTaxiInput : IInputActionCollection2, IDisposable
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
                    ""name"": ""Yaw"",
                    ""type"": ""Value"",
                    ""id"": ""a7dfa19c-c90e-41f3-bb10-240ec19a6c9c"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Overdrive"",
                    ""type"": ""Button"",
                    ""id"": ""f39cdf91-9621-4516-b57b-eabc36d7cb1e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlipMode"",
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
                    ""action"": ""Yaw"",
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
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""32cc0e57-8c93-454a-9e14-3b9700d31cb1"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Overdrive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59ce522b-5823-43b0-aba0-49c004af862e"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipMode"",
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
            ""name"": ""Character"",
            ""id"": ""3d836d20-6c8e-4a1a-92bf-fc9eb017938d"",
            ""actions"": [
                {
                    ""name"": ""Walk"",
                    ""type"": ""Value"",
                    ""id"": ""f8504971-04a3-4769-a56e-3d96f2841448"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""9807cd70-650b-4694-bf9e-3dd835336fcb"",
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
                    ""action"": ""Walk"",
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
                    ""action"": ""Walk"",
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
                    ""action"": ""Walk"",
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
                    ""action"": ""Walk"",
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
                    ""action"": ""Walk"",
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
                    ""action"": ""Walk"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fbf75bc6-de55-488d-a948-ef8da25b09cd"",
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
                    ""id"": ""6c940417-0bac-40c2-9da4-1f43351b7379"",
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
        m_Flight_Yaw = m_Flight.FindAction("Yaw", throwIfNotFound: true);
        m_Flight_Overdrive = m_Flight.FindAction("Overdrive", throwIfNotFound: true);
        m_Flight_FlipMode = m_Flight.FindAction("FlipMode", throwIfNotFound: true);
        m_Flight_ArmDisarm = m_Flight.FindAction("Arm/Disarm", throwIfNotFound: true);
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Walk = m_Character.FindAction("Walk", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
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
    private IFlightActions m_FlightActionsCallbackInterface;
    private readonly InputAction m_Flight_MainThrust;
    private readonly InputAction m_Flight_Yaw;
    private readonly InputAction m_Flight_Overdrive;
    private readonly InputAction m_Flight_FlipMode;
    private readonly InputAction m_Flight_ArmDisarm;
    public struct FlightActions
    {
        private @GaliTaxiInput m_Wrapper;
        public FlightActions(@GaliTaxiInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MainThrust => m_Wrapper.m_Flight_MainThrust;
        public InputAction @Yaw => m_Wrapper.m_Flight_Yaw;
        public InputAction @Overdrive => m_Wrapper.m_Flight_Overdrive;
        public InputAction @FlipMode => m_Wrapper.m_Flight_FlipMode;
        public InputAction @ArmDisarm => m_Wrapper.m_Flight_ArmDisarm;
        public InputActionMap Get() { return m_Wrapper.m_Flight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FlightActions set) { return set.Get(); }
        public void SetCallbacks(IFlightActions instance)
        {
            if (m_Wrapper.m_FlightActionsCallbackInterface != null)
            {
                @MainThrust.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnMainThrust;
                @MainThrust.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnMainThrust;
                @MainThrust.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnMainThrust;
                @Yaw.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnYaw;
                @Overdrive.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnOverdrive;
                @Overdrive.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnOverdrive;
                @Overdrive.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnOverdrive;
                @FlipMode.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnFlipMode;
                @FlipMode.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnFlipMode;
                @FlipMode.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnFlipMode;
                @ArmDisarm.started -= m_Wrapper.m_FlightActionsCallbackInterface.OnArmDisarm;
                @ArmDisarm.performed -= m_Wrapper.m_FlightActionsCallbackInterface.OnArmDisarm;
                @ArmDisarm.canceled -= m_Wrapper.m_FlightActionsCallbackInterface.OnArmDisarm;
            }
            m_Wrapper.m_FlightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MainThrust.started += instance.OnMainThrust;
                @MainThrust.performed += instance.OnMainThrust;
                @MainThrust.canceled += instance.OnMainThrust;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
                @Overdrive.started += instance.OnOverdrive;
                @Overdrive.performed += instance.OnOverdrive;
                @Overdrive.canceled += instance.OnOverdrive;
                @FlipMode.started += instance.OnFlipMode;
                @FlipMode.performed += instance.OnFlipMode;
                @FlipMode.canceled += instance.OnFlipMode;
                @ArmDisarm.started += instance.OnArmDisarm;
                @ArmDisarm.performed += instance.OnArmDisarm;
                @ArmDisarm.canceled += instance.OnArmDisarm;
            }
        }
    }
    public FlightActions @Flight => new FlightActions(this);

    // Character
    private readonly InputActionMap m_Character;
    private ICharacterActions m_CharacterActionsCallbackInterface;
    private readonly InputAction m_Character_Walk;
    private readonly InputAction m_Character_Jump;
    public struct CharacterActions
    {
        private @GaliTaxiInput m_Wrapper;
        public CharacterActions(@GaliTaxiInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walk => m_Wrapper.m_Character_Walk;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterface != null)
            {
                @Walk.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnWalk;
                @Walk.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnWalk;
                @Walk.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnWalk;
                @Jump.started -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_CharacterActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Walk.started += instance.OnWalk;
                @Walk.performed += instance.OnWalk;
                @Walk.canceled += instance.OnWalk;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public CharacterActions @Character => new CharacterActions(this);
    public interface IFlightActions
    {
        void OnMainThrust(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnOverdrive(InputAction.CallbackContext context);
        void OnFlipMode(InputAction.CallbackContext context);
        void OnArmDisarm(InputAction.CallbackContext context);
    }
    public interface ICharacterActions
    {
        void OnWalk(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
