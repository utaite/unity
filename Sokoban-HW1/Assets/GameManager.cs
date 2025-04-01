using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public InputActionReference space;
    public GameObject winUI;
    public ItemBox[] itemsBoxes;
    public bool isGameOver;

    void Start()
    {
        isGameOver = false;
    }

    void Update()
    {
        if (space.action.ReadValue<float>() > 0)
        {
            SceneManager.LoadScene(0);
        }

        if (isGameOver)
        {
            return;
        }

        if (itemsBoxes.All((x) => x.IsOveraped()))
        {
            isGameOver = true;
            winUI.SetActive(true);
        }
    }
}
