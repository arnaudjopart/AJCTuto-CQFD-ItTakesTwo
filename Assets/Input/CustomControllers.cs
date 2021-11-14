// GENERATED AUTOMATICALLY FROM 'Assets/Input/CustomControllers.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace InputController
{
    public class @CustomControllers : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @CustomControllers()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""CustomControllers"",
    ""maps"": [
        {
            ""name"": ""Mouvement"",
            ""id"": ""d49d865e-7ff3-4f6b-a26a-a9850a943bb6"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""fc321318-a9b8-48e6-b5e1-255648507eb3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e2d496a7-2490-4af3-ae8b-873a888883a3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SwitchToAim"",
                    ""type"": ""Button"",
                    ""id"": ""2d2e63e0-dde6-428a-83e8-93e31e925b2b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AimingX"",
                    ""type"": ""Value"",
                    ""id"": ""9ea06ec2-42f7-49ab-babe-8751e09c5d6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AimingZ"",
                    ""type"": ""Button"",
                    ""id"": ""61fd8ecb-46eb-47b2-96f4-04170698f621"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""42af3f3d-7091-48ae-9c94-e6acb718e688"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd45dc41-8de6-4d56-93f1-bf9a524324e1"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""e7914039-e406-4af7-a5fe-bfc4ac9d059c"",
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
                    ""id"": ""81d03669-d6e6-460e-a079-8dc6b53ccf67"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2539d4f6-63dd-4b4e-9ce0-1d87730b1fa5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6915b62c-a3be-4ef0-b3d0-352e8c36ede3"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d10dbd14-63fc-410e-a997-39f790a01d1d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""28af53e4-0361-44ae-b636-af9adbc441ae"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46ff7b78-eb95-4e90-b02c-e0433ee05b83"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse"",
                    ""action"": ""SwitchToAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29bec242-4927-48c0-ab4d-330419ae4994"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SwitchToAim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""c5f7d970-e231-4f34-8fdb-ab5844998fd0"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""de603e10-5906-4971-8562-88ab31323d34"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""8a644033-f0c9-4764-b5cc-98d4be5bc92c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""1f1a392a-ed9e-47ab-9e49-6f3318e0e36f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingX"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4471311c-5964-4b72-898e-3814fda6e39d"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""50595f76-2e32-4099-bad7-e953f38e6e98"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""80f24674-b9c6-4ec1-b0e0-ac3e8da7dd0e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9ccdee22-9dc7-47d5-a2d9-cdc3a1863781"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bd413fda-94dd-439b-9b5e-dca4abb38db2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""cc3232c6-1305-4745-a7a1-6109eb769d95"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingZ"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""ddb502a5-85c4-4a8e-b3a2-8acbc11364ce"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c9b5e330-7eb1-4a06-bfe3-098b712639b7"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""AimingZ"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard&Mouse"",
            ""bindingGroup"": ""Keyboard&Mouse"",
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
            // Mouvement
            m_Mouvement = asset.FindActionMap("Mouvement", throwIfNotFound: true);
            m_Mouvement_Look = m_Mouvement.FindAction("Look", throwIfNotFound: true);
            m_Mouvement_Move = m_Mouvement.FindAction("Move", throwIfNotFound: true);
            m_Mouvement_SwitchToAim = m_Mouvement.FindAction("SwitchToAim", throwIfNotFound: true);
            m_Mouvement_AimingX = m_Mouvement.FindAction("AimingX", throwIfNotFound: true);
            m_Mouvement_AimingZ = m_Mouvement.FindAction("AimingZ", throwIfNotFound: true);
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

        // Mouvement
        private readonly InputActionMap m_Mouvement;
        private IMouvementActions m_MouvementActionsCallbackInterface;
        private readonly InputAction m_Mouvement_Look;
        private readonly InputAction m_Mouvement_Move;
        private readonly InputAction m_Mouvement_SwitchToAim;
        private readonly InputAction m_Mouvement_AimingX;
        private readonly InputAction m_Mouvement_AimingZ;
        public struct MouvementActions
        {
            private @CustomControllers m_Wrapper;
            public MouvementActions(@CustomControllers wrapper) { m_Wrapper = wrapper; }
            public InputAction @Look => m_Wrapper.m_Mouvement_Look;
            public InputAction @Move => m_Wrapper.m_Mouvement_Move;
            public InputAction @SwitchToAim => m_Wrapper.m_Mouvement_SwitchToAim;
            public InputAction @AimingX => m_Wrapper.m_Mouvement_AimingX;
            public InputAction @AimingZ => m_Wrapper.m_Mouvement_AimingZ;
            public InputActionMap Get() { return m_Wrapper.m_Mouvement; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MouvementActions set) { return set.Get(); }
            public void SetCallbacks(IMouvementActions instance)
            {
                if (m_Wrapper.m_MouvementActionsCallbackInterface != null)
                {
                    @Look.started -= m_Wrapper.m_MouvementActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_MouvementActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_MouvementActionsCallbackInterface.OnLook;
                    @Move.started -= m_Wrapper.m_MouvementActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_MouvementActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_MouvementActionsCallbackInterface.OnMove;
                    @SwitchToAim.started -= m_Wrapper.m_MouvementActionsCallbackInterface.OnSwitchToAim;
                    @SwitchToAim.performed -= m_Wrapper.m_MouvementActionsCallbackInterface.OnSwitchToAim;
                    @SwitchToAim.canceled -= m_Wrapper.m_MouvementActionsCallbackInterface.OnSwitchToAim;
                    @AimingX.started -= m_Wrapper.m_MouvementActionsCallbackInterface.OnAimingX;
                    @AimingX.performed -= m_Wrapper.m_MouvementActionsCallbackInterface.OnAimingX;
                    @AimingX.canceled -= m_Wrapper.m_MouvementActionsCallbackInterface.OnAimingX;
                    @AimingZ.started -= m_Wrapper.m_MouvementActionsCallbackInterface.OnAimingZ;
                    @AimingZ.performed -= m_Wrapper.m_MouvementActionsCallbackInterface.OnAimingZ;
                    @AimingZ.canceled -= m_Wrapper.m_MouvementActionsCallbackInterface.OnAimingZ;
                }
                m_Wrapper.m_MouvementActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @SwitchToAim.started += instance.OnSwitchToAim;
                    @SwitchToAim.performed += instance.OnSwitchToAim;
                    @SwitchToAim.canceled += instance.OnSwitchToAim;
                    @AimingX.started += instance.OnAimingX;
                    @AimingX.performed += instance.OnAimingX;
                    @AimingX.canceled += instance.OnAimingX;
                    @AimingZ.started += instance.OnAimingZ;
                    @AimingZ.performed += instance.OnAimingZ;
                    @AimingZ.canceled += instance.OnAimingZ;
                }
            }
        }
        public MouvementActions @Mouvement => new MouvementActions(this);
        private int m_KeyboardMouseSchemeIndex = -1;
        public InputControlScheme KeyboardMouseScheme
        {
            get
            {
                if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard&Mouse");
                return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
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
        public interface IMouvementActions
        {
            void OnLook(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnSwitchToAim(InputAction.CallbackContext context);
            void OnAimingX(InputAction.CallbackContext context);
            void OnAimingZ(InputAction.CallbackContext context);
        }
    }
}
