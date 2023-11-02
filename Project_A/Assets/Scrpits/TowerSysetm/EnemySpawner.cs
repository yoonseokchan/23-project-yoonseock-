using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyController[] enemiesToSpawn;        //�������� �迭 ��

    public Transform spawnPoint;

    public float timeBetweenSpawns = 0.5f;                 //���� ���� �ð� 
    private float spawnCounter;                     //���ڸ� ī�����ϴ� ���� �ð�

    public int amountToSpawn = 15;                  //�����ɶ� ���� ����

    void Start()
    {
        spawnCounter = timeBetweenSpawns;
    }
    
    void Update()
    {
        if(amountToSpawn  > 0 ) //�����ִ� ������ ���ڰ� ������
        {
            spawnCounter -= Time.deltaTime;     //�����Ӹ��� �ð��� ���� ��Ŵ
            if(spawnCounter <= 0)               //spawnCount 0�����϶�
            {
                spawnCounter = timeBetweenSpawns;       //������ ���� ���� ���� �ð��� �ٽ� ���� 
                //Random.Range(0, enemiesToSpawn.Length) �迭���� ������ ���ؼ� �������� ���� , ��ġ�� �����̼� ��
                Instantiate(enemiesToSpawn[Random.Range(0, enemiesToSpawn.Length)], spawnPoint.position, spawnPoint.rotation);

                amountToSpawn--;                        //������ ���ڸ� ���ش�. 
            }
        }
    }
}
