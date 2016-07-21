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
	}

	public static Cannon NewCannon()
	{
		GameObject go = Instantiate( Resources.Load<GameObject>( "Base Cannon GO" ) );
		go.name = "New Cannon";
		return go.AddComponent<Cannon>();
	}
}
