// GENERATED AUTOMATICALLY FROM 'Assets/InputSystem/MasterInputSystem.inputactions'

using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class MasterInputSystem : IInputActionCollection
{
    private InputActionAsset asset;
    public MasterInputSystem()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MasterInputSystem"",
    ""maps"": [
        {
            ""name"": ""PlayerTopDown"",
            ""id"": ""779b2dd0-051f-4ccc-9958-a54c57f5a9fb"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""759497a6-b8d8-4b18-9462-cad3c12ef73e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""89c1c4c7-a759-4a15-81cd-d1d50b6e0afc"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3932ffd-c731-4d89-a2cd-2eb14375dbe0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a926adb7-9f6d-4a4f-9991-22cf0b8322b3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""498a88ea-cafa-4761-aefe-69fbaecf6b35"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a39ea5b-0d4d-4203-9603-6201c3ae4c84"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2277d3a6-95b0-4482-a9d2-0766e578e6b6"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1473ad6-79c8-46a6-aedf-afae33ae0e0b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ca7416d1-7844-4710-9a41-27b3e3704311"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f36b768-7a0d-45f2-91f6-a3ee6cbaa014"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""141d1e3d-8538-424d-8ba2-001a5588c06d"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3b9aaab-f764-48f2-8ad9-ccb3ed2079a7"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ffa2904-427e-4802-a5e5-1d70dc142e4c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerSideScroller"",
            ""id"": ""0ecc1a61-e1f8-4779-93fb-4031a7d3935c"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""c6ebdf70-a3b2-4c0f-8a16-0489caf285f6"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""7771d941-4606-48f3-8d47-0bad5b928655"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""adKeys"",
                    ""id"": ""e6037b41-a400-4e7c-a6d6-c272d00a01a1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f19b7513-9092-42cb-b2c9-7ef59333bf32"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""728c483b-f843-45fc-b534-576be66a1f26"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Left Thumbstick"",
                    ""id"": ""fba7e1ac-42e8-4c2c-b391-52d9582d6557"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""72c7883e-976d-4e9d-aefe-6e95b7ef21fb"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.5)"",
                    ""groups"": "";Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""df7841d9-1d06-4635-b79a-f3afb0d4222b"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.5)"",
                    ""groups"": "";Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""a4fa270d-1d3f-455c-abee-8b7e89812f38"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6669c606-6625-4496-ba51-8d67129eda46"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a7bb7e9b-db18-42ac-b316-9e2327a6967c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""682eaf82-d29a-4296-b7b2-a2cdfc80eb42"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7cae5534-b054-4fd4-9ae9-362bebde95d2"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerIsometric"",
            ""id"": ""8ddc5321-f6ff-4e4a-89eb-903545ad8cd2"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""453b1d36-b992-4a59-8bca-2bb133e0c9ae"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""da2beb0a-168c-429c-b384-1f1015980786"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""31662601-6141-40a9-b67a-73220311211b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""wasdKeys"",
                    ""id"": ""78137882-0076-47ed-93db-b1198a9b7baf"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""b4aa5125-cef7-4aae-94fc-fa6279cbd30f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1eb9ba60-6fd7-4387-ba9e-53a6cfe3e9df"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6f3363a4-0064-4507-89c1-9b7de973a3e4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""4992f1ff-b202-4f74-95b1-2fc5d48f6da2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Dpad"",
                    ""id"": ""ff13240f-2d0d-4a2b-92de-8121851730de"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""5f475234-b30e-4582-b666-235c11af627b"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""96c228a8-5f7c-4eb1-b3f2-3197a2357ef3"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b91434d6-0cd4-4469-afd1-72640b1473ed"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""aa678976-a049-48be-8d91-55c41874bc4a"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""LeftThumbstick"",
                    ""id"": ""074cc03a-a6ba-474e-a43d-4ec977fe9097"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7d979ad2-feb7-4fbe-a713-a6fbc4f5a4a3"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f8d16e75-ae00-43b1-9408-e0dd967a3f57"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f4b2e028-721d-434e-967f-fc0960a0751a"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""94eda48a-05ca-4c58-b8ee-17c7604687ce"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""basedOn"": """",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Controller"",
            ""basedOn"": """",
            ""bindingGroup"": ""Controller"",
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
        // PlayerTopDown
        m_PlayerTopDown = asset.GetActionMap("PlayerTopDown");
        m_PlayerTopDown_Movement = m_PlayerTopDown.GetAction("Movement");
        // PlayerSideScroller
        m_PlayerSideScroller = asset.GetActionMap("PlayerSideScroller");
        m_PlayerSideScroller_Movement = m_PlayerSideScroller.GetAction("Movement");
        m_PlayerSideScroller_Jump = m_PlayerSideScroller.GetAction("Jump");
        // PlayerIsometric
        m_PlayerIsometric = asset.GetActionMap("PlayerIsometric");
        m_PlayerIsometric_Newaction = m_PlayerIsometric.GetAction("New action");
        m_PlayerIsometric_Movement = m_PlayerIsometric.GetAction("Movement");
    }

    ~MasterInputSystem()
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

    // PlayerTopDown
    private readonly InputActionMap m_PlayerTopDown;
    private IPlayerTopDownActions m_PlayerTopDownActionsCallbackInterface;
    private readonly InputAction m_PlayerTopDown_Movement;
    public struct PlayerTopDownActions
    {
        private MasterInputSystem m_Wrapper;
        public PlayerTopDownActions(MasterInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerTopDown_Movement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerTopDown; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerTopDownActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerTopDownActions instance)
        {
            if (m_Wrapper.m_PlayerTopDownActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_PlayerTopDownActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_PlayerTopDownActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_PlayerTopDownActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerTopDownActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerTopDownActions @PlayerTopDown => new PlayerTopDownActions(this);

    // PlayerSideScroller
    private readonly InputActionMap m_PlayerSideScroller;
    private IPlayerSideScrollerActions m_PlayerSideScrollerActionsCallbackInterface;
    private readonly InputAction m_PlayerSideScroller_Movement;
    private readonly InputAction m_PlayerSideScroller_Jump;
    public struct PlayerSideScrollerActions
    {
        private MasterInputSystem m_Wrapper;
        public PlayerSideScrollerActions(MasterInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerSideScroller_Movement;
        public InputAction @Jump => m_Wrapper.m_PlayerSideScroller_Jump;
        public InputActionMap Get() { return m_Wrapper.m_PlayerSideScroller; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerSideScrollerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerSideScrollerActions instance)
        {
            if (m_Wrapper.m_PlayerSideScrollerActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_PlayerSideScrollerActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_PlayerSideScrollerActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_PlayerSideScrollerActionsCallbackInterface.OnMovement;
                Jump.started -= m_Wrapper.m_PlayerSideScrollerActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_PlayerSideScrollerActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_PlayerSideScrollerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerSideScrollerActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerSideScrollerActions @PlayerSideScroller => new PlayerSideScrollerActions(this);

    // PlayerIsometric
    private readonly InputActionMap m_PlayerIsometric;
    private IPlayerIsometricActions m_PlayerIsometricActionsCallbackInterface;
    private readonly InputAction m_PlayerIsometric_Newaction;
    private readonly InputAction m_PlayerIsometric_Movement;
    public struct PlayerIsometricActions
    {
        private MasterInputSystem m_Wrapper;
        public PlayerIsometricActions(MasterInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_PlayerIsometric_Newaction;
        public InputAction @Movement => m_Wrapper.m_PlayerIsometric_Movement;
        public InputActionMap Get() { return m_Wrapper.m_PlayerIsometric; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerIsometricActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerIsometricActions instance)
        {
            if (m_Wrapper.m_PlayerIsometricActionsCallbackInterface != null)
            {
                Newaction.started -= m_Wrapper.m_PlayerIsometricActionsCallbackInterface.OnNewaction;
                Newaction.performed -= m_Wrapper.m_PlayerIsometricActionsCallbackInterface.OnNewaction;
                Newaction.canceled -= m_Wrapper.m_PlayerIsometricActionsCallbackInterface.OnNewaction;
                Movement.started -= m_Wrapper.m_PlayerIsometricActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_PlayerIsometricActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_PlayerIsometricActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerIsometricActionsCallbackInterface = instance;
            if (instance != null)
            {
                Newaction.started += instance.OnNewaction;
                Newaction.performed += instance.OnNewaction;
                Newaction.canceled += instance.OnNewaction;
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
            }
        }
    }
    public PlayerIsometricActions @PlayerIsometric => new PlayerIsometricActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.GetControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    private int m_ControllerSchemeIndex = -1;
    public InputControlScheme ControllerScheme
    {
        get
        {
            if (m_ControllerSchemeIndex == -1) m_ControllerSchemeIndex = asset.GetControlSchemeIndex("Controller");
            return asset.controlSchemes[m_ControllerSchemeIndex];
        }
    }
    public interface IPlayerTopDownActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
    public interface IPlayerSideScrollerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IPlayerIsometricActions
    {
        void OnNewaction(InputAction.CallbackContext context);
        void OnMovement(InputAction.CallbackContext context);
    }
}
