using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
	Tank _tank;
	int _level = 0;
	int _experience = 0;
	int _score = 0;

	public delegate void LevelUpDelegate( int level );
	public event LevelUpDelegate LevelUp;

	/// <summary>
	/// Gets the level of the player.
	/// </summary>
	/// <value>The level.</value>
	public int Level
	{
		get { return _level; }
	}

	/// <summary>
	/// Gets the experience of the player.
	/// </summary>
	/// <value>The experience.</value>
	public int Experience
	{
		get { return _experience; }
	}

	/// <summary>
	/// Gets the score of the player.
	/// </summary>
	/// <value>The score.</value>
	public int Score
	{
		get { return _score; }
	}

	// Unity awake
	void Awake()
	{
		_tank = gameObject.AddComponent<Tank>();
		_tank.Player = this;
		LevelUp += new LevelUpDelegate( _tank.LevelUp );
		SetLevel( 1 );
	}

	// Unity fixed update
	void FixedUpdate()
	{
		_tank.PhysicsUpdate( GameInput.MoveInput, Time.deltaTime );
	}

	// Unity update
	void Update()
	{
		Vector3 worldMousePos = Game.Camera.ScreenToWorldPoint( new Vector3( GameInput.RotateInput.x,
			                        GameInput.RotateInput.y, Game.Camera.transform.position.y ) );
		_tank.DataAndActionUpdate( worldMousePos, Time.deltaTime, GameInput.AutoFireEnabled, GameInput.FireRequested );
	}

	/// <summary>
	/// Returns a new player component.
	/// </summary>
	/// <returns>A new player game object.</returns>
	public static Player NewPlayer()
	{
		GameObject go = Instantiate( Resources.Load<GameObject>( "Base Player GO" ) );
		go.name = "New Player";
		return go.AddComponent<Player>();
	}

	/// <summary>
	/// Sets the level of the player.
	/// </summary>
	/// <param name="level">Level.</param>
	public void SetLevel( int level )
	{
		int oldLevel = _level;
		_level = level;
		LevelUp( _level - oldLevel );
	}
}
