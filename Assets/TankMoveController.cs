using UnityEngine;
using System.Collections;

public class TankMoveController
{
	Tank _tank;

	/// <summary>
	/// Gets or sets the tank.
	/// </summary>
	/// <value>The tank.</value>
	public Tank Tank
	{
		get { return _tank; }
		set { _tank = value; }
	}

	// Unity awake
	public TankMoveController( Tank tank )
	{
		_tank = tank;
		Rigidbody rb = _tank.gameObject.AddComponent<Rigidbody>();
		rb.useGravity = false;
		rb.drag = 2.5f;
	}

	/// <summary>
	/// Updates the tank movement via physics.
	/// </summary>
	public void PhysicsUpdate( Vector3 moveInput )
	{
		Rigidbody rigidBody = _tank.GetComponent<Rigidbody>();
		TankDataController dataController = _tank.TankDataController;
		if( rigidBody.velocity.sqrMagnitude <= 10 )
			rigidBody.AddForce(
				moveInput.normalized * dataController.Accel * dataController.AccelMult * Time.deltaTime );
	}

	/// <summary>
	/// Non-physics tank movement update.
	/// </summary>
	public void NonPhysicsUpdate( Vector3 worldMousePosition )
	{
		Vector3 lookDir = new Vector3( worldMousePosition.x, _tank.transform.position.y, worldMousePosition.z );
		_tank.transform.LookAt( lookDir );
	}

}
