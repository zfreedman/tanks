using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	PlayerController _controller;

	/// <summary>
	/// Gets or sets the controller.
	/// </summary>
	/// <value>The controller.</value>
	public PlayerController Controller
	{
		get { return _controller; }
		set { _controller = value; }
	}

	// Unity awake
	void Awake()
	{
		_controller = new PlayerController( this );
	}

	// Unity fixed update
	void FixedUpdate()
	{
		_controller.FixedUpdate();
	}

	// Unity Update
	void Update()
	{
		_controller.Update();
	}
}
