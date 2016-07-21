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
	public void PhysicsUpdate()
	{
		Rigidbody rigidBody = _tank.GetComponent<Rigidbody>();
		TankDataController dataController = _tank.TankDataController;
		if( rigidBody.velocity.sqrMagnitude <= 10 )
			rigidBody.AddForce(
				GameInput.MoveInput.normalized * dataController.Accel * dataController.AccelMult * Time.deltaTime );
	}

	/// <summary>
	/// Non-physics tank movement update.
	/// </summary>
	public void NonPhysicsUpdate()
	{
		Vector2 mousePos = GameInput.RotateInput;
		Vector3 worldPos =
			Game.Camera.ScreenToWorldPoint( new Vector3( mousePos.x, mousePos.y, Game.Camera.transform.position.y ) );
		Vector3 lookDir = new Vector3( worldPos.x, _tank.transform.position.y, worldPos.z );
		_tank.transform.LookAt( lookDir );
	}

}
