using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{


    public TMP_Text textscore;

    private int intscore;

    public TMP_Text textlevel;

    private int intlevel;
    
    private static GameController gcInstance;

    private int intdeaths;

    public TMP_Text highscore;

    public TMP_Text highlevel;

    public AudioSource audiosource;

    public Button button;
    public TMP_Text buttontext;

    void Awake(){
        DontDestroyOnLoad (this);

        if (gcInstance == null) {
            gcInstance = this;
        } 
        else {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        intscore = 0;
        textscore.text = intscore.ToString();

        intlevel = 1;
        textlevel.text = intlevel.ToString();

        highscore.text = getHighScore().ToString();
        highlevel.text = getHighLevel().ToString();

        audiosource.mute = false;
        gcInstance.button.interactable = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevel()
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        ++gcInstance.intlevel;
        gcInstance.textlevel.text = gcInstance.intlevel.ToString();

        //si es ultim nivell canvi de musica

        if (gcInstance.intlevel == 12)
        {
            gcInstance.audiosource.mute = true;
            gcInstance.button.interactable = false;
            gcInstance.buttontext.text = "";
        }

        int recordlvl = getHighLevel();

        if (gcInstance.intlevel == recordlvl)
        {
            int recordscore = getHighScore();

            if (gcInstance.intscore < recordscore)
            {
                setHighScore(gcInstance.intscore);
                gcInstance.highscore.text = gcInstance.intscore.ToString();
            }
            
        }
        else if (gcInstance.intlevel > recordlvl)
        {
            setHighLevel(gcInstance.intlevel);
            gcInstance.highlevel.text = gcInstance.intlevel.ToString();

            setHighScore(gcInstance.intscore);
            gcInstance.highscore.text = gcInstance.intscore.ToString();
        }


    }

    //es crida quan mors
    public void Death()
    {
        ++gcInstance.intscore;
        gcInstance.textscore.text = gcInstance.intscore.ToString();

    }

    private void setHighScore(int score)
    {
        PlayerPrefs.SetInt("HighScore", score);
    }

    private int getHighScore()
    {
        return PlayerPrefs.GetInt("HighScore", 0);
    }

    private void setHighLevel(int level)
    {
        PlayerPrefs.SetInt("Level", level);
    }

    private int getHighLevel()
    {
        return PlayerPrefs.GetInt("Level", 1);
    }

}
