using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListMission : ScriptableObject
{	
	public List<Sheet> sheets = new List<Sheet> ();

	[System.SerializableAttribute]
	public class Sheet
	{
		public string name = string.Empty;
		public List<Param> list = new List<Param>();
	}

	[System.SerializableAttribute]
	public class Param
	{
		
		public int int_RewardLv;
		public int int_RewardContent;
		public int int_RewardState;
	}
}

