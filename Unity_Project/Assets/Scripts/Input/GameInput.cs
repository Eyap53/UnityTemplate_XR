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
            ""actions"": [],
            ""bindings"": []
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
        },
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
		// Gameplay
		m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
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
	public struct GameplayActions
	{
		private @GameInput m_Wrapper;
		public GameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
		public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
		public void Enable() { Get().Enable(); }
		public void Disable() { Get().Disable(); }
		public bool enabled => Get().enabled;
		public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
		public void SetCallbacks(IGameplayActions instance)
		{
			if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
			{
			}
			m_Wrapper.m_GameplayActionsCallbackInterface = instance;
			if (instance != null)
			{
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
	private int m_KeyboardSchemeIndex = -1;
	public InputControlScheme KeyboardScheme
	{
		get
		{
			if (m_KeyboardSchemeIndex == -1)
				m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
			return asset.controlSchemes[m_KeyboardSchemeIndex];
		}
	}
	public interface IGameplayActions
	{
	}
}
