using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class List_ClientInformation : ScriptableObject
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
		public int int_ClientNo;
		public string string_ClientName;
		public int int_ClientLv;
		public int int_ClientType;
		public int int_Transaction_1;
		public int int_Transaction_2;
		public int int_Transaction_3;
		public int int_Transaction_4;
		public int int_Transaction_5;
		public int int_Transaction_6;
	}
}

