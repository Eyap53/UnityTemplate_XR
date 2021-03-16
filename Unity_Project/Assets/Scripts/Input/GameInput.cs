// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @GameInput : IInputActionCollection, IDisposable
{
	public InputActionAsset asset { get; }
	public @GameInput()
	{
		asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""4259bf5e-e4d8-4f45-8cca-c0f60e07a85c"",
            ""actions"": [
                {
                    ""name"": ""Navigation"",
                    ""type"": ""Value"",
                    ""id"": ""78ca1a96-5b0c-4984-9026-f0166ef4210c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4c071fdd-5697-4222-9822-89733449f50a"",
                    ""path"": ""<XRController>{LeftHand}/joystick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR-Setup"",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57891de9-77ca-4b9a-8ff0-ed3a445b4e60"",
                    ""path"": ""<XRController>{LeftHand}/touchpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR-Setup"",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfb2a34e-5cb7-454b-8755-6a2e034b826b"",
                    ""path"": ""<XRController>{LeftHand}/trackpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR-Setup"",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6302767e-9a8b-4aa3-8f7e-42afd8d98f75"",
                    ""path"": ""<XRController>{LeftHand}/thumbstick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""VR-Setup"",
                    ""action"": ""Navigation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""VR-Setup"",
            ""bindingGroup"": ""VR-Setup"",
            ""devices"": [
                {
                    ""devicePath"": ""<XRHMD>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{LeftHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XRController>{RightHand}"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
		// Gameplay
		m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
		m_Gameplay_Navigation = m_Gameplay.FindAction("Navigation", throwIfNotFound: true);
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

	// Gameplay
	private readonly InputActionMap m_Gameplay;
	private IGameplayActions m_GameplayActionsCallbackInterface;
	private readonly InputAction m_Gameplay_Navigation;
	public struct GameplayActions
	{
		private @GameInput m_Wrapper;
		public GameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
		public InputAction @Navigation => m_Wrapper.m_Gameplay_Navigation;
		public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
		public void Enable() { Get().Enable(); }
		public void Disable() { Get().Disable(); }
		public bool enabled => Get().enabled;
		public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
		public void SetCallbacks(IGameplayActions instance)
		{
			if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
			{
				@Navigation.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNavigation;
				@Navigation.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNavigation;
				@Navigation.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnNavigation;
			}
			m_Wrapper.m_GameplayActionsCallbackInterface = instance;
			if (instance != null)
			{
				@Navigation.started += instance.OnNavigation;
				@Navigation.performed += instance.OnNavigation;
				@Navigation.canceled += instance.OnNavigation;
			}
		}
	}
	public GameplayActions @Gameplay => new GameplayActions(this);
	private int m_VRSetupSchemeIndex = -1;
	public InputControlScheme VRSetupScheme
	{
		get
		{
			if (m_VRSetupSchemeIndex == -1)
				m_VRSetupSchemeIndex = asset.FindControlSchemeIndex("VR-Setup");
			return asset.controlSchemes[m_VRSetupSchemeIndex];
		}
	}
	public interface IGameplayActions
	{
		void OnNavigation(InputAction.CallbackContext context);
	}
}
