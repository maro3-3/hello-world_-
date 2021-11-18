using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ListClientArrivalTable : ScriptableObject
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
		public int int_Client_1thPerson;
		public int int_Client_2thPerson;
		public int int_Client_3thPerson;
		public int int_Client_4thPerson;
		public int int_Client_5thPerson;
		public int int_Client_6thPerson;
		public int int_Client_7thPerson;
		public int int_Client_8thPerson;
		public int int_Client_9thPerson;
		public int int_Client_10thPerson;
		public int int_Client_11thPerson;
		public int int_Client_12thPerson;
		public int int_Client_13thPerson;
		public int int_Client_14thPerson;
		public int int_Client_15thPerson;
		public int int_Client_16thPerson;
		public int int_Client_17thPerson;
		public int int_Client_18thPerson;
		public int int_Client_19thPerson;
		public int int_Client_20thPerson;
	}
}

