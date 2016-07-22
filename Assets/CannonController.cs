using UnityEngine;
using System.Collections;

public class CannonController
{
	protected Cannon _cannon;
	protected float _damage;
	protected float _damageMult;
	protected bool _queuedToFire;
	protected float _range;
	protected float _rangeMult;
	protected float _reload;
	protected float _reloadMult;
	protected float _size;
	protected float _sizeMult;
	protected float _timeTillCanFire;
	protected float _vel;
	protected float _velMult;

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
	/// Gets or sets a value indicating whether this <see cref="CannonController"/> queued to fire.
	/// </summary>
	/// <value><c>true</c> if queued to fire; otherwise, <c>false</c>.</value>
	public bool QueuedToFire
	{
		get { return _queuedToFire; }
		set { _queuedToFire = value; }
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
	/// Gets or sets the time till the cannon can fire.
	/// </summary>
	/// <value>The time till the cannon can fire.</value>
	public float TimeTillCanFire
	{
		get { return _timeTillCanFire; }
		set { _timeTillCanFire = value; }
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
		_damage = ProgressionData.BaseCannonDamage;
		_damageMult = ProgressionData.BaseMult;
		_queuedToFire = false;
		_range = ProgressionData.BaseCannonRange;
		_rangeMult = ProgressionData.BaseMult;
		_reload = ProgressionData.BaseCannonReload;
		_reloadMult = ProgressionData.BaseMult;
		_size = ProgressionData.BaseCannonSize;
		_sizeMult = ProgressionData.BaseMult;
		_timeTillCanFire = ProgressionData.BaseCannonTimeTillNextFire;
		_vel = ProgressionData.BaseCannonVel;
		_velMult = ProgressionData.BaseMult;
	}

	/// <summary>
	/// Update this instance.
	/// </summary>
	public void Update( float deltaTime )
	{
		if( 0 < _timeTillCanFire )
			_timeTillCanFire -= deltaTime;
		if( _timeTillCanFire <= 0 )
		{
			if( GameInput.AutoFireEnabled || GameInput.FireRequested )
				_queuedToFire = true;
		}
	}
}
