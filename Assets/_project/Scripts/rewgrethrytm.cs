using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using wgewgwegewgwe.UIBuilder.AddOns.Button;
using wgewgwegewgwe.UIBuilder.Core.UIElements;

namespace _project.Scripts
{
    public sealed class rewgrethrytm : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn exitButton;
        [SerializeField] private rewgrehtrn settingsButton;
        [SerializeField] private kiujyhtgrfedw gameView;
        [SerializeField] private kiujyhtgrfedw winView;
        [SerializeField] private rewgrehtrn nextButton;
        [SerializeField] private rewgrehtrn menuButton;
        [SerializeField] private List<StoneToSprite> stone2Type = new List<StoneToSprite>();
        [SerializeField] private Image stonePrefab;
        [SerializeField] private Image linePrefab;
        [SerializeField] private RectTransform startPosition;
        [SerializeField] private Vector2 tileOffset;
        [SerializeField] private List<egwegwegwegewg> tiles = new List<egwegwegwegewg>();
        [SerializeField] private Sprite downUpSprite;
        [SerializeField] private Sprite centerUpSprite;
        [SerializeField] private Sprite downRightSprite;
        [SerializeField] private Sprite downLeftSprite;
        [SerializeField] private Transform linesContainer;
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI timeText;
        [SerializeField] private TextMeshProUGUI headerText;
        [SerializeField] private TextMeshProUGUI winPopupLevel0;
        [SerializeField] private TextMeshProUGUI winPopupLevel1;


        private CancellationTokenSource sgdhfgm;
        private List<Image> wegrhentr = new List<Image>();
        private List<Image> ewgrehntr = new List<Image>();


        private List<Vector2Int> qewghrent = new List<Vector2Int>();
        private List<Vector2Int> ewgrhnt = new List<Vector2Int>();
        private bool qewgrehtnr;
        private rtehg rjtherg;
        private Color rthe;
        private ewgwegwegewgw ewgrhetnr;

        private int newr;

        public event Action ewtgrehtrymt
        {
            add => exitButton.wgwegwegweg += value;
            remove => exitButton.wgwegwegweg += value;
        }

        public event Action rewgrehtrn
        {
            add => settingsButton.wgwegwegweg += value;
            remove => settingsButton.wgwegwegweg += value;
        }

        public event Action ewtgrehtrnm
        {
            add => nextButton.wgwegwegweg += value;
            remove => nextButton.wgwegwegweg += value;
        }

        public event Action ewgrehtnrmy
        {
            add => menuButton.wgwegwegweg += value;
            remove => menuButton.wgwegwegweg += value;
        }


        public event Action<ewgwegwegewgw> ewrhtrnmyt;

        [SerializeField] private bool DEBUG_FINISH;


        protected override void qewretgryht()
        {
            for (int i = 0; i < tiles.Count; i++)
            {
                const int mryntrnen = 7;
                tiles[i].rnerere(i % mryntrnen, mryntrnen - ((i - i % mryntrnen) / mryntrnen) - 1, this);
            }
        }

        public async void ewgrhetnrmh(ewgwegwegewgw data, bool looped)
        {
            this.ewgrhetnr = data;
            gameView.ewregtrhng();
            winView.qweregtrhytn();

            sgdhfgm?.Cancel();
            sgdhfgm = new CancellationTokenSource();

            var wegrhent = looped ? data.id + 6 : data.id;
            headerText.text = $"{wegrhent} level";
            winPopupLevel0.text = wegrhent.ToString();
            winPopupLevel1.text = wegrhent.ToString();
            
            while (wegrhentr.Count > 0)
            {
                DestroyImmediate(wegrhentr[0].gameObject);
                wegrhentr.RemoveAt(0);
            }

            newr = 0;
            ewgrhnt.Clear();
            while (linesContainer.childCount > 0)
            {
                DestroyImmediate(linesContainer.GetChild(0).gameObject);
            }

            foreach (var ghwegwe in data.Stones)
            {
                var qwgwegweg = Instantiate(stonePrefab, gameView.transform);
                qwgwegweg.sprite = stone2Type.Find(t => t.Type == ghwegwe.Type).Sprite;
                qwgwegweg.rectTransform.anchoredPosition = startPosition.anchoredPosition + new Vector2(tileOffset.x * ghwegwe.Position.x, tileOffset.y * ghwegwe.Position.y);
                wegrhentr.Add(qwgwegweg);
            }

            var eehwgwegwegw = 0f;

            var whwehwegwe = data.Stones.Count / 2;
            while (newr < whwehwegwe && DEBUG_FINISH == false)
            {
                await UniTask.Yield(sgdhfgm.Token)
                    .SuppressCancellationThrow();

                eehwgwegwegw += Time.deltaTime;
                scoreText.text = $"{newr * 400} / {whwehwegwe * 400}";

                int minutes = (int) eehwgwegwegw / 60;
                int remainingSeconds = (int) eehwgwegwegw % 60;
                timeText.text = $"{minutes:D2}:{remainingSeconds:D2}";

                if (sgdhfgm.Token.IsCancellationRequested)
                    return;
            }

            gwegwegweg();
            ewrhtrnmyt?.Invoke(data);

            await UniTask.WaitForSeconds(0.5f);

            gameView.qewregtrhnt();

            await UniTask.WaitForSeconds(0.2f);

            winView.wqeregtrhytng();
        }

        public void gwegwegweg()
        {
            sgdhfgm?.Cancel();
        }


        public void egewgewgewgewg(int egwegewgwe, int egwgwegwegwe)
        {
            var stone = ewgrhetnr.Stones.Find(s => s.Position.x == egwegewgwe && s.Position.y == egwgwegwegwe);

            if (stone == null)
                return;

            rjtherg = stone.Type;
            rthe = stone2Type.Find(t => t.Type == stone.Type).Color;
            qewghrent.Clear();
            qewghrent.Add(new Vector2Int(egwegewgwe, egwgwegwegwe));
            qewgrehtnr = true;
            gwegwegewgewgewgwe(egwegewgwe, egwgwegwegwe);
        }

        public void egwegwegwegweg()
        {
            if (qewgrehtnr)
            {
                ewgrhnt.RemoveAll(d => qewghrent.Contains(d));
                while (ewgrehntr.Count > 0)
                {
                    DestroyImmediate(ewgrehntr[0].gameObject);
                    ewgrehntr.RemoveAt(0);
                }
            }
            
            qewgrehtnr = false;
            qewghrent.Clear();
            ewgrehntr.Clear();
        }

        public void gwgewgwegwegew(int egewgwegew, int wgewgewgewgwe)
        {
            if (qewgrehtnr == false)
                return;

            var p = new Vector2Int(egewgwegew, wgewgewgewgwe);

            if (ewgrhnt.Contains(p))
                return;

            var gwegwegewg = qewghrent[qewghrent.Count - 1];
            var egwegewg = Mathf.Abs(gwegwegewg.x - egewgwegew) + Mathf.Abs(gwegwegewg.y - wgewgewgewgwe);

            if (egwegewg <= 1)
            {
                var egwegwegweg = ewgrhetnr.Stones.FirstOrDefault(s => s.Position.x == egewgwegew && s.Position.y == wgewgewgewgwe);

                if (egwegwegweg != null)
                {
                    if (egwegwegweg.Type == rjtherg)
                    {
                        qewghrent.Add(new Vector2Int(egewgwegew, wgewgewgewgwe));
                        ewgrhnt.Add(new Vector2Int(egewgwegew, wgewgewgewgwe));
                        gwegwegewgewgewgwe(egewgwegew, wgewgewgewgwe);

                        newr++;
                        qewgrehtnr = false;
                        egwegwegwegweg();
                    }

                    return;
                }

                qewghrent.Add(new Vector2Int(egewgwegew, wgewgewgewgwe));
                ewgrhnt.Add(new Vector2Int(egewgwegew, wgewgewgewgwe));
                gwegwegewgewgewgwe(egewgwegew, wgewgewgewgwe);
            }
        }

        private void gwegwegewgewgewgwe(int x, int y)
        {
            var weewgewgewgew = Instantiate(linePrefab, linesContainer);
            weewgewgewgew.rectTransform.anchoredPosition = startPosition.anchoredPosition + new Vector2(tileOffset.x * x, tileOffset.y * y);
            weewgewgewgew.color = rthe;
            ewgrehntr.Add(weewgewgewgew);
            egwegwegweg();
        }

