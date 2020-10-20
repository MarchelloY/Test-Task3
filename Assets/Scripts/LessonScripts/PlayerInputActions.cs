// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using Object = UnityEngine.Object;

public class PlayerInputActions : IInputActionCollection, IDisposable
{
    // Player
    private readonly InputActionMap m_Player;
    private readonly InputAction m_Player_FireAction;
    private readonly InputAction m_Player_Horizontal;
    private readonly InputAction m_Player_MousePos;
    private readonly InputAction m_Player_SkillAction;
    private IPlayerActions m_PlayerActionsCallbackInterface;

    public PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""de43ca36-e2cd-4353-adc4-cfdfc8a92147"",
            ""actions"": [
                {
                    ""name"": ""FireAction"",
                    ""type"": ""Button"",
                    ""id"": ""ec20e427-03da-46bd-ad88-661d5c69f632"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SkillAction"",
                    ""type"": ""Button"",
                    ""id"": ""8fd1c5db-a516-4a29-8168-2dfa7fc7705f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Horizontal"",
                    ""type"": ""Button"",
                    ""id"": ""aa60f257-41b9-4395-9936-0b2f2f0f3928"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePos"",
                    ""type"": ""Value"",
                    ""id"": ""84c74cb1-73d5-4238-a3c5-ec2fb6404ef6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""af8acf16-1664-4f60-af13-fbc605ec1e4a"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FireAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""31743faa-f932-47d1-8ab0-4fb5d437f98b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SkillAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c94d57a3-675a-4e86-a90c-ed0da0977c09"",
                    ""path"": ""1DAxis"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""89596dc3-dce4-4e21-94dd-bbaf072fc604"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ca8383a4-13c5-478e-87dd-bb95c680d7a1"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Horizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fa7d9de7-c891-4967-9ff7-890b449019bb"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePos"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", true);
        m_Player_FireAction = m_Player.FindAction("FireAction", true);
        m_Player_SkillAction = m_Player.FindAction("SkillAction", true);
        m_Player_Horizontal = m_Player.FindAction("Horizontal", true);
        m_Player_MousePos = m_Player.FindAction("MousePos", true);
    }

    public InputActionAsset asset { get; }
    public PlayerActions Player => new PlayerActions(this);

    public void Dispose()
    {
        Object.Destroy(asset);
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

    public struct PlayerActions
    {
        private readonly PlayerInputActions m_Wrapper;

        public PlayerActions(PlayerInputActions wrapper)
        {
            m_Wrapper = wrapper;
        }

        public InputAction FireAction => m_Wrapper.m_Player_FireAction;
        public InputAction SkillAction => m_Wrapper.m_Player_SkillAction;
        public InputAction Horizontal => m_Wrapper.m_Player_Horizontal;
        public InputAction MousePos => m_Wrapper.m_Player_MousePos;

        public InputActionMap Get()
        {
            return m_Wrapper.m_Player;
        }

        public void Enable()
        {
            Get().Enable();
        }

        public void Disable()
        {
            Get().Disable();
        }

        public bool enabled => Get().enabled;

        public static implicit operator InputActionMap(PlayerActions set)
        {
            return set.Get();
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                FireAction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireAction;
                FireAction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireAction;
                FireAction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFireAction;
                SkillAction.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkillAction;
                SkillAction.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkillAction;
                SkillAction.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnSkillAction;
                Horizontal.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                Horizontal.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                Horizontal.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnHorizontal;
                MousePos.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePos;
                MousePos.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePos;
                MousePos.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMousePos;
            }

            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                FireAction.started += instance.OnFireAction;
                FireAction.performed += instance.OnFireAction;
                FireAction.canceled += instance.OnFireAction;
                SkillAction.started += instance.OnSkillAction;
                SkillAction.performed += instance.OnSkillAction;
                SkillAction.canceled += instance.OnSkillAction;
                Horizontal.started += instance.OnHorizontal;
                Horizontal.performed += instance.OnHorizontal;
                Horizontal.canceled += instance.OnHorizontal;
                MousePos.started += instance.OnMousePos;
                MousePos.performed += instance.OnMousePos;
                MousePos.canceled += instance.OnMousePos;
            }
        }
    }

    public interface IPlayerActions
    {
        void OnFireAction(InputAction.CallbackContext context);
        void OnSkillAction(InputAction.CallbackContext context);
        void OnHorizontal(InputAction.CallbackContext context);
        void OnMousePos(InputAction.CallbackContext context);
    }
}