using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class iconcheck_ishikado : MonoBehaviour
{

	//　アイテム情報を出力するテキスト
	[SerializeField]
	private Text text;
	private Image image;

	void Start()
	{
		image = GetComponent<Image>();
	}

	//　マウスアイコンが自分のアイコン下に入った時
	void OnTriggerEnter2D(Collider2D col)
	{
		CheckEvent(col);
	}

	//　マウスアイコンが自分のアイコン下にいる間
	void OnTriggerStay2D(Collider2D col)
	{
		CheckEvent(col);
	}

	void CheckEvent(Collider2D col)
	{
		//　アイコンを検知する
		if (col.tag == "/*下のボタンの名前*/")
		{
			//処理
		}
	}

	//　マウスアイコンが自分のアイコン下から出て行った時
	void OnTriggerExit2D(Collider2D col)
	{

		if (col.tag == "/*下のボタンの名前*/")
		{
			//処理
		}
	}
}