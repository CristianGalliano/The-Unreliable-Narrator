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
            ""name"": ""Player"",
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
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""f301445b-a070-4d32-af46-b7f55b1f4f92"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeapon1"",
                    ""type"": ""Button"",
                    ""id"": ""9f0f8545-1d1f-4a91-9c68-daf68b2afe5b"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeapon2"",
                    ""type"": ""Button"",
                    ""id"": ""9716d0ae-4e5a-4754-a773-95a816cf182a"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeapon3"",
                    ""type"": ""Button"",
                    ""id"": ""9696399d-ae26-4580-9f8e-09c7afe245a5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeaponNext"",
                    ""type"": ""Button"",
                    ""id"": ""44850351-b76b-4cb8-a289-d21aaae33991"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeWeaponPrevious"",
                    ""type"": ""Button"",
                    ""id"": ""ee8fc7b1-308a-46a2-ae2b-ee216f6d4f96"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""384addf2-72ad-4c7e-b619-6dcde9cc581d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ShowTooltips"",
                    ""type"": ""Button"",
                    ""id"": ""7cf5bbc2-0f72-431d-a35d-165cb76d2322"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d9c1694d-9f64-40ab-80d9-7a2c189d53ce"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""adKeys"",
                    ""id"": ""08aeab17-23c1-462c-9882-ba58633385a7"",
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
                    ""id"": ""52b47612-9752-493f-aba1-1be273d40563"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b06e7694-b593-4c64-8102-e012aca4c363"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left Stick"",
                    ""id"": ""22aceaf5-eee5-423b-9bb8-951e5169e30c"",
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
                    ""id"": ""5b2481fa-8e01-4d84-a257-c31d93069975"",
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
                    ""id"": ""d057981a-6b3c-4905-97bf-b8a761e2660c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.5)"",
                    ""groups"": "";Controller"",
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
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6398aac8-3007-441c-9fe7-0b566dfb325d"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f440bf60-4a29-49e1-b560-a5fdb8363f8a"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""ChangeWeapon1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5533abd5-e183-49d0-82b0-e90e1efdd02f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""ChangeWeapon1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""096bb5c2-252b-42b5-a148-2fa66c244a0e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9eb518ce-7ea4-408a-b3fc-0de919cb8142"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7a53ed40-92b4-4b55-b091-6c364c4cc315"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""ShowTooltips"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09f9cb5c-6368-4b9f-a083-026ce76ff040"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""ShowTooltips"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""023fd3df-0b24-443f-83c0-273501b50dac"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""ChangeWeapon2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""801ff918-d7bc-4632-b90c-02520dd860a4"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""ChangeWeapon2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9020fac-b66a-4c49-8e68-737e3e9acda7"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""ChangeWeapon3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""537b703f-91f8-4755-80f7-18fc4d90da6c"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""ChangeWeapon3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd44dd97-800f-433b-a86f-c3ce44821128"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""ChangeWeaponNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8264285-0bfb-4cbd-8ca9-52406dc30cfc"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""ChangeWeaponNext"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99a95565-ac7b-425a-8bdd-48798d951ea5"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Keyboard and Mouse"",
                    ""action"": ""ChangeWeaponPrevious"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f3664b53-a0c5-44a9-8b9f-225c018caeda"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""ChangeWeaponPrevious"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef08d6c1-769a-4e16-a8c7-70a6031ba489"",
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
                    ""id"": ""1e7459ad-c6fa-44d9-9761-c3b301cfa623"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Controller"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        // Player
        m_Player = asset.GetActionMap("Player");
        m_Player_Movement = m_Player.GetAction("Movement");
        m_Player_Attack = m_Player.GetAction("Attack");
        m_Player_ChangeWeapon1 = m_Player.GetAction("ChangeWeapon1");
        m_Player_ChangeWeapon2 = m_Player.GetAction("ChangeWeapon2");
        m_Player_ChangeWeapon3 = m_Player.GetAction("ChangeWeapon3");
        m_Player_ChangeWeaponNext = m_Player.GetAction("ChangeWeaponNext");
        m_Player_ChangeWeaponPrevious = m_Player.GetAction("ChangeWeaponPrevious");
        m_Player_Interact = m_Player.GetAction("Interact");
        m_Player_ShowTooltips = m_Player.GetAction("ShowTooltips");
        m_Player_Jump = m_Player.GetAction("Jump");
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

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Attack;
    private readonly InputAction m_Player_ChangeWeapon1;
    private readonly InputAction m_Player_ChangeWeapon2;
    private readonly InputAction m_Player_ChangeWeapon3;
    private readonly InputAction m_Player_ChangeWeaponNext;
    private readonly InputAction m_Player_ChangeWeaponPrevious;
    private readonly InputAction m_Player_Interact;
    private readonly InputAction m_Player_ShowTooltips;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private MasterInputSystem m_Wrapper;
        public PlayerActions(MasterInputSystem wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Attack => m_Wrapper.m_Player_Attack;
        public InputAction @ChangeWeapon1 => m_Wrapper.m_Player_ChangeWeapon1;
        public InputAction @ChangeWeapon2 => m_Wrapper.m_Player_ChangeWeapon2;
        public InputAction @ChangeWeapon3 => m_Wrapper.m_Player_ChangeWeapon3;
        public InputAction @ChangeWeaponNext => m_Wrapper.m_Player_ChangeWeaponNext;
        public InputAction @ChangeWeaponPrevious => m_Wrapper.m_Player_ChangeWeaponPrevious;
        public InputAction @Interact => m_Wrapper.m_Player_Interact;
        public InputAction @ShowTooltips => m_Wrapper.m_Player_ShowTooltips;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                Attack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                Attack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                Attack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAttack;
                ChangeWeapon1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon1;
                ChangeWeapon1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon1;
                ChangeWeapon1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon1;
                ChangeWeapon2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon2;
                ChangeWeapon2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon2;
                ChangeWeapon2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon2;
                ChangeWeapon3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon3;
                ChangeWeapon3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon3;
                ChangeWeapon3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeapon3;
                ChangeWeaponNext.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeaponNext;
                ChangeWeaponNext.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeaponNext;
                ChangeWeaponNext.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeaponNext;
                ChangeWeaponPrevious.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeaponPrevious;
                ChangeWeaponPrevious.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeaponPrevious;
                ChangeWeaponPrevious.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnChangeWeaponPrevious;
                Interact.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                Interact.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                Interact.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnInteract;
                ShowTooltips.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShowTooltips;
                ShowTooltips.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShowTooltips;
                ShowTooltips.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnShowTooltips;
                Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                Movement.started += instance.OnMovement;
                Movement.performed += instance.OnMovement;
                Movement.canceled += instance.OnMovement;
                Attack.started += instance.OnAttack;
                Attack.performed += instance.OnAttack;
                Attack.canceled += instance.OnAttack;
                ChangeWeapon1.started += instance.OnChangeWeapon1;
                ChangeWeapon1.performed += instance.OnChangeWeapon1;
                ChangeWeapon1.canceled += instance.OnChangeWeapon1;
                ChangeWeapon2.started += instance.OnChangeWeapon2;
                ChangeWeapon2.performed += instance.OnChangeWeapon2;
                ChangeWeapon2.canceled += instance.OnChangeWeapon2;
                ChangeWeapon3.started += instance.OnChangeWeapon3;
                ChangeWeapon3.performed += instance.OnChangeWeapon3;
                ChangeWeapon3.canceled += instance.OnChangeWeapon3;
                ChangeWeaponNext.started += instance.OnChangeWeaponNext;
                ChangeWeaponNext.performed += instance.OnChangeWeaponNext;
                ChangeWeaponNext.canceled += instance.OnChangeWeaponNext;
                ChangeWeaponPrevious.started += instance.OnChangeWeaponPrevious;
                ChangeWeaponPrevious.performed += instance.OnChangeWeaponPrevious;
                ChangeWeaponPrevious.canceled += instance.OnChangeWeaponPrevious;
                Interact.started += instance.OnInteract;
                Interact.performed += instance.OnInteract;
                Interact.canceled += instance.OnInteract;
                ShowTooltips.started += instance.OnShowTooltips;
                ShowTooltips.performed += instance.OnShowTooltips;
                ShowTooltips.canceled += instance.OnShowTooltips;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
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
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnChangeWeapon1(InputAction.CallbackContext context);
        void OnChangeWeapon2(InputAction.CallbackContext context);
        void OnChangeWeapon3(InputAction.CallbackContext context);
        void OnChangeWeaponNext(InputAction.CallbackContext context);
        void OnChangeWeaponPrevious(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnShowTooltips(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
}
