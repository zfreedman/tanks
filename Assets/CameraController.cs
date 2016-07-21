using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{
	Transform _focus;
	Vector3 _positionRelativeToFocus = new Vector3( 0, 15, -5 );
	Quaternion _rotation = Quaternion.Euler( Vector3.right * 70 );

	/// <summary>
	/// Gets or sets the focus.
	/// </summary>
	/// <value>The focus.</value>
	public Transform Focus
	{
		get { return _focus; }
		set { _focus = value; }
	}

	/// <summary>
	/// Gets or sets the rotation of the camera.
	/// </summary>
	/// <value>The rotation.</value>
	public Quaternion Rotation
	{
		get { return _rotation; }
		set { _rotation = value; }
	}

	/// <summary>
	/// Gets or sets the position of the camera relative to focus.
	/// </summary>
	/// <value>The position relative to focus.</value>
	public Vector3 PositionRelativeToFocus
	{
		get { return _positionRelativeToFocus; }
		set { _positionRelativeToFocus = value; }
	}


	// Unity awake
	void Awake()
	{
		transform.rotation = _rotation;
	}
	
	// Unity update
	void Update()
	{
		if( _focus != null )
		{
			transform.position = _focus.position + _positionRelativeToFocus;
		}
	}
}
