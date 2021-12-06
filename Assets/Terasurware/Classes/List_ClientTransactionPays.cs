using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class List_ClientTransactionPays : ScriptableObject
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
		public int int_TransactionNum;
		public int int_RequestsNum;
		public int int_AmoPay_High;
		public int int_AmoPay_Mid;
		public int int_AmoPay_Low;
	}
}

