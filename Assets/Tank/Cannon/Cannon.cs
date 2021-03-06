﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cannon : MonoBehaviour
{
	CannonController _cannonController;
	LinkedList<Bullet> _loadedBullets;
	LinkedList<Bullet> _unloadedBullets;

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
		_loadedBullets = new LinkedList<Bullet>();
		_unloadedBullets = new LinkedList<Bullet>();
	}
	
	/// <summary>
	/// Update the data and actions of this cannon.
	/// </summary>
	/// <param name="deltaTime">Delta time.</param>
	/// <param name="autoFireEnabled">Auto fire enabled.</param>
	/// <param name="fireRequested">Fire requested.</param>
	public void DataAndActionUpdate( float deltaTime, bool autoFireEnabled, bool fireRequested )
	{
		_cannonController.DataAndActionUpdate( deltaTime, autoFireEnabled, fireRequested );
	}

	/// <summary>
	/// Updates the cannon physics.
	/// </summary>
	/// <param name="deltaTime">Delta time.</param>
	public void PhysicsUpdate( float deltaTime )
	{
	}

	/// <summary>
	/// Fires the cannon.
	/// </summary>
	public void Fire()
	{
		print( "Firing cannon" );
		Bullet bullet = Bullet.NewBullet( this );
		_unloadedBullets.AddLast( bullet );
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
		return go.AddComponent<Cannon>();
	}
}
