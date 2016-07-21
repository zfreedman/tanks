using UnityEngine;
using System.Collections;

public class TankDataController
{
	float _accelMult;
	float _accel;
	float _drag;
	float _dragMult;
	Tank _tank;
	float _vel;
	float _velMult;

	/// <summary>
	/// Gets or sets the acceleration.
	/// </summary>
	/// <value>The acceleration.</value>
	public float Accel
	{
		get { return _accel; }
		set { _accel = value; }
	}

	/// <summary>
	/// Gets or sets the acceleration multiplier.
	/// </summary>
	/// <value>The accel mult.</value>
	public float AccelMult
	{
		get { return _accelMult; }
		set { _accelMult = value; }
	}

	/// <summary>
	/// Gets or sets the drag.
	/// </summary>
	/// <value>The drag.</value>
	public float Drag
	{
		get { return _drag; }
		set { _drag = value; }
	}

	/// <summary>
	/// Gets or sets the drag multiplier.
	/// </summary>
	/// <value>The drag multiplier.</value>
	public float DragMult
	{
		get { return _dragMult; }
		set { _dragMult = value; }
	}

	/// <summary>
	/// Gets the tank.
	/// </summary>
	/// <value>The tank.</value>
	public Tank Tank
	{
		get { return _tank; }
	}

	/// <summary>
	/// Gets the velocity.
	/// </summary>
	/// <value>The velocity.</value>
	public float Vel
	{
		get { return _vel; }
		set { _vel = value; }
	}

	/// <summary>
	/// Gets the velocity multiplier.
	/// </summary>
	/// <value>The velocity multiplier.</value>
	public float VelMult
	{
		get { return _velMult; }
		set { _velMult = value; }
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="TankDataController"/> class.
	/// </summary>
	/// <param name="tank">Tank.</param>
	public TankDataController( Tank tank )
	{
		_tank = tank;
		_accelMult = ProgressionData.BaseMult;
		_accel = ProgressionData.BaseTankAccel;
		_drag = ProgressionData.BaseTankDrag;
		_dragMult = ProgressionData.BaseMult;
		_vel = ProgressionData.BaseTankVel;
		_velMult = ProgressionData.BaseMult;
	}

	/// <summary>
	/// Updates the attributes of this tank to reflect a form change.
	/// </summary>
	/// <param name="data">Data.</param>
	public void ChangeForm( TankData data )
	{
		_accelMult = data.AccelMult;
		_dragMult = data.DragMult;
		_velMult = data.VelMult;
	}
}
