using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerJump : MonoBehaviour
{
	[SerializeField] private float _jumpForce;

	private Rigidbody _myRigidbody;

	private bool _isGrounded = false;

	protected void Start()
	{
		_myRigidbody = GetComponent<Rigidbody>();
	}

	public void OnJump(InputValue inputValue)
	{
		if (_isGrounded == false)
		{
			return;
		}

		_myRigidbody.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
	}

	protected void Update()
	{
		_isGrounded = Physics.Raycast(transform.position, Vector3.down, transform.localScale.y * 0.6f);
	}
}
