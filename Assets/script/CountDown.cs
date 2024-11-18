using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountDown : MonoBehaviour
{
    public float StartTime;//timer countdown from this value
    private float remaintime;

    public TMP_Text TimerText;
    //public TMP_Text SucceedText;
    [SerializeField] GameObject succeed;
    [SerializeField] GameObject firsthide;
    //[SerializeField] GameObject aftercountshow;

    // public AudioSource audioSource;
    //public Button CountdBtn;
    [SerializeField] GameObject CountdBtn;
    //[SerializeField] GameObject showTim;
    //[SerializeField] float timeText; 
    //[SerializeField] GameObject timeText;
    //[SerializeField] float remaintime;
    //int timeInt;
    //float timerFloat;
    //IEnumerator coroutine;
    //bool EnableTimer = false;
    public ParticleSystem smokeEffect;
    // Start is called before the first frame update

    void Update()
    {
        if (remaintime > 0)
        {
            remaintime -= Time.deltaTime;
        }
        else if (remaintime < 0)
        {
            remaintime = 0;
            //TimeUp;
            
            //CountdBtn.gameObject.SetActive(true);
            succeed.gameObject.SetActive(true);
            TimerText.gameObject.SetActive(false);
            firsthide.gameObject.SetActive(false);
            
            smokeEffect.Stop();
            // audioSource.Play();
        }
        int seconds = Mathf.FloorToInt(remaintime % 60);
        TimerText.text = string.Format("{0:00}", seconds);
    }

    public void StartClicked()
    {
        remaintime = StartTime;
        
        CountdBtn.gameObject.SetActive(false);
        succeed.gameObject.SetActive(false);
        TimerText.gameObject.SetActive(true);
        firsthide.gameObject.SetActive(true);
        // audioSource.Stop();
        smokeEffect.Play();
    }
    //void Start()
    //{

    //    timeInt = remaintime;
    //    timerFloat = (float)timeInt;
    //    timeText.text = remaintime.ToString();
    //    showTim.SetActive(true);
    //    startBut.SetActive(false);

    //    coroutine = Countdown();
    //    //cupcoutd.SetActive(false);
    //    //but.SetActive(false);
    //    //timeText.SetActive(false);
    //}

    //public void StartCountd()
    //{
    //    StartCoroutine(coroutine);
    //}

    //public void StopCountd()
    //{
    //    StopCoroutine(coroutine);
    //    showTim.SetActive(false);
    //    startBut.SetActive(true);
    //    this.gameObject.SetActive(false);  
    //}

    //IEnumerator Countdown()
    //{
    //    yield return new WaitForSeconds(1);
    //    while(timerFloat > 0)
    //    {
    //        timerFloat -= Time.deltaTime;

    //        if (timeInt > (int)timerFloat)
    //        {
    //            timeText.text = timeInt.ToString();
    //            timeInt -= 1;
    //        }
    //        yield return null;
    //    }
    //    StopCountd();
    //}
    //void Update()
    //{
    //    //cupcoutd.SetActive(true);
    //    if (EnableTimer)
    //    {
    //        remaintime -= Time.deltaTime;
    //        timetext.text = remaintime.ToString("0");
    //        if(remaintime <= 0)
    //        {
    //            //
    //            //but.SetActive(true);
    //            //cupcoutd.SetActive(false);
    //            EnableTimer = false;
    //        }
    //    }
    //    //else if (remaintime < 0)
    //    //{
    //    //    remaintime = 0;
    //        //cupcoutd.SetActive(false);
    //        //but.SetActive(true);
    //    //}
    //    //int seconds = Mathf.FloorToInt(remaintime % 60);
    //    //timetext.text = string.Format("{0:00}", seconds);
    //}

    //public void OnStartTimer()
    //{
    //    EnableTimer = true;
    //}

    // Update is called once per frame
    //void OpenCupC()
    //{
    //    timeText.text = "";
    //    cupcoutd.SetActive(true);
    //}
}
