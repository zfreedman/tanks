using UnityEngine;
using System.Collections;

public static class GameInput
{
	static Vector3 _moveInput;
	static Vector2 _rotateInput;

	/// <summary>
	/// Gets or sets the move input.
	/// </summary>
	/// <value>The move input.</value>
	public static Vector3 MoveInput
	{
		get { return _moveInput; }
		set { _moveInput = value; }
	}

	/// <summary>
	/// Gets or sets the rotate input.
	/// </summary>
	/// <value>The rotate input.</value>
	public static Vector2 RotateInput
	{
		get { return _rotateInput; }
		set { _rotateInput = value; }
	}

	// Update is called once per frame
	public static void Update()
	{
		UpdateMoveInput();
		UpdateRotateInput();
	}

	/// <summary>
	/// Updates the move input.
	/// </summary>
	public static void UpdateMoveInput()
	{
		_moveInput = Vector2.zero;
		if( Input.GetKey( KeyCode.UpArrow ) || Input.GetKey( KeyCode.W ) )
			_moveInput += Vector3.forward * Time.deltaTime;
		if( Input.GetKey( KeyCode.DownArrow ) || Input.GetKey( KeyCode.S ) )
			_moveInput -= Vector3.forward * Time.deltaTime;
		if( Input.GetKey( KeyCode.RightArrow ) || Input.GetKey( KeyCode.D ) )
			_moveInput += Vector3.right * Time.deltaTime;
		if( Input.GetKey( KeyCode.LeftArrow ) || Input.GetKey( KeyCode.A ) )
			_moveInput -= Vector3.right * Time.deltaTime;
	}

	/// <summary>
	/// Updates the rotate input.
	/// </summary>
	public static void UpdateRotateInput()
	{
		_rotateInput = Input.mousePosition;
	}
}
