using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heo_StageManager_1_1 : MonoBehaviour
{
    [Header("진행 상황")]
    public StageManagerAssist stagemanager;

    [Header("몬스터 종류")]
    public GameObject MonsterBoomer;
    public GameObject MonsterJumper;

    [Header("중간 문들")]
    public GameObject middleDoor_0;
    public GameObject middleDoor_1;
    public GameObject middleDoor_2;

    [Header("스폰 위치")]
    public Transform[] spawnPoint_1;
    public Transform[] spawnPoint_2;

    private void Update()
    {
        if(stagemanager.smallNum >= 3 && stagemanager.bigNum == 0)
        {
            stagemanager.bigNum++;
            stagemanager.smallNum = 0;
            MonsterSpawn_1();
        }

        if (stagemanager.smallNum >= 3 && stagemanager.bigNum == 1)
        {
            stagemanager.bigNum++;
            stagemanager.smallNum = 0;
            MonsterSpawn_2();
        }

        if(stagemanager.smallNum >= 3 && stagemanager.bigNum == 2)
        {
            stagemanager.bigNum++;
            stagemanager.smallNum = 0;
            middleDoor_1.SetActive(false);
        }


        if (stagemanager.smallNum >= 3 && stagemanager.bigNum == 3)
        {
            OpenNextStage();
        }

    }

    public void MonsterSpawn_0()
    {
        middleDoor_0.SetActive(true);

        Instantiate(MonsterBoomer, spawnPoint_1[0].position, Quaternion.identity);
        Instantiate(MonsterBoomer, spawnPoint_1[2].position, Quaternion.identity);
        Instantiate(MonsterBoomer, spawnPoint_1[4].position, Quaternion.identity);
    }


    private void MonsterSpawn_1()
    {
        Instantiate(MonsterBoomer, spawnPoint_1[1].position, Quaternion.identity);
        Instantiate(MonsterJumper, spawnPoint_1[3].position, Quaternion.identity);
        Instantiate(MonsterBoomer, spawnPoint_1[5].position, Quaternion.identity);
    }

    private void MonsterSpawn_2()
    {
        Instantiate(MonsterJumper, spawnPoint_1[0].position, Quaternion.identity);
        Instantiate(MonsterBoomer, spawnPoint_1[2].position, Quaternion.identity);
        Instantiate(MonsterJumper, spawnPoint_1[4].position, Quaternion.identity);


    }

    public void MonsterSpawn_3()
    {
        middleDoor_1.SetActive(true);

        Instantiate(MonsterJumper, spawnPoint_2[0].position, Quaternion.identity);
        Instantiate(MonsterBoomer, spawnPoint_2[1].position, Quaternion.identity);
        Instantiate(MonsterJumper, spawnPoint_2[2].position, Quaternion.identity);
    }

    private void OpenNextStage()
    {
        middleDoor_2.SetActive(false);
    }

}
