using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [SerializeField] private Player_Watanabe player;
    [SerializeField] private Vector3 scale;
    [SerializeField] private Vector3 Maxscale;

    [SerializeField] private int playerOldHp;

    // Start is called before the first frame update
    void Start()
    {
        Maxscale = this.transform.localScale;
        scale = Maxscale;
        playerOldHp = player.m_Hp;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerOldHp == player.m_Hp)
        {

        }
        else
        {
            Debug.Log("Lifeèàóù");
            if (player.m_Hp == 0)
            {
            }
            else
            {
                scale.x = (player.m_Hp - Maxscale.x) / player.m_MaxHp;
                this.gameObject.transform.localScale = scale;
            }
            playerOldHp = player.m_Hp;
        }
    }
}
