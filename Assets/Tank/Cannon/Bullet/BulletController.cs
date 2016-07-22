using UnityEngine;
using System.Collections;

public class BulletController
{
	protected Bullet _bullet;
	protected float _damage;
	protected Vector3 _direction;
	protected Vector3 _origin;
	protected float _range;
	protected float _size;
	protected float _vel;

	/// <summary>
	/// Gets the bullet.
	/// </summary>
	/// <value>The bullet.</value>
	public Bullet Bullet
	{
		get { return _bullet; }
	}

	/// <summary>
	/// Gets or sets the damage.
	/// </summary>
	/// <value>The damage.</value>
	public float Damage
	{
		get { return _damage; }
		set { _damage = value; }
	}

	/// <summary>
	/// Gets or sets the direction.
	/// </summary>
	/// <value>The direction.</value>
	public Vector3 Direction
	{
		get { return _direction; }
		set { _direction = value; }
	}

	/// <summary>
	/// Gets or sets the origin.
	/// </summary>
	/// <value>The origin.</value>
	public Vector3 Origin
	{
		get { return _origin; }
		set { _origin = value; }
	}

	/// <summary>
	/// Gets or sets the range.
	/// </summary>
	/// <value>The range.</value>
	public float Range
	{
		get { return _range; }
		set { _range = value; }
	}

	/// <summary>
	/// Gets or sets the size.
	/// </summary>
	/// <value>The size.</value>
	public float Size
	{
		get { return _size; }
		set { _size = value; }
	}

	/// <summary>
	/// Gets or sets the vel.
	/// </summary>
	/// <value>The vel.</value>
	public float Vel
	{
		get { return _vel; }
		set { _vel = value; }
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="BulletController"/> class.
	/// </summary>
	public BulletController()
	{
	}
}
