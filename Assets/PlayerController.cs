using UnityEngine;
using System.Collections;

public class PlayerController
{
	float _baseMoveSpeed = 100.0f;
	float _acceleration = 2000.0f;
	float _moveMult = 2.0f;
	Player _player;

	/// <summary>
	/// Gets the move speed.
	/// </summary>
	/// <value>The move speed.</value>
	public float BaseMoveSpeed
	{
		get { return _baseMoveSpeed; }
	}

	/// <summary>
	/// Gets the move multiplier.
	/// </summary>
	/// <value>The move multiplier.</value>
	public float MoveMult
	{
		get { return _moveMult; }
	}

	/// <summary>
	/// Gets or sets the player.
	/// </summary>
	/// <value>The player.</value>
	public Player Player
	{
		get { return _player; }
		set { _player = value; }
	}

	// Unity awake
	public PlayerController( Player player )
	{
		_player = player;
		Rigidbody rb = _player.gameObject.AddComponent<Rigidbody>();
		rb.useGravity = false;
		rb.drag = 2.5f;
	}

	// Unity fixed update
	public void FixedUpdate()
	{
		Rigidbody rb = _player.GetComponent<Rigidbody>();
		if( rb.velocity.sqrMagnitude <= 10 )
			rb.AddForce( GameInput.MoveInput.normalized * _acceleration * Time.deltaTime );
	}

	// Unity update
	public void Update()
	{
		Vector2 mousePos = GameInput.RotateInput;
		Vector3 worldPos =
			Game.Camera.ScreenToWorldPoint( new Vector3( mousePos.x, mousePos.y,
				Game.Camera.transform.position.y ) );
		Vector3 lookDir =
			new Vector3( worldPos.x, _player.transform.position.y, worldPos.z );
		_player.transform.LookAt( lookDir );
	}

}
