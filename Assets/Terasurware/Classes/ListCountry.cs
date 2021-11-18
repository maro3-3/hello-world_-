using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListCountry : ScriptableObject
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
		
		public int int_CountryState;
		public int int_CountryNo;
		public string string_CountryName;
		public int int_AreaNo;
		public string string_AreaName;
		public int int_UnemployedNum;
	}
}

