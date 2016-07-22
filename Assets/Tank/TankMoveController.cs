using UnityEngine;
using System.Collections;

public class TankMoveController
{
	Tank _tank;
	TankDataController _tankDataController;

	/// <summary>
	/// Gets or sets the tank.
	/// </summary>
	/// <value>The tank.</value>
	public Tank Tank
	{
		get { return _tank; }
		set { _tank = value; }
	}

	/// <summary>
	/// Gets or sets the tank data controller.
	/// </summary>
	/// <value>The tank data controller.</value>
	public TankDataController TankDataController
	{
		get { return _tankDataController; }
		set { _tankDataController = value; }
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="TankMoveController"/> class.
	/// </summary>
	/// <param name="tank">Tank.</param>
	public TankMoveController( Tank tank )
	{
		_tank = tank;
		Rigidbody rb = _tank.gameObject.AddComponent<Rigidbody>();
		rb.useGravity = false;
		rb.drag = 2.5f;
		rb.constraints = RigidbodyConstraints.FreezePositionY;
	}

	/// <summary>
	/// Updates the tank movement via physics.
	/// </summary>
	/// <param name="moveInput">Move input.</param>
	/// <param name="deltaTime">Delta time.</param>
	public void PhysicsUpdate( Vector3 moveInput, float deltaTime )
	{
		Rigidbody rigidBody = _tank.GetComponent<Rigidbody>();
		if( rigidBody.velocity.sqrMagnitude <= 10 )
			rigidBody.AddForce(
				moveInput.normalized * _tankDataController.Accel * _tankDataController.AccelMult * deltaTime );
	}

	/// <summary>
	/// Non-physics tank movement update.
	/// </summary>
	/// <param name="worldMousePosition">World mouse position.</param>
	public void NonPhysicsUpdate( Vector3 worldMousePosition )
	{
		Vector3 lookDir = new Vector3( worldMousePosition.x, _tank.transform.position.y, worldMousePosition.z );
		_tank.transform.LookAt( lookDir );
	}

}
