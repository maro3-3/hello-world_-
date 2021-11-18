using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class List_AreaLv : ScriptableObject
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
		
		public int int_CountryNo;
		public int int_AreaNo;
		public int int_AreaLv2;
		public int int_AreaLv3;
		public int int_AreaLv4;
		public int int_AreaLv5;
	}
}

