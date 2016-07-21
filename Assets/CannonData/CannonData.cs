using UnityEngine;
using System.Collections;

public class CannonData
{
	protected float _damageMult;
	protected string _name;
	protected Vector3 _position;
	protected float _rangeMult;
	protected float _reloadMult;
	protected Quaternion _rotation;
	protected float _sizeMult;
	protected float _velMult;

	/// <summary>
	/// Gets the damage multiplier.
	/// </summary>
	/// <value>The damage multiplier.</value>
	public float DamageMult
	{
		get { return _damageMult; }
	}

	/// <summary>
	/// Gets the name.
	/// </summary>
	/// <value>The name.</value>
	public string Name
	{
		get { return _name; }
	}

	/// <summary>
	/// Gets the position.
	/// </summary>
	/// <value>The position.</value>
	public Vector3 Position
	{
		get { return _position; }
	}

	/// <summary>
	/// Gets the range multiplier.
	/// </summary>
	/// <value>The range multiplier.</value>
	public float RangeMult
	{
		get { return _rangeMult; }
	}

	/// <summary>
	/// Gets the reload multiplier.
	/// </summary>
	/// <value>The reload multiplier.</value>
	public float ReloadMult
	{
		get { return _reloadMult; }
	}

	/// <summary>
	/// Gets the rotation.
	/// </summary>
	/// <value>The rotation.</value>
	public Quaternion Rotation
	{
		get { return _rotation; }
	}

	/// <summary>
	/// Gets the size multiplier.
	/// </summary>
	/// <value>The size multiplier.</value>
	public float SizeMult
	{
		get { return _sizeMult; }
	}

	/// <summary>
	/// Gets the velocity multiplier.
	/// </summary>
	/// <value>The velocity multiplier.</value>
	public float VelMult
	{
		get { return _velMult; }
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="CannonData"/> class.
	/// </summary>
	public CannonData()
	{
	}
}
