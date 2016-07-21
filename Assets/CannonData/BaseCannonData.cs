using UnityEngine;
using System.Collections;

public class BaseCannonData : CannonData
{
	public BaseCannonData()
	{
		_damageMult = ProgressionData.BaseMult;
		_name = "Basic Cannon";
		_position = ProgressionData.BaseCannonPosition;
		_rangeMult = ProgressionData.BaseMult;
		_reloadMult = ProgressionData.BaseMult;
		_rotation = ProgressionData.BaseCannonRotation;
		_sizeMult = ProgressionData.BaseMult;
		_velMult = ProgressionData.BaseMult;
	}
}