        private void egwegwegweg()
        {
            if (qewghrent.Count <= 1)
                return;

            for (int i = 0; i < qewghrent.Count; i++)
            {
                var egwegwegwe = qewghrent[i];

                if (i == 0)
                {
                    var egwegweg = qewghrent[i + 1];
                    var egwegewgwegew = 0f;
                    if (egwegweg.y > egwegwegwe.y) egwegewgwegew = 0;
                    else if (egwegweg.y < egwegwegwe.y) egwegewgwegew = 180;
                    else if (egwegweg.x > egwegwegwe.x) egwegewgwegew = -90;
                    else if (egwegweg.x < egwegwegwe.x) egwegewgwegew = 90;
                    ewgrehntr[i].sprite = centerUpSprite;
                    ewgrehntr[i].transform.eulerAngles = new Vector3(0, 0, egwegewgwegew);
                    continue;
                }

                var egwegewgw = qewghrent[i - 1];


                if (i == qewghrent.Count - 1)
                {
                    var egwwegewgweg = 0f;
                    if (egwegewgw.y > egwegwegwe.y) egwwegewgweg = 0;
                    else if (egwegewgw.y < egwegwegwe.y) egwwegewgweg = 180;
                    else if (egwegewgw.x > egwegwegwe.x) egwwegewgweg = -90;
                    else if (egwegewgw.x < egwegwegwe.x) egwwegewgweg = 90;
                    ewgrehntr[i].sprite = centerUpSprite;
                    ewgrehntr[i].transform.eulerAngles = new Vector3(0, 0, egwwegewgweg);
                    continue;
                }

                var ewgwegweg = qewghrent[i + 1];


                var gwegwegewg = egwegewgw.x == ewgwegweg.x;
                var wgewgweg = egwegewgw.y == ewgwegweg.y;

                if (gwegwegewg == false && wgewgweg == false)
                {
                    // diagonal

                    var efweweegweg = egwegewgw.x;
                    var egwgwegw = ewgwegweg.x;
                    var gwwegweg = egwegewgw.y;
                    var enrerehre = ewgwegweg.y;


                    var wegwgewgew = egwegewgw.y > egwegwegwe.y;
                    var ewgewgewgw = egwegewgw.y < egwegwegwe.y;

                    var wewgewgweg = egwegewgw.x > egwegwegwe.x;
                    var ewgewgwgew = egwegewgw.x < egwegwegwe.x;

                    var wegwegwe = downUpSprite;
                    var ewgewgewg = new Vector3();


                    if (wegwgewgew && efweweegweg < egwgwegw && gwwegweg > enrerehre)
                    {
                        wegwegwe = downRightSprite;
                        ewgewgewg = new Vector3(0, 0, 90);
                    }

                    else if (wewgewgweg && efweweegweg > egwgwegw && gwwegweg < enrerehre)
                    {
                        wegwegwe = downRightSprite;
                        ewgewgewg = new Vector3(0, 0, 90);
                    }


                    else if (ewgewgwgew && efweweegweg < egwgwegw && gwwegweg < enrerehre)
                    {
                        wegwegwe = downLeftSprite;
                        ewgewgewg = new Vector3(0, 0, -90);
                    }

                    else if (wegwgewgew && efweweegweg > egwgwegw && gwwegweg > enrerehre)
                    {
                        wegwegwe = downLeftSprite;
                        ewgewgewg = new Vector3(0, 0, -90);
                    }


                    else if (ewgewgwgew && efweweegweg < egwgwegw && gwwegweg > enrerehre)
                    {
                        wegwegwe = downLeftSprite;
                        ewgewgewg = new Vector3(0, 0, 0);
                    }

                    else if (ewgewgewgw && efweweegweg > egwgwegw && gwwegweg < enrerehre)
                    {
                        wegwegwe = downLeftSprite;
                        ewgewgewg = new Vector3(0, 0, 0);
                    }


                    else if (ewgewgewgw && efweweegweg < egwgwegw && gwwegweg < enrerehre)
                    {
                        wegwegwe = downRightSprite;
                        ewgewgewg = new Vector3(0, 0, 0);
                    }

                    else if (wewgewgweg && efweweegweg > egwgwegw && gwwegweg > enrerehre)
                    {
                        wegwegwe = downRightSprite;
                        ewgewgewg = new Vector3(0, 0, 0);
                    }


                    ewgrehntr[i].sprite = wegwegwe;
                    ewgrehntr[i].transform.eulerAngles = ewgewgewg;
                }
                else if (gwegwegewg)
                {
                    // vertical
                    ewgrehntr[i].sprite = downUpSprite;
                    ewgrehntr[i].transform.eulerAngles = new Vector3();
                }
                else
                {
                    // horizontal
                    ewgrehntr[i].sprite = downUpSprite;
                    ewgrehntr[i].transform.eulerAngles = new Vector3(0, 0, 90);
                }
            }
        }
    }

    [Serializable]
    public sealed class StoneToSprite
    {
        public rtehg Type;
        public Sprite Sprite;
        public Color Color;
    }

    public enum rtehg
    {
        Cyan,
        Blue,
        Green,
        Orange,
        Pink,
        Purple,
        Red,
    }
}