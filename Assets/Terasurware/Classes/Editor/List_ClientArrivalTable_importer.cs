using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;
using System.Xml.Serialization;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

public class List_ClientArrivalTable_importer : AssetPostprocessor {
	private static readonly string filePath = "Assets/DataList/List_ClientArrivalTable.xls";
	private static readonly string exportPath = "Assets/Resources/List_ClientArrivalTable.asset";
	private static readonly string[] sheetNames = { "Sheet1", };
	
	static void OnPostprocessAllAssets (string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
	{
		foreach (string asset in importedAssets) {
			if (!filePath.Equals (asset))
				continue;
				
			ListClientArrivalTable data = (ListClientArrivalTable)AssetDatabase.LoadAssetAtPath (exportPath, typeof(ListClientArrivalTable));
			if (data == null) {
				data = ScriptableObject.CreateInstance<ListClientArrivalTable> ();
				AssetDatabase.CreateAsset ((ScriptableObject)data, exportPath);
				data.hideFlags = HideFlags.NotEditable;
			}
			
			data.sheets.Clear ();
			using (FileStream stream = File.Open (filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite)) {
				IWorkbook book = null;
				if (Path.GetExtension (filePath) == ".xls") {
					book = new HSSFWorkbook(stream);
				} else {
					book = new XSSFWorkbook(stream);
				}
				
				foreach(string sheetName in sheetNames) {
					ISheet sheet = book.GetSheet(sheetName);
					if( sheet == null ) {
						Debug.LogError("[QuestData] sheet not found:" + sheetName);
						continue;
					}

					ListClientArrivalTable.Sheet s = new ListClientArrivalTable.Sheet ();
					s.name = sheetName;
				
					for (int i=1; i<= sheet.LastRowNum; i++) {
						IRow row = sheet.GetRow (i);
						ICell cell = null;
						
						ListClientArrivalTable.Param p = new ListClientArrivalTable.Param ();
						
					cell = row.GetCell(0); p.int_CountryNo = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(1); p.int_AreaNo = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(2); p.int_Client_1thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(3); p.int_Client_2thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(4); p.int_Client_3thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(5); p.int_Client_4thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(6); p.int_Client_5thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(7); p.int_Client_6thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(8); p.int_Client_7thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(9); p.int_Client_8thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(10); p.int_Client_9thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(11); p.int_Client_10thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(12); p.int_Client_11thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(13); p.int_Client_12thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(14); p.int_Client_13thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(15); p.int_Client_14thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(16); p.int_Client_15thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(17); p.int_Client_16thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(18); p.int_Client_17thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(19); p.int_Client_18thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(20); p.int_Client_19thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(21); p.int_Client_20thPerson = (int)(cell == null ? 0 : cell.NumericCellValue);
						s.list.Add (p);
					}
					data.sheets.Add(s);
				}
			}

			ScriptableObject obj = AssetDatabase.LoadAssetAtPath (exportPath, typeof(ScriptableObject)) as ScriptableObject;
			EditorUtility.SetDirty (obj);
		}
	}
}
