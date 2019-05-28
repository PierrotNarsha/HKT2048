using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private Sprite[] sprites=new Sprite[12];
    [SerializeField] private GameObject obj;
    Board b = new Board();
    int size=4;
    int[,] board;
    int score;
    GameObject[,] board_obj=new GameObject[4,4];

    private void Awake()
    {
        board = b.exportBoard();
        for (int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                board_obj[i,j] = Instantiate(obj,new Vector3(j,4-i,0),Quaternion.identity);
                
            }
        }
    }

    void DrawBoard()
    {
        for(int i = 0; i < size; i++)
        {
            for(int j = 0; j < size; j++)
            {
                switch (board[i, j])
                {
                    case 0:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[0];
                        break;
                    case 2:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[1]; break;
                    case 4:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[2]; break;
                    case 8:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[3]; break;
                    case 16:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[4]; break;
                    case 32:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[5]; break;
                    case 64:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[6]; break;
                    case 128:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[7]; break;
                    case 256:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[8]; break;
                    case 512:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[9]; break;
                    case 1024:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[10]; break;
                    case 2048:
                        board_obj[i, j].GetComponent<SpriteRenderer>().sprite = sprites[11]; break;
                }
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int[,] value = new int[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    value[i, j] = 16;
                }
            }
        }
        DrawBoard();
    }
}
