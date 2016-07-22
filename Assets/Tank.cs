using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Tank : MonoBehaviour
{
	List<Cannon> _cannons;
	Player _player;
	TankDataController _tankDataController;
	TankMoveController _tankMoveController;

	/// <summary>
	/// Gets or sets the player controlling this tank.
	/// </summary>
	/// <value>The player.</value>
	public Player Player
	{
		get { return _player; }
		set { _player = value; }
	}

	/// <summary>
	/// Gets or sets the tank data controller.
	/// </summary>
	/// <value>The tank data controller.</value>
	public TankDataController TankDataController
	{
		get { return _tankDataController; }
		set { _tankDataController = value; }
	}

	/// <summary>
	/// Gets or sets the tank move controller.
	/// </summary>
	/// <value>The tank move controller.</value>
	public TankMoveController TankMoveController
	{
		get { return _tankMoveController; }
		set { _tankMoveController = value; }
	}

	// Unity awake
	void Awake()
	{
		_tankDataController = new TankDataController( this );
		_tankMoveController = new TankMoveController( this );
		_cannons = new List<Cannon>();
	}

	// Unity fixed update
	void FixedUpdate()
	{
		_tankMoveController.PhysicsUpdate();
	}

	// Unity update
	void Update()
	{
		_tankMoveController.NonPhysicsUpdate();

		// Check to fire cannons
		for( int i = 0; i < _cannons.Count; ++i )
		{
			if( _cannons[i].CannonController.QueuedToFire )
				_cannons[i].Fire();
		}
	}

	/// <summary>
	/// Levels up the tank.
	/// </summary>
	public void LevelUp( int levelDelta )
	{
		if( ProgressionData.TankLevelFormsDictionary.ContainsKey( _player.Level ) )
		{
			TankData data = ProgressionData.TankLevelFormsDictionary[_player.Level][0];
			ChangeForm( data );
			_tankDataController.ChangeForm( data );

		}
	}

	/// <summary>
	/// Destroies all cannons attached to this tank.
	/// </summary>
	public void DestroyAllCannons()
	{
		while( 0 < _cannons.Count )
		{
			Destroy( _cannons[_cannons.Count - 1].gameObject );
			_cannons.RemoveAt( _cannons.Count - 1 );
		}
	}

	/// <summary>
	/// Updates the 3D attributes of this tank to reflect a form change.
	/// </summary>
	public void ChangeForm( TankData data )
	{
		DestroyAllCannons();
		for( int i = 0; i < data.CannonData.Length; ++i )
		{
			_cannons.Add( Cannon.NewCannon() );
			_cannons[i].transform.parent = transform;
			_cannons[i].transform.name = data.CannonData[i].Name;
			_cannons[i].transform.position = data.CannonData[i].Position;
			_cannons[i].transform.rotation = data.CannonData[i].Rotation;
		}
	}
}
