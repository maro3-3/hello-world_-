using UnityEngine;
using System.Collections;
using System.IO;
using UnityEditor;
using System.Xml.Serialization;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
using NPOI.SS.UserModel;

public class List_manufacturer_importer : AssetPostprocessor {
	private static readonly string filePath = "Assets/DataList/List_manufacturer.xls";
	private static readonly string exportPath = "Assets/Resources/List_manufacturer.asset";
	private static readonly string[] sheetNames = { "Sheet1", };
	
	static void OnPostprocessAllAssets (string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths)
	{
		foreach (string asset in importedAssets) {
			if (!filePath.Equals (asset))
				continue;
				
			ListManufacture data = (ListManufacture)AssetDatabase.LoadAssetAtPath (exportPath, typeof(ListManufacture));
			if (data == null) {
				data = ScriptableObject.CreateInstance<ListManufacture> ();
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

					ListManufacture.Sheet s = new ListManufacture.Sheet ();
					s.name = sheetName;
				
					for (int i=1; i<= sheet.LastRowNum; i++) {
						IRow row = sheet.GetRow (i);
						ICell cell = null;
						
						ListManufacture.Param p = new ListManufacture.Param ();
						
					cell = row.GetCell(0); p.int_CountryNo = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(1); p.int_AreaNo = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(2); p.int_ManufacturerNo = (int)(cell == null ? 0 : cell.NumericCellValue);
					cell = row.GetCell(3); p.string_ManufacturerName = (cell == null ? "" : cell.StringCellValue);
					cell = row.GetCell(4); p.int_Products = (int)(cell == null ? 0 : cell.NumericCellValue);
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
