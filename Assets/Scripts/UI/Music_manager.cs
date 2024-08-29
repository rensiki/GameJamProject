using UnityEngine;
using UnityEngine.UI;

public class Music_Manager : MonoBehaviour
{
    private AudioSource audioSource;
    public Slider volumeSlider;
    public GameObject optionsPanel;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();

        // 슬라이더의 값을 AudioSource의 볼륨으로 설정
        volumeSlider.value = audioSource.volume;
        volumeSlider.onValueChanged.AddListener(SetVolume);
        optionsPanel.SetActive(false); // 시작 시 패널 비활성화
    }

    public void ToggleOptions()
    {
        optionsPanel.SetActive(!optionsPanel.activeSelf);
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }

    public void CloseOptions()
    {
        optionsPanel.SetActive(false);
    }
}
