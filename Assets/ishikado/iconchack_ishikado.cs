using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class iconcheck_ishikado : MonoBehaviour
{

	//�@�A�C�e�������o�͂���e�L�X�g
	[SerializeField]
	private Text text;
	private Image image;

	void Start()
	{
		image = GetComponent<Image>();
	}

	//�@�}�E�X�A�C�R���������̃A�C�R�����ɓ�������
	void OnTriggerEnter2D(Collider2D col)
	{
		CheckEvent(col);
	}

	//�@�}�E�X�A�C�R���������̃A�C�R�����ɂ����
	void OnTriggerStay2D(Collider2D col)
	{
		CheckEvent(col);
	}

	void CheckEvent(Collider2D col)
	{
		//�@�A�C�R�������m����
		if (col.tag == "/*���̃{�^���̖��O*/")
		{
			//����
		}
	}

	//�@�}�E�X�A�C�R���������̃A�C�R��������o�čs������
	void OnTriggerExit2D(Collider2D col)
	{

		if (col.tag == "/*���̃{�^���̖��O*/")
		{
			//����
		}
	}
}