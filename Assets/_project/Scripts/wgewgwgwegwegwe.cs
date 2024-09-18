using UnityEngine;
using wgewgwegewgwe.Utility.Singleton;

namespace _project.Scripts
{
    public sealed class wgewgwgwegwegwe : ewregtrhngjm<wgewgwgwegwegwe>
    {
        [SerializeField] private AudioSource musicSource;
        [SerializeField] private AudioSource pressSource;
        [SerializeField] private AudioSource takePuzzleSource;
        [SerializeField] private AudioSource puzzleMatchSource;

        public override void Awake()
        {
            base.Awake();
            SetGameMusicVolumeSync(PlayerPrefs.GetInt("Music", 1) == 1 ? 0.5f : 0);
            SetGameEffectsVolumeSync(PlayerPrefs.GetInt("Effects", 1) == 1 ? 0.5f : 0);
        }

        public void SetGameMusicVolumeSync(float v)
        {
            musicSource.volume = v;
        }

        public void SetGameEffectsVolumeSync(float v)
        {
            pressSource.volume = v;
            takePuzzleSource.volume = v;
            puzzleMatchSource.volume = v;
        }

        public override void OnDestroy()
        {
            PlayerPrefs.SetInt("Music", musicSource.volume > 0 ? 1 : 0);
            PlayerPrefs.SetInt("Effects", pressSource.volume > 0 ? 1 : 0);

            PlayerPrefs.Save();
        }

        public void PlayPressSoundSync() => pressSource.Play();
        public void PlayTakePuzzleSound() => takePuzzleSource.Play();
        public void PlayMuzzleMatchSound() => puzzleMatchSource.Play();
    }
}