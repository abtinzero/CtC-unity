using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public abstract class GameController : MonoBehaviour
{
    [SerializeField] protected Text Timer;
    [SerializeField] protected Text Count;
    [SerializeField] protected Text Finish;
    [SerializeField] protected Transform prefab;

    public static int Points = 0;

    // Start is called before the first frame update
    protected virtual void Awake()
    {
    }

    protected virtual void Update()
    {
        CircleBehaviour circle;
        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        mouseRay.direction *= 10;

        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(mouseRay, out RaycastHit hit))
            {
                circle = hit.transform.GetComponent<CircleBehaviour>();
                if (circle != null)
                    OnCircleHit(circle);
                else
                    OnBackgroundHit();
            }
        }
    }

    protected virtual void OnCircleHit(CircleBehaviour circle)
    {
        Points++;
        circle.OnHit();
    }

    protected virtual void OnBackgroundHit()
    {
    }

    public void Gameover()
    {
        Points = 0;
        SceneManager.LoadScene("MainMenu");
    }

    public void GenerateCircle()
    {
        Instantiate(prefab, Random.insideUnitCircle * 2, Quaternion.identity);
    }
}
