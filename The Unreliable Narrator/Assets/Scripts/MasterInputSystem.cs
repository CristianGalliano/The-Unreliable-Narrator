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
                    ""id"": ""0030af89-83f0-43a2-976b-2f3b8f540822"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""f301445b-a070-4d32-af46-b7f55b1f4f92"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""wasdKeys"",
                    ""id"": ""978b8898-c31c-4805-ae3c-6e536dcbd295"",
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
                    ""id"": ""5337d585-0579-464b-a607-27c37766663d"",
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
                    ""id"": ""cdca6a11-3075-422d-b9c0-0e0b729a9803"",
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
                    ""id"": ""dbc5b6cb-d955-411e-a505-2fa87c36eec2"",
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
                    ""id"": ""62d6f46c-6d42-4b00-968a-3f9fe9fd47f2"",
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
                    ""id"": ""c126785e-6bf9-4e11-adb1-10f116df67be"",
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
                    ""id"": ""261e6361-bbd7-4d38-b669-38881f8d5bcd"",
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
                    ""id"": ""6028a643-ed32-4094-9fdd-6ed1c902a615"",
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
                    ""id"": ""6abaf48e-ce1a-4246-a824-0acf0d57c704"",
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
                    ""id"": ""a3078379-895d-4420-a678-673b72b8e197"",
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
                    ""id"": ""7a6bc7c7-65ba-4d37-b2b2-df5b2e2e390b"",
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
                    ""id"": ""408da833-d558-4084-97ec-528bf703b9b5"",
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
                    ""id"": ""f2d53af5-602f-41b3-9170-35ee50117dd0"",
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
                    ""id"": ""ba025bea-85e2-4ac4-a24a-e2242646ce9e"",
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
                    ""id"": ""70a85779-9d05-42e8-8dbd-0ea042b8dab5"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Controller"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""bd717513-a8a9-4f31-9635-8250fa354b61"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6398aac8-3007-441c-9fe7-0b566dfb325d"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Shoot"",
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
                    ""name"": ""wasdKeys"",
                    ""id"": ""78137882-0076-47ed-93db-b1198a9b7baf"",
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
        m_PlayerTopDown_Shoot = m_PlayerTopDown.GetAction("Shoot");
        // PlayerSideScroller
        m_PlayerSideScroller = asset.GetActionMap("PlayerSideScroller");
        m_PlayerSideScroller_Movement = m_PlayerSideScroller.GetAction("Movement");
        m_PlayerSideScroller_Jump = m_PlayerSideScroller.GetAction("Jump");
        // PlayerIsometric
        m_PlayerIsometric = asset.GetActionMap("PlayerIsometric");
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
    private readonly InputAction m_PlayerTopDown_Shoot;
    public struct PlayerTopDownActions
    {
        private MasterInputSystem m_Wrapper;
        public PlayerTopDownActions(MasterInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerTopDown_Movement;
        public InputAction @Shoot => m_Wrapper.m_PlayerTopDown_Shoot;
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
                Shoot.started -= m_Wrapper.m_PlayerTopDownActionsCallbackInterface.OnShoot;
                Shoot.performed -= m_Wrapper.m_PlayerTopDownActionsCallbackInterface.OnShoot;
                Shoot.canceled -= m_Wrapper.m_PlayerTopDownActionsCallbackInterface.OnShoot;
            }
            m_Wrapper.m_PlayerTopDownActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.canceled += instance.OnShoot;
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
    private readonly InputAction m_PlayerIsometric_Movement;
    public struct PlayerIsometricActions
    {
        private MasterInputSystem m_Wrapper;
        public PlayerIsometricActions(MasterInputSystem wrapper) { m_Wrapper = wrapper; }
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
                Movement.started -= m_Wrapper.m_PlayerIsometricActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_PlayerIsometricActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_PlayerIsometricActionsCallbackInterface.OnMovement;
            }
            m_Wrapper.m_PlayerIsometricActionsCallbackInterface = instance;
            if (instance != null)
            {
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
        void OnShoot(InputAction.CallbackContext context);
    }
    public interface IPlayerSideScrollerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IPlayerIsometricActions
    {
        void OnMovement(InputAction.CallbackContext context);
    }
}
