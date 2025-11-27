using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI timertxt;

    public Button startBtn;

    private float startTime;

    private bool started;

    public AudioSource maudio;

    public Fire[] allfires;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startBtn.onClick.AddListener(onStartClick);
    }

    private void onStartClick()
    {
        started = true;
        startTime = 0;
        maudio.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (started)
        {
            startTime += Time.deltaTime;
            timertxt.text = startTime.ToString("F1");

            bool ison = false;
            foreach (Fire fire in allfires)
            {
                if (fire.gameObject.activeSelf)
                {
                    ison = true;
                    break;
                }
            }

            if (!ison)
            {
                started = false;
                maudio.Stop();
            }
        }
    }
}