using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	protected BulletController _bulletController;
	protected Tank _tank;

	/// <summary>
	/// Gets or sets the bullet controller.
	/// </summary>
	/// <value>The bullet controller.</value>
	public BulletController BulletController
	{
		get { return _bulletController; }
		set { _bulletController = value; }
	}

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
	void Awake()
	{
		Rigidbody rb = gameObject.AddComponent<Rigidbody>();
		rb.useGravity = false;
		rb.constraints = RigidbodyConstraints.FreezePositionY;

	}
	
	// Update is called once per frame
	void Update()
	{
	
	}

	/// <summary>
	/// Returns a new bullet game object.
	/// </summary>
	/// <returns>The bullet.</returns>
	/// <param name="cannon">Cannon.</param>
	public static Bullet NewBullet( Cannon cannon = null )
	{
		BulletController bulletController = new BulletController();

		if( cannon != null )
		{
			bulletController.Damage = cannon.CannonController.Damage * cannon.CannonController.DamageMult;
			bulletController.Direction = cannon.transform.up.normalized;
			print( cannon.transform.forward );
			bulletController.Origin = cannon.transform.position;
			bulletController.Range = cannon.CannonController.Range * cannon.CannonController.RangeMult;
			bulletController.Size = cannon.CannonController.Size * cannon.CannonController.SizeMult;
			bulletController.Vel = cannon.CannonController.Vel * cannon.CannonController.VelMult;
		}

		Bullet bullet = ( (GameObject)Instantiate( Resources.Load<GameObject>( "Base Bullet GO" ),
			                bulletController.Origin, Quaternion.Euler( bulletController.Direction ) )
		                ).AddComponent<Bullet>();
		bullet.BulletController = bulletController;
		bullet.GetComponent<Rigidbody>().velocity = bulletController.Direction * bulletController.Vel;
		print( bullet.GetComponent<Rigidbody>().velocity );
		return bullet;
	}
}
