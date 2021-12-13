using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class moveicon_ishikado : MonoBehaviour
{
	public Button[] button_ishikado = new Button[1];

	Collider2D col;

	//�@�A�C�R����1�b�Ԃɉ��s�N�Z���ړ����邩
	[SerializeField]
	private float iconSpeed = Screen.width;
	//�@�A�C�R���̃T�C�Y�擾�Ŏg�p
	private RectTransform rect;
	//�@�A�C�R������ʓ��Ɏ��܂�ׂ̃I�t�Z�b�g�l
	private Vector2 offset;

	void Start()
	{
		rect = GetComponent<RectTransform>();
		//�@�I�t�Z�b�g�l���A�C�R���̃T�C�Y�̔����Őݒ�
		offset = new Vector2(rect.sizeDelta.x / 2f, rect.sizeDelta.y / 2f);
	}

	void Update()
	{
		//�@�ړ��L�[�������Ă��Ȃ���Ή������Ȃ�
		if (Mathf.Approximately(Input.GetAxis("Horizontal"), 0f) && Mathf.Approximately(Input.GetAxis("Vertical"), 0f))
		{
			return;
		}
		//�@�ړ�����v�Z
		var pos = rect.anchoredPosition + new Vector2(Input.GetAxis("Horizontal") * iconSpeed, Input.GetAxis("Vertical") * iconSpeed) * Time.deltaTime;

		//�@�A�C�R������ʊO�ɏo�Ȃ��悤�ɂ���
		pos.x = Mathf.Clamp(pos.x, -Screen.width * 0.5f + offset.x, Screen.width * 0.5f - offset.x);
		pos.y = Mathf.Clamp(pos.y, -Screen.height * 0.5f + offset.y, Screen.height * 0.5f - offset.y);
		//�@�A�C�R���ʒu��ݒ�
		rect.anchoredPosition = pos;

		OnTriggerStay2D(col);
	}

	void OnTriggerStay2D(Collider2D col)
    {
		Debug.Log(col);
    }
}
