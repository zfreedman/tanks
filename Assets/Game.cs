using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
	static Camera _cam;
	static Game _instance;
	static Player _player;

	/// <summary>
	/// Gets the current camera.
	/// </summary>
	/// <value>The cam.</value>
	public static Camera Camera
	{
		get { return _cam; }
	}

	/// <summary>
	/// Gets the game.
	/// </summary>
	/// <value>The instance.</value>
	public static Game Instance
	{
		get { return _instance; }
	}

	/// <summary>
	/// Gets the player.
	/// </summary>
	/// <value>The player.</value>
	public static Player Player
	{
		get { return _player; }
	}

	// Unity awake
	void Awake()
	{
		_instance = this;
		_cam = Camera.main;
		CameraController camController =
			_cam.gameObject.AddComponent<CameraController>();
		_player = Player.NewPlayer();
		camController.Focus = _player.transform;
	}

	// Unity update
	void Update()
	{
		GameInput.Update();
	}
}
