using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitBeh : MonoBehaviour {
    private int game;
    private int winner;
    private int[][] visit;
    public GameObject start;
    public GameObject audio1;
    public GameObject audio2;
    public GameObject end;
    private int count;
    bool play1 = false;
    bool play2 = false;
    public Texture2D pic1;
    public Texture2D pic2;

	// Use this for initialization
	void Start () {
        winner = -1;
        Reset();
	}

    void Reset()
    {
        game = 1;
        visit = new int[3][];
        for (int i = 0; i < 3; i++)
            visit[i] = new int[3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
               visit[i][j] = 0;
            }
        }
        count = 0;
    }
	
	// Update is called once per frame
	void OnGUI() {
        int check = Check();
        if (check == -1)
        {
            GUIStyle fontPic = new GUIStyle();
            fontPic.fontSize = 30;
            GUI.Label(new Rect(0, 0, 100, 100), pic1);
            GUI.Label(new Rect(100, 0, 100, 100), "Player1", fontPic);
            GUI.Label(new Rect(0, 100, 100, 100), pic2);
            GUI.Label(new Rect(100, 100, 100, 100), "Player2", fontPic);
            if (GUI.Button(new Rect(300, 180, 200, 200), "Start Game"))
            {
                winner = 0;
                start.GetComponent<AudioSource>().Play();
            }
        }
        if (check == 0)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int horizontal = 250 + 100 * j;
                    int vertical = 140 + 100 * i;
                    if (visit[i][j] == 1)
                        GUI.Button(new Rect(horizontal, vertical, 100, 100), pic1);
                    if (visit[i][j] == 2)
                        GUI.Button(new Rect(horizontal, vertical, 100, 100), pic2);
                    if (GUI.Button(new Rect(horizontal, vertical, 100, 100), ""))
                    {
                        if (game == 1)
                        {
                            audio1.GetComponent<AudioSource>().Play();
                            visit[i][j] = 1;
                        }
                        if (game == -1)
                        {
                           audio2.GetComponent<AudioSource>().Play();
                            visit[i][j] = 2;
                        }
                        game = -game;
                    }
                }
            }
        }
        else if (check != -1)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int horizontal = 250 + 100 * j;
                    int vertical = 140 + 100 * i;
                    if (visit[i][j] == 1)
                        GUI.Button(new Rect(horizontal, vertical, 100, 100), pic1);
                    if (visit[i][j] == 2)
                        GUI.Button(new Rect(horizontal, vertical, 100, 100), pic2);
                    if (visit[i][j] == 0)
                        GUI.Button(new Rect(horizontal, vertical, 100, 100), "");
                }
            }
        }

        GUIStyle font = new GUIStyle();
        font.fontSize = 40;
        if (check == 1)
        {
            GUI.Label(new Rect(280, 0, 200, 100), "Player1 Win!", font);
            if (count < 10)
                count++;
            musicPlay();
        }

        if (check == 2)
        {
            GUI.Label(new Rect(280, 0, 200, 100), "Player2 Win!", font);
            if (count < 10)
                count++;
            musicPlay();
        }

        if (check != -1)
        {
            if (GUI.Button(new Rect(350, 500, 100, 50), "RESET"))
            {
                start.GetComponent<AudioSource>().Play();
                Reset();
            }
        }
    }

    int Check()
    {
        if (winner != -1)
        {
            winner = 0;
            for (int i = 0; i < 3; i++)
            {
                if (visit[i][0] != 0 && visit[i][0] == visit[i][1] && visit[i][1] == visit[i][2])
                    winner = visit[i][0];
                if (visit[0][i] != 0 && visit[0][i] == visit[1][i] && visit[1][i] == visit[2][i])
                    winner = visit[i][0];
            }
            if (visit[0][0] != 0 && visit[0][0] == visit[1][1] && visit[1][1] == visit[2][2])
                winner = visit[0][0];
            if (visit[0][2] != 0 && visit[0][2] == visit[1][1] && visit[1][1] == visit[2][0])
                winner = visit[0][2];
        }

        return winner;
    }

    void musicPlay()
    {
        if (count == 1)
            end.GetComponent<AudioSource>().Play();
    }
}
