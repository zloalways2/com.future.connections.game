using System;
using UnityEngine;
using wgewgwegewgwe.UIBuilder.AddOns.Button;
using wgewgwegewgwe.UIBuilder.Core;
using wgewgwegewgwe.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class wgwegwgwegweg : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn exitButton;
        [SerializeField] private qrewtgrehtrjmyt music;
        [SerializeField] private qrewtgrehtrjmyt sound;

        public event Action egwegwegwe
        {
            add => exitButton.wgwegwegweg += value;
            remove => exitButton.wgwegwegweg += value;
        }

        protected override void qewretgryht()
        {
            {
                var isEnabled = PlayerPrefs.GetInt("Music", 1) == 1;
                music.IsActive = isEnabled;
                music.qewghretr();
            }
            
            {
                var isEnabled = PlayerPrefs.GetInt("Effects", 1) == 1;
                sound.IsActive = isEnabled;
                sound.qewghretr();
            }

            music.OnUpdate += b =>
            {
                var v = b ? 0.5f : 0;
                wgewgwgwegwegwe.ewregtrh.SetGameMusicVolumeSync(v);
            };
            
            sound.OnUpdate += b =>
            {
                var v = b ? 0.5f : 0;
                wgewgwgwegwegwe.ewregtrh.SetGameEffectsVolumeSync(v);
            };
        }


        
        protected override void ewregtrhnht()
        {
            qewrfegtrfhng.ewregtrh.ewregthrnhg<BackgroundScreen>().ShowBlur();
            music.qrewtgrehtrn();
            sound.qrewtgrehtrn();
        }
    }
}