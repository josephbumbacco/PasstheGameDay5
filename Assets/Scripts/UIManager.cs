using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject player, ammoSlots;
    private Player playerScript;
    public Image healthDie;
    public List<Image> gunChambers, gunAmmoLoaded;
    private Color ammoColor;
    public List<int> gunChamberStorage;
    private int ammoValue, ammoSlot;
    public Sprite emptyChamber, loadedChamber;
    public List<Sprite> healthDice;

    private string currentSceneName;

    public TMP_Text gameOver;

    public void Start()
    {
        //playerScript = player.GetComponent<Player>();
        //ammoColor.a = 1;
        ammoSlot = 0;
        currentSceneName = SceneManager.GetActiveScene().name;
    }

    public void HealthChange(int currentHealth)
    {
        if (currentHealth > 0)
            healthDie.sprite = healthDice[currentHealth - 1];
        /*else
            SceneManager.LoadScene(currentSceneName);*/
    }

    public void RotateBarrel(int currentShot)
    {
        gunChambers[currentShot].sprite = emptyChamber;
        ammoSlots.transform.rotation = Quaternion.Euler(0f, 0f, (currentShot + 1) * 60f);
    }

    public void AmmoUpdate(List<int> chamberValues)
    {
        gunChamberStorage = chamberValues;
            foreach (int ammoValue in chamberValues)
            {
                switch (ammoValue)
                {
                    case 0:
                        gunChambers[ammoSlot].sprite = loadedChamber;
                        gunChambers[ammoSlot].color = new Color(1f, 0.13f, 0.27f, 1f);
                        ammoSlot++;
                        break;
                    case 1:
                        gunChambers[ammoSlot].sprite = loadedChamber;
                        gunChambers[ammoSlot].color = new Color(0.97f, 1f, 0.55f, 1f);
                        ammoSlot++;
                        break;
                    case 2:
                        gunChambers[ammoSlot].sprite = loadedChamber;
                        gunChambers[ammoSlot].color = new Color(0.39f, 0.25f, 0.84f, 1f);
                        ammoSlot++;
                        break;
                    case 3:
                        gunChambers[ammoSlot].sprite = loadedChamber;
                        gunChambers[ammoSlot].color = new Color(0.75f, 0.69f, 0.03f, 1f);
                        ammoSlot++;
                        break;
                    case 4:
                        gunChambers[ammoSlot].sprite = loadedChamber;
                        gunChambers[ammoSlot].color = new Color(0.48f, 0.83f, 0.95f, 1f);
                        ammoSlot++;
                        break;
                    case 5:
                        gunChambers[ammoSlot].sprite = loadedChamber;
                        gunChambers[ammoSlot].color = new Color(0.89f, 0.38f, 0.20f, 1f);
                        ammoSlot++;
                        break;
                    default:
                        break;
                }
        }
        ammoSlot = 0;
    }
}
