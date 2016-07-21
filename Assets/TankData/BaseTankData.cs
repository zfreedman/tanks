using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseTankData : TankData
{
	public BaseTankData()
	{
		_accelMult = ProgressionData.BaseMult;
		_dragMult = ProgressionData.BaseTankDrag;
		_velMult = ProgressionData.BaseMult;

		_cannonData = new CannonData[1];
		_cannonData[0] = new BaseCannonData();
	}
}
