using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class ProgressionData
{
	static float _baseCannonDamage = 1.0f;
	static Vector3 _baseCannonPosition = Vector3.forward * .5f;
	static float _baseCannonRange = 10.0f;
	static float _baseCannonReload = 3.0f;
	static Quaternion _baseCannonRotation = Quaternion.Euler( Vector3.right * 90 );
	static float _baseCannonSize = 1.0f;
	static float _baseCannonTimeTillNextFire = 0.0f;
	static float _baseCannonVel = 50.0f;

	static float _baseMult = 1.0f;

	static float _baseTankAccel = 1000.0f;
	static Cannon[] _baseTankCannonData = new Cannon[0];
	static float _baseTankDrag = 2.5f;
	static float _baseTankHealth = 100.0f;
	static float _baseTankRegen = 1.0f;
	static float _baseTankVel = 200.0f;

	static Dictionary<int, int> _tankLevelAddedStatsDictionary;
	static Dictionary<int, List<TankData> > _tankLevelFormsDictionary;

	/// <summary>
	/// Gets the base cannon damage.
	/// </summary>
	/// <value>The base cannon damage.</value>
	public static float BaseCannonDamage
	{
		get { return _baseCannonDamage; }
	}

	/// <summary>
	/// Gets the base cannon position.
	/// </summary>
	/// <value>The base cannon position.</value>
	public static Vector3 BaseCannonPosition
	{
		get { return _baseCannonPosition; }
	}

	/// <summary>
	/// Gets the base cannon range.
	/// </summary>
	/// <value>The base cannon range.</value>
	public static float BaseCannonRange
	{
		get { return _baseCannonRange; }
	}

	/// <summary>
	/// Gets the base cannon reload.
	/// </summary>
	/// <value>The base cannon reload.</value>
	public static float BaseCannonReload
	{
		get { return _baseCannonReload; }
	}

	/// <summary>
	/// Gets the base cannon rotation.
	/// </summary>
	/// <value>The base cannon rotation.</value>
	public static Quaternion BaseCannonRotation
	{
		get { return _baseCannonRotation; }
	}

	/// <summary>
	/// Gets the size of the base cannon.
	/// </summary>
	/// <value>The size of the base cannon.</value>
	public static float BaseCannonSize
	{
		get { return _baseCannonSize; }
	}

	/// <summary>
	/// Gets the base time till next fire for cannons.
	/// </summary>
	/// <value>The base cannon time till next fire.</value>
	public static float BaseCannonTimeTillNextFire
	{
		get { return _baseCannonTimeTillNextFire; }
	}

	/// <summary>
	/// Gets the base cannon velocity.
	/// </summary>
	/// <value>The base cannon velocity.</value>
	public static float BaseCannonVel
	{
		get { return _baseCannonVel; }
	}

	/// <summary>
	/// Gets the base multiplier.
	/// </summary>
	/// <value>The base multiplier.</value>
	public static float BaseMult
	{
		get { return _baseMult; }
	}

	/// <summary>
	/// Gets the base tank acceleleration.
	/// </summary>
	/// <value>The base tank acceleration.</value>
	public static float BaseTankAccel
	{
		get { return _baseTankAccel; }
	}

	/// <summary>
	/// Gets the base tank cannon data.
	/// </summary>
	/// <value>The base tank cannon data.</value>
	public static Cannon[] BaseTankCannonData
	{
		get { return _baseTankCannonData; }
	}

	/// <summary>
	/// Gets the base tank drag.
	/// </summary>
	/// <value>The base tank drag.</value>
	public static float BaseTankDrag
	{
		get { return _baseTankDrag; }
	}

	/// <summary>
	/// Gets the base tank health.
	/// </summary>
	/// <value>The base tank health.</value>
	public static float BaseTankHealth
	{
		get { return _baseTankHealth; }
	}

	/// <summary>
	/// Gets the base tank regen.
	/// </summary>
	/// <value>The base tank regen.</value>
	public static float BaseTankRegen
	{
		get { return _baseTankRegen; }
	}

	/// <summary>
	/// Gets the base tank velocity.
	/// </summary>
	/// <value>The base tank velocity.</value>
	public static float BaseTankVel
	{
		get { return _baseTankVel; }
	}

	/// <summary>
	/// Gets the tank level forms dictionary.
	/// </summary>
	/// <value>The tank level forms dictionary.</value>
	public static Dictionary<int, List<TankData> > TankLevelFormsDictionary
	{
		get { return _tankLevelFormsDictionary; }
	}

	static ProgressionData()
	{
		_tankLevelAddedStatsDictionary = new Dictionary<int, int>();
		_tankLevelAddedStatsDictionary.Add( 2, 2 );

		_tankLevelFormsDictionary = new Dictionary<int, List<TankData> >();
		_tankLevelFormsDictionary.Add( 1, new List<TankData>() );
		_tankLevelFormsDictionary[1].Add( new BaseTankData() );
	}
}
