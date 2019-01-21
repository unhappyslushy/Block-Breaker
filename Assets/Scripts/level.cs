using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {

	[SerializeField] int breakableBlocks;
	[SerializeField] Level level;
	public void CountBreakableBlocks()
	{
		breakableBlocks++;
	}

}
