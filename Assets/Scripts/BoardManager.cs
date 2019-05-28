using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class Board
{
    public readonly int LENGTH = 4;
    private int[,] value;
    public int score;

    public Board()
    {
        value = new int[LENGTH, LENGTH];
        for (int i = 0; i < LENGTH; i++)
        {
            for (int j = 0; j < LENGTH; j++)
            {
                value[i, j] = 0;
            }
        }
        newPut();
        newPut();
        score = 0;
    }

    //2048 판에서 빈 칸 반환
    public int[] emptyCell()
    {
        ArrayList list_cell = new ArrayList();
        for (int i = 0; i < LENGTH; i++)
        {
            for (int j = 0; j < LENGTH; j++)
            {
                if (value[i, j] == 0) list_cell.Add(i * LENGTH + j);
            }
        }
        return (int[])list_cell.ToArray(typeof(int));
    }

    //2048 판이 빈 칸을 가지고 있는지
    public bool hasEmptyCell()
    {
        return emptyCell().Length > 0;
    }

    //2048 판에 새 블럭(숫자)을 넣기
    public void newPut()
    {
        if (hasEmptyCell() == false)
        {
            return;
        }

        int[] emptyc_arr = emptyCell();
        int putCell_Idx = emptyc_arr[Random.Range(0, emptyc_arr.Length)];
        value[putCell_Idx / LENGTH, putCell_Idx % LENGTH] = 2;
        
    }

    public void printBoard()
    {
        Debug.Log("board:" + value);
        Debug.Log("score:" + score);
    }

    public void gravity(char way)
    {
        
    }

    public int[,] exportBoard()
    {
        return value;
    }
}