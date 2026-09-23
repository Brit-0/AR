using UnityEngine;

public class ChooseHouse : MonoBehaviour
{
    [SerializeField] private Transform imageTarget;
    private int numberOfHouses = 3;
    private int currentIndex = 0;

    public void NextHouse()
    {
        imageTarget.GetChild(currentIndex).gameObject.SetActive(false);
        currentIndex++;
        if (currentIndex >= numberOfHouses) currentIndex = 0;
        imageTarget.GetChild(currentIndex).gameObject.SetActive(true);
    }

    public void PreviousHouse()
    {
        imageTarget.GetChild(currentIndex).gameObject.SetActive(false);
        currentIndex--;
        if (currentIndex < 0) currentIndex = 0;
        imageTarget.GetChild(currentIndex).gameObject.SetActive(true);
    }
}
