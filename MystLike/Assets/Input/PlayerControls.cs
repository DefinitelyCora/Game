// GENERATED AUTOMATICALLY FROM 'Assets/Input/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""View"",
            ""id"": ""0d1800ba-4159-4239-ad1f-13f820bd382d"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6b0cbd30-ac8c-44eb-b424-961127b704d3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ac47f5b8-89f5-43f9-b2dd-75cb88c3603a"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Movement"",
            ""id"": ""29306dae-8072-4efe-8b4f-d730b7f9a2db"",
            ""actions"": [
                {
                    ""name"": ""Foward"",
                    ""type"": ""Button"",
                    ""id"": ""17d3c870-7a5a-485c-95a6-1142dcb07b6b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""610cddde-0a18-4dfc-9cde-305698bf287a"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Foward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Actions"",
            ""id"": ""549033fe-53b2-446b-bc60-55f7d4b88bd3"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""672637a5-ea0f-4a86-af6a-972b946de300"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""958f29a1-4b90-4f58-8400-92a6977c6e55"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // View
        m_View = asset.FindActionMap("View", throwIfNotFound: true);
        m_View_Look = m_View.FindAction("Look", throwIfNotFound: true);
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Foward = m_Movement.FindAction("Foward", throwIfNotFound: true);
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_Newaction = m_Actions.FindAction("New action", throwIfNotFound: true);
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

    // View
    private readonly InputActionMap m_View;
    private IViewActions m_ViewActionsCallbackInterface;
    private readonly InputAction m_View_Look;
    public struct ViewActions
    {
        private @PlayerControls m_Wrapper;
        public ViewActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Look => m_Wrapper.m_View_Look;
        public InputActionMap Get() { return m_Wrapper.m_View; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ViewActions set) { return set.Get(); }
        public void SetCallbacks(IViewActions instance)
        {
            if (m_Wrapper.m_ViewActionsCallbackInterface != null)
            {
                @Look.started -= m_Wrapper.m_ViewActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ViewActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ViewActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_ViewActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public ViewActions @View => new ViewActions(this);

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Foward;
    public struct MovementActions
    {
        private @PlayerControls m_Wrapper;
        public MovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Foward => m_Wrapper.m_Movement_Foward;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Foward.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnFoward;
                @Foward.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnFoward;
                @Foward.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnFoward;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Foward.started += instance.OnFoward;
                @Foward.performed += instance.OnFoward;
                @Foward.canceled += instance.OnFoward;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

    // Actions
    private readonly InputActionMap m_Actions;
    private IActionsActions m_ActionsActionsCallbackInterface;
    private readonly InputAction m_Actions_Newaction;
    public struct ActionsActions
    {
        private @PlayerControls m_Wrapper;
        public ActionsActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_Actions_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void SetCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterface != null)
            {
                @Newaction.started -= m_Wrapper.m_ActionsActionsCallbackInterface.OnNewaction;
                @Newaction.performed -= m_Wrapper.m_ActionsActionsCallbackInterface.OnNewaction;
                @Newaction.canceled -= m_Wrapper.m_ActionsActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_ActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);
    public interface IViewActions
    {
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IMovementActions
    {
        void OnFoward(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
