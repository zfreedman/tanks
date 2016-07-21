using UnityEngine;
using System.Collections;

public class TankData
{
	protected float _accelMult;
	protected CannonData[] _cannonData;
	protected float _dragMult;
	protected float _velMult;

	/// <summary>
	/// Gets the acceleration multiplier.
	/// </summary>
	/// <value>The accel multiplier.</value>
	public float AccelMult
	{
		get { return _accelMult; }
	}

	/// <summary>
	/// Gets the cannon data.
	/// </summary>
	public CannonData[] CannonData
	{
		get { return _cannonData; }
	}
	
	/// <summary>
	/// Gets the drag multiplier.
	/// </summary>
	/// <value>The drag multiplier.</value>
	public float DragMult
	{
		get { return _dragMult; }
	}

	/// <summary>
	/// Gets the velocity multiplier.
	/// </summary>
	/// <value>The vel multiplier.</value>
	public float VelMult
	{
		get { return _velMult; }
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="TankData"/> class.
	/// </summary>
	public TankData()
	{
	}
}
