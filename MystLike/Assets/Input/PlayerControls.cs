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
            ""name"": ""Movement"",
            ""id"": ""6f2fbf30-4f91-4b25-98d5-ffc2ebacc86d"",
            ""actions"": [
                {
                    ""name"": ""Foward"",
                    ""type"": ""Button"",
                    ""id"": ""ebfa5d3e-4d67-4cfc-b2c9-88204cff51d2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""Button"",
                    ""id"": ""13792136-b0fc-4dbb-9e31-0505f63c8236"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""ac4a2743-076b-46ea-b563-be03843d0110"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""63cdae5d-13d3-4087-b5b6-e588a7ef6f3e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=2)""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""be470602-1e31-4d21-8681-7aeba6476c84"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Foward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6900a53c-3521-4385-b1ca-4f4712332371"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4e73f0c-5790-4965-818a-c07b9da38666"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""50862d31-2a54-4201-b78e-58d442fe8a12"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""View"",
            ""id"": ""6cbeab6b-6929-4380-ae48-44f6ff82bcd5"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bb80882a-0b30-4e2b-8d90-4170b854b079"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2cc679f6-f58f-42d6-bd82-194803be5bd2"",
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
            ""name"": ""Actions"",
            ""id"": ""c69e9d31-9473-416d-934b-aca9f23780e7"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""726c5b15-5191-4238-af34-e7938ce8b2ac"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dff0c5e0-4ad7-4e33-9d81-cf793dea8518"",
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
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Foward = m_Movement.FindAction("Foward", throwIfNotFound: true);
        m_Movement_Back = m_Movement.FindAction("Back", throwIfNotFound: true);
        m_Movement_Left = m_Movement.FindAction("Left", throwIfNotFound: true);
        m_Movement_Right = m_Movement.FindAction("Right", throwIfNotFound: true);
        // View
        m_View = asset.FindActionMap("View", throwIfNotFound: true);
        m_View_Look = m_View.FindAction("Look", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Foward;
    private readonly InputAction m_Movement_Back;
    private readonly InputAction m_Movement_Left;
    private readonly InputAction m_Movement_Right;
    public struct MovementActions
    {
        private @PlayerControls m_Wrapper;
        public MovementActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Foward => m_Wrapper.m_Movement_Foward;
        public InputAction @Back => m_Wrapper.m_Movement_Back;
        public InputAction @Left => m_Wrapper.m_Movement_Left;
        public InputAction @Right => m_Wrapper.m_Movement_Right;
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
                @Back.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnBack;
                @Left.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnRight;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Foward.started += instance.OnFoward;
                @Foward.performed += instance.OnFoward;
                @Foward.canceled += instance.OnFoward;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);

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
    public interface IMovementActions
    {
        void OnFoward(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
    }
    public interface IViewActions
    {
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IActionsActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
