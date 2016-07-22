using UnityEngine;
using System.Collections;

public static class GameInput
{
	static bool _autoFireEnabled;
	static bool _fireRequested;
	static Vector3 _moveInput;
	static Vector2 _rotateInput;

	/// <summary>
	/// Gets a value indicating whether this <see cref="GameInput"/> has auto fire enabled.
	/// </summary>
	/// <value><c>true</c> if auto fire enabled; otherwise, <c>false</c>.</value>
	public static bool AutoFireEnabled
	{
		get { return _autoFireEnabled; }
		set { _autoFireEnabled = value; }
	}

	/// <summary>
	/// Gets or sets a value indicating whether this <see cref="GameInput"/> requested fire.
	/// </summary>
	/// <value><c>true</c> if fire requested; otherwise, <c>false</c>.</value>
	public static bool FireRequested
	{
		get { return _fireRequested; }
		set { _fireRequested = value; }
	}

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

	/// <summary>
	/// Update this instance.
	/// </summary>
	public static void Update()
	{
		UpdateMoveInput();
		UpdateRotateInput();
	}

	/// <summary>
	/// Updates the instance after update has been called.
	/// </summary>
	public static void LateUpdate()
	{
		_fireRequested = false;
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
		if( Input.GetKeyDown( KeyCode.U ) )
			_autoFireEnabled = !_autoFireEnabled;
		if( !_autoFireEnabled )
		{
			if( Input.GetMouseButtonDown( 0 ) )
				_fireRequested = true;
		}
	}

	/// <summary>
	/// Updates the rotate input.
	/// </summary>
	public static void UpdateRotateInput()
	{
		_rotateInput = Input.mousePosition;
	}
}
