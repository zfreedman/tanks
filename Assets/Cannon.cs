using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour
{
	CannonController _cannonController;

	/// <summary>
	/// Gets or sets a the cannon controller.
	/// </summary>
	public CannonController CannonController
	{
		get { return _cannonController; }
		set { _cannonController = value; }
	}

	// Unity awake
	void Awake()
	{
		_cannonController = new CannonController( this );
	}
	
	// Unity update
	void Update()
	{
		_cannonController.Update( Time.deltaTime );
	}

	/// <summary>
	/// Fires the cannon.
	/// </summary>
	public void Fire()
	{
		print( "Firing cannon" );
		_cannonController.QueuedToFire = false;
		_cannonController.TimeTillCanFire = _cannonController.Reload * _cannonController.ReloadMult;
	}

	/// <summary>
	/// Returns a new cannon game object.
	/// </summary>
	/// <returns>The cannon.</returns>
	public static Cannon NewCannon()
	{
		GameObject go = Instantiate( Resources.Load<GameObject>( "Base Cannon GO" ) );
		go.name = "New Cannon";
		return go.AddComponent<Cannon>();
	}
}
