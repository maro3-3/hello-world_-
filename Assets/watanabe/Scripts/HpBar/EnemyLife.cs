using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLife : MonoBehaviour
{

    [SerializeField] private Enemy enemy;
    [SerializeField] private Vector3 scale;
    [SerializeField] private Vector3 Maxscale;

    [SerializeField] private int enemyOldHp;

    // Start is called before the first frame update
    void Start()
    {
        Maxscale = this.transform.localScale;
        scale = Maxscale;
        enemyOldHp = enemy.m_Hp;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyOldHp == enemy.m_Hp)
        {

        }
        else
        {
            Debug.Log("Lifeèàóù");
            if (enemy.m_Hp == 0)
            {
            }
            else
            {
                scale.x = (enemy.m_Hp - Maxscale.x) / enemy.m_MaxHp;
                this.gameObject.transform.localScale = scale;
            }
            enemyOldHp = enemy.m_Hp;
        }
    }
}
