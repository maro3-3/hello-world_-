using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;
using System.Xml.Serialization;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

public class List_CountryAndArea_importer : AssetPostprocessor {
	private static readonly string filePath = "Assets/DataList/List_CountryAndArea.xls";
	private static readonly string exportPath = "Assets/Resources/List_CountryAndArea.asset";
	private static readonly string[] sheetNames = { "Sheet1", };
	
	static void OnPostprocessAllAssets (string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
	{
		foreach (string asset in importedAssets) {
			if (!filePath.Equals (asset))
				continue;
				
			ListCountry data = (ListCountry)AssetDatabase.LoadAssetAtPath (exportPath, typeof(ListCountry));
			if (data == null) {
				data = ScriptableObject.CreateInstance<ListCountry> ();
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

					ListCountry.Sheet s = new ListCountry.Sheet ();
					s.name = sheetName;
				
					for (int i=1; i<= sheet.LastRowNum; i++) {
						IRow row = sheet.GetRow (i);
						ICell cell = null;
						
						ListCountry.Param p = new ListCountry.Param ();
						
					cell = row.GetCell(0); p.int_CountryState = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(1); p.int_CountryNo = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(2); p.string_CountryName = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(3); p.int_AreaNo = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(4); p.string_AreaName = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(5); p.int_UnemployedNum = (int)(cell == null ? 0 : cell.NumericCellValue);
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
