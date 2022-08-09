using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{     
    [SerializeField] private TextMeshProUGUI currentNumberText;
    [SerializeField] private Transform centerPoint;

    [SerializeField] private TextMeshProUGUI enemyTarget1Text;
    [SerializeField] private Transform enemyTarget1;    
    [SerializeField] public int enemyTarget1Number;

    [SerializeField] private TextMeshProUGUI enemyTarget2Text;
    [SerializeField] private Transform enemyTarget2;
    [SerializeField] public int enemyTarget2Number;

    [SerializeField] private TextMeshProUGUI enemyTarget3Text;
    [SerializeField] private Transform enemyTarget3;
    [SerializeField] public int enemyTarget3Number;

    [SerializeField] private TextMeshProUGUI enemyTarget4Text;
    [SerializeField] private Transform enemyTarget4;
    [SerializeField] public int enemyTarget4Number;

    private SpawnManager spawnManager;
    private PlayerSwipeControl playerSwipeControl;

    private void Awake()
    {
        spawnManager = FindObjectOfType<SpawnManager>();
        playerSwipeControl = FindObjectOfType<PlayerSwipeControl>();
    }       

    private void LateUpdate()
    {
        CurrentPlayerNumber();
        EnemyTargetNumber(enemyTarget1, enemyTarget1Number, enemyTarget1Text);
        EnemyTargetNumber(enemyTarget2, enemyTarget2Number, enemyTarget2Text);
        EnemyTargetNumber(enemyTarget3, enemyTarget3Number, enemyTarget3Text);
        EnemyTargetNumber(enemyTarget4, enemyTarget4Number, enemyTarget4Text);
    }
    private void CurrentPlayerNumber()
    {
        currentNumberText.transform.position = new Vector3(centerPoint.position.x, centerPoint.position.y+2.5f, centerPoint.position.z-1.0f);
        currentNumberText.text = spawnManager.currentPlayerNumber.ToString();        
    }

    private void EnemyTargetNumber(Transform enemyTarget,int enemyTargetNumber,TextMeshProUGUI enemyTargetText)
    {
        if (enemyTarget != null)
        {
            if (enemyTargetNumber < 1)
            {
                Destroy(enemyTargetText);
                Destroy(enemyTarget.gameObject);
                StartCoroutine(UseSwipe());
            }

            enemyTargetText.transform.position = new Vector3(enemyTarget.position.x, enemyTarget.position.y+3.0f, enemyTarget.position.z+1.5f);
            enemyTargetText.text = enemyTargetNumber.ToString();           
        }               
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator UseSwipe()
    {
        yield return new WaitForSeconds(0.2f);
        playerSwipeControl.canUseSwipe = true;
    }
}
