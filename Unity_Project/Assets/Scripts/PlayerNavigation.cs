using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerNavigation : MonoBehaviour
{
	[SerializeField]
	private float _speed = 3f;

	[Header("References")]
	public Transform mainCamera = null;

	public void Move(InputAction.CallbackContext context)
	{
		Vector2 movement = context.ReadValue<Vector2>() * _speed * Time.deltaTime;
		transform.position += mainCamera.forward * movement.y + mainCamera.right * movement.x;
	}
}
