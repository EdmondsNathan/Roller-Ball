using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float _speed;

	private Rigidbody _myRigidbody;

	private Vector3 _movementVector;

	protected void Start()
	{
		_myRigidbody = GetComponent<Rigidbody>();
	}

	public void OnMove(InputValue inputValue)
	{
		_movementVector = new Vector3(inputValue.Get<Vector2>().x, 0, inputValue.Get<Vector2>().y);
	}

	protected void FixedUpdate()
	{
		_myRigidbody.AddForce(_movementVector * _speed);
	}
}
