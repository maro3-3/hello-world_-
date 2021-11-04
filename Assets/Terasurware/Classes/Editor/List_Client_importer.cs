using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;
using System.Xml.Serialization;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

public class List_Client_importer : AssetPostprocessor {
	private static readonly string filePath = "Assets/Excells/List_Client.xls";
	private static readonly string exportPath = "Assets/Resources/List_Client.asset";
	private static readonly string[] sheetNames = { "Sheet1", };
	
	static void OnPostprocessAllAssets (string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
	{
		foreach (string asset in importedAssets) {
			if (!filePath.Equals (asset))
				continue;
				
			List_Client data = (List_Client)AssetDatabase.LoadAssetAtPath (exportPath, typeof(List_Client));
			if (data == null) {
				data = ScriptableObject.CreateInstance<List_Client> ();
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

					List_Client.Sheet s = new List_Client.Sheet ();
					s.name = sheetName;
				
					for (int i=1; i<= sheet.LastRowNum; i++) {
						IRow row = sheet.GetRow (i);
						ICell cell = null;
						
						List_Client.Param p = new List_Client.Param ();
						
					cell = row.GetCell(0); p.int_CountryNo = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(1); p.int_AreaNo = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(2); p.int_ClientNo = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(3); p.string_ClientName = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(4); p.int_ClientLv = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(5); p.int_ClientType = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(6); p.int_Transactions = (int)(cell == null ? 0 : cell.NumericCellValue);
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
