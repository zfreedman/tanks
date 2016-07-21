using UnityEngine;
using System.Collections;

public class CannonController
{
	Cannon _cannon;
	float _damage;
	float _damageMult;
	float _range;
	float _rangeMult;
	float _reload;
	float _reloadMult;
	float _size;
	float _sizeMult;
	float _vel;
	float _velMult;

	/// <summary>
	/// Gets the cannon.
	/// </summary>
	public Cannon Cannon
	{
		get { return _cannon; }
	}

	/// <summary>
	/// Gets the damage.
	/// </summary>
	/// <value>The damage.</value>
	public float Damage
	{
		get { return _damage; }
	}

	/// <summary>
	/// Gets the damage multiplier.
	/// </summary>
	/// <value>The damage multiplier.</value>
	public float DamageMult
	{
		get { return _damageMult; }
	}

	/// <summary>
	/// Gets the range.
	/// </summary>
	/// <value>The range.</value>
	public float Range
	{
		get { return _range; }
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
	/// Gets the reload.
	/// </summary>
	/// <value>The reload.</value>
	public float Reload
	{
		get { return _reload; }
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
	/// Gets the size.
	/// </summary>
	/// <value>The size.</value>
	public float Size
	{
		get { return _sizeMult; }
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
	/// Gets the velocity.
	/// </summary>
	/// <value>The velocity.</value>
	public float Vel
	{
		get { return _vel; }
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
	/// Initializes a new instance of the <see cref="CannonController"/> class.
	/// </summary>
	/// <param name="cannon">Cannon.</param>
	public CannonController( Cannon cannon )
	{
		_cannon = cannon;
	}
}
