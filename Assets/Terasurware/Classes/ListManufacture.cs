using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListManufacture : ScriptableObject
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
		public int int_ManufacturerNo;
		public string string_ManufacturerName;
		public int int_Products;
	}
}

