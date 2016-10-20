using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private string last_key;
    private string previous_key;
    private string no_key;
    private int tp_indice;
    private int tp_indice_;
    private int tm_indice;

    private string[] tableauMouvement = { "", "", "", "" };
    private int[] tableauPosition = { -1, -1, -1, -1 };
    
    [SerializeField] private float moveSpeed;

    void Start()
    {
        last_key = "";
        previous_key = "";
        no_key = "";
        tp_indice = -1;
        tp_indice_ = -1;
        tm_indice = -1;
    }

    void toucheAppuyée()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && last_key != "left" && tableauPosition[0] == -1)
        {
            last_key = "left";
            tp_indice = 0;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && last_key != "right" && tableauPosition[1] == -1)
        {
            last_key = "right";
            tp_indice = 1;
        }
        else if (Input.GetKey(KeyCode.UpArrow) && last_key != "up" && tableauPosition[2] == -1)
        {
            last_key = "up";
            tp_indice = 2;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && last_key != "down" && tableauPosition[3] == -1)
        {
            last_key = "down";
            tp_indice = 3;
        }
    }

    void toucheRelachée()
    {
        if (!(Input.GetKey(KeyCode.LeftArrow)) && tableauPosition[0] != -1)
        {
            no_key = "left";
            tp_indice_ = 0;
        }
        else if (!Input.GetKey(KeyCode.RightArrow) && tableauPosition[1] != -1)
        {
            no_key = "right";
            tp_indice_ = 1;
        }
        else if (!Input.GetKey(KeyCode.UpArrow) && tableauPosition[2] != -1)
        {
            no_key = "up";
            tp_indice_ = 2;
        }
        else if (!Input.GetKey(KeyCode.DownArrow) && tableauPosition[3] != -1)
        {
            no_key = "down";
            tp_indice_ = 3;
        }
        else
        {
            no_key = "";
        }
    }

    void Update()
    {
        toucheAppuyée();
        if (last_key != "" && last_key != previous_key)
        {
            tm_indice = tm_indice + 1;
            tableauMouvement[tm_indice] = last_key;
            tableauPosition[tp_indice] = tm_indice;
            print(tm_indice);
        }

        previous_key = last_key;

        playerMovement();

        toucheRelachée();

        if (no_key != "")
        {
            tableauMouvement[tableauPosition[tp_indice_]] = "";

            if (no_key == last_key && tm_indice > -1)
            {
                while (tm_indice >= 0 && tableauMouvement[tm_indice] == "")
                {
                    tm_indice -= 1;
                }

                if (tm_indice == -1)
                {
                    last_key = "";
                }
                else
                {
                    last_key = tableauMouvement[tm_indice];
                    previous_key = tableauMouvement[tm_indice];
                }
            }

            else if (no_key != last_key)
            {
                for (int i = tableauPosition[tp_indice_]; i < 3; i++)
                {
                    tableauMouvement[i] = tableauMouvement[i + 1];

                    switch (tableauMouvement[i + 1])
                    {
                        case "left":
                            tableauPosition[0] -= 1;
                            break;

                        case "right":
                            tableauPosition[1] -= 1;
                            break;

                        case "up":
                            tableauPosition[2] -= 1;
                            break;

                        case "down":
                            tableauPosition[3] -= 1;
                            break;
                    }
                    tableauMouvement[i + 1] = "";
                }
                tm_indice = tm_indice - 1;
            }
            tableauPosition[tp_indice_] = -1;
        }
    }

    void playerMovement()
    {
        if (tm_indice != -1 && tm_indice < 4)
        {
            switch (tableauMouvement[tm_indice])
            {
                case "left":
                    transform.position += Vector3.left * moveSpeed * Time.deltaTime;
                    break;

                case "right":
                    transform.position += Vector3.right * moveSpeed * Time.deltaTime;
                    break;

                case "up":
                    transform.position += Vector3.up * moveSpeed * Time.deltaTime;
                    break;

                case "down":
                    transform.position += Vector3.down * moveSpeed * Time.deltaTime;
                    break;
            }
        }
    }
}
