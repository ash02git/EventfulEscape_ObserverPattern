using UnityEngine;

public class LightsOffByGhostEvent : MonoBehaviour
{
    [SerializeField] private int keysRequiredToTrigger;
    [SerializeField] private SoundType soundType;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<PlayerView>()!=null && GameService.Instance.GetPlayerController().KeysEquipped>=keysRequiredToTrigger)
        {
            EventService.Instance.OnLightsOffByGhostEvent.InvokeEvent();
            GameService.Instance.GetSoundView().PlaySoundEffects(soundType);

            this.gameObject.SetActive(false);
        }
    }
}