using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrettyGoodPickOverwatch
{
    public partial class mainForm : Form
    {
        static int healers;
        static int tanks;
        static int damageDealers;
        static int totalCount;

        public bool blockButtons;

        public bool AnaFlag;
        public bool MercyFlag;
        public bool ReaperFlag;
        public bool JunkratFlag;
        public bool DoomfistFlag;
        public bool BastionFlag;
        public bool MeiFlag;
        public bool WidowFlag;
        public bool SymmetraFlag;
        public bool SoldierFlag;
        public bool SombraFlag;
        public bool TorbjornFlag;
        public bool TracerFlag;
        public bool PharraFlag;
        public bool HanzoFlag;
        public bool MccreeFlag;
        public bool AshFlag;
        public bool GenjiFlag;
        public bool ZaryaFlag;
        public bool OrisaFlag;
        public bool ReinhardtFlag;
        public bool WinstonFlag;
        public bool RoadhogFlag;
        public bool TaranFlag;
        public bool DvaFlag;
        public bool BaptistFlag;
        public bool BrigittaFlag;
        public bool ZenyattaFlag;
        public bool LucioFlag;
        public bool MoiraFlag;

        public int MaxHeroPoints = 0;
        public List<string> PrefferableHealers = new List<string>();
        public List<string> PrefferableDDs = new List<string>();
        public List<string> PrefferableTanks = new List<string>();

        public int AnaPoints;
        public int MercyPoints;
        public int ReaperPoints;
        public int JunkratPoints;
        public int DoomfistPoints;
        public int BastionPoints;
        public int MeiPoints;
        public int WidowPoints;
        public int SymmetraPoints;
        public int SoldierPoints;
        public int SombraPoints;
        public int TorbjornPoints;
        public int TracerPoints;
        public int PharraPoints;
        public int HanzoPoints;
        public int MccreePoints;
        public int AshPoints;
        public int GenjiPoints;
        public int ZaryaPoints;
        public int OrisaPoints;
        public int ReinhardtPoints;
        public int WinstonPoints;
        public int RoadhogPoints;
        public int TaranPoints;
        public int DvaPoints;
        public int BaptistPoints;
        public int BrigittaPoints;
        public int ZenyattaPoints;
        public int LucioPoints;
        public int MoiraPoints;

        public mainForm()
        {
            InitializeComponent();
            pictureBox1_Click(new object(), new EventArgs());
        }
        private void AnaPic_Click(object sender, EventArgs e)
        {
            if (!AnaFlag)
            {
                ReinhardtPoints++;
                GenjiPoints++;
                LucioPoints++;
            }
            else
            {
                ReinhardtPoints--;
                GenjiPoints--;
                LucioPoints--;
            }

            string path = @"images\Characters\Ana\Ana";
            healerMethod(AnaPic, AnaFlag, path);
            AnaFlag = !AnaFlag;
        }
        private void AshPic_Click(object sender, EventArgs e)
        {
            if (!AshFlag)
            {
                MercyPoints++;
                ReinhardtPoints++;
                TaranPoints++;
            }
            else
            {
                MercyPoints--;
                ReinhardtPoints--;
                TaranPoints--;
            }

            string path = @"images\Characters\Ash\Ash";
            damageDealerMethod(AshPic, AshFlag, path);
            AshFlag = !AshFlag;
        }
        private void MercyPic_Click(object sender, EventArgs e)
        {
            if (!MercyFlag)
            {
                PharraPoints++;
                BastionPoints++;
                OrisaPoints++;
            }
            else
            {
                PharraPoints--;
                BastionPoints--;
                OrisaPoints--;
            }

            string path = @"images\Characters\Mercy\Mercy";
            healerMethod(MercyPic, MercyFlag, path);
            MercyFlag = !MercyFlag;
        }
        private void ReaperPic_Click(object sender, EventArgs e)
        {
            if (!ReaperFlag)
            {
                MeiPoints++;
                ZenyattaPoints++;
                ZaryaPoints++;
            }
            else
            {
                MeiPoints--;
                ZenyattaPoints--;
                ZaryaPoints--;
            }

            string path = @"images\Characters\Reaper\Reaper";
            damageDealerMethod(ReaperPic, ReaperFlag, path);
            ReaperFlag = !ReaperFlag;
        }
        private void JunkratPic_Click(object sender, EventArgs e)
        {
            if (!JunkratFlag)
            {
                ReinhardtPoints++;
                ZaryaPoints++;
                ReaperPoints++;
            }
            else
            {
                ReinhardtPoints--;
                ZaryaPoints--;
                ReaperPoints--;
            }

            string path = @"images\Characters\Junkrat\Junkrat";
            damageDealerMethod(JunkratPic, JunkratFlag, path);
            JunkratFlag = !JunkratFlag;
        }
        private void DoomfistPic_Click(object sender, EventArgs e)
        {
            if (!DoomfistFlag)
            {
                BastionPoints++;
                MccreePoints++;
                ReaperPoints++;
            }
            else
            {
                BastionPoints--;
                MccreePoints--;
                ReaperPoints--;
            }

            string path = @"images\Characters\Doomfist\Doomfist";
            damageDealerMethod(DoomfistPic, DoomfistFlag, path);
            DoomfistFlag = !DoomfistFlag;
        }
        private void BastionPic_Click(object sender, EventArgs e)
        {
            if (BastionFlag)
            {
                OrisaPoints++;
                MercyPoints++;
                SymmetraPoints++;
            }
            else
            {
                OrisaPoints--;
                MercyPoints--;
                SymmetraPoints--;
            }

            string path = @"images\Characters\Bastion\Bastion";
            damageDealerMethod(BastionPic, BastionFlag, path);
            BastionFlag = !BastionFlag;
        }
        private void MeiPic_Click(object sender, EventArgs e)
        {            
            if (!MeiFlag)
            {
                ReaperPoints++;
                ReinhardtPoints++;
                LucioPoints++;
            }
            else
            {
                ReaperPoints--;
                ReinhardtPoints--;
                LucioPoints--;
            }

            string path = @"images\Characters\Mei\Mei";
            damageDealerMethod(MeiPic, MeiFlag, path);
            MeiFlag = !MeiFlag;
        }
        private void WidowPic_Click(object sender, EventArgs e)
        {
            if (!WidowFlag)
            {
                HanzoPoints++;
                WinstonPoints++;
                DvaPoints++;
            }
            else
            {
                HanzoPoints--;
                WinstonPoints--;
                DvaPoints--;
            }

            string path = @"images\Characters\Widow\Widow";
            damageDealerMethod(WidowPic, WidowFlag, path);
            WidowFlag = !WidowFlag;
        }
        private void SymmetraPic_Click(object sender, EventArgs e)
        {
            if (!SymmetraFlag)
            {
                BastionPoints++;
                OrisaPoints++;
                JunkratPoints++;
            }
            else
            {
                BastionPoints--;
                OrisaPoints--;
                JunkratPoints--;
            }

            string path = @"images\Characters\Symmetra\Symmetra";
            damageDealerMethod(SymmetraPic, SymmetraFlag, path);
            SymmetraFlag = !SymmetraFlag;
        }
        private void SoldierPic_Click(object sender, EventArgs e)
        {
            if (!SoldierFlag)
            {
                SombraPoints++;
                AnaPoints++;
                ReinhardtPoints++;
            }
            else
            {
                SombraPoints--;
                AnaPoints--;
                ReinhardtPoints--;
            }

            string path = @"images\Characters\Soldier\Soldier";
            damageDealerMethod(SoldierPic, SoldierFlag, path);
            SoldierFlag = !SoldierFlag;
        }
        private void SombraPic_Click(object sender, EventArgs e)
        {
            if (!SombraFlag)
            {
                DvaPoints++;
                ZaryaPoints++;
                ReinhardtPoints++;
            }
            else
            {
                DvaPoints--;
                ZaryaPoints--;
                ReinhardtPoints--;
            }

            string path = @"images\Characters\Sombra\Sombra";
            damageDealerMethod(SombraPic, SombraFlag, path);
            SombraFlag = !SombraFlag;
        }
        private void TorbjornPic_Click(object sender, EventArgs e)
        {
            if (!TorbjornFlag)
            {
                ReinhardtPoints++;
                OrisaPoints++;
                JunkratPoints++;
            }
            else
            {
                ReinhardtPoints--;
                OrisaPoints--;
                JunkratPoints--;
            }

            string path = @"images\Characters\Torbjorn\Torbjorn";
            damageDealerMethod(TorbjornPic, TorbjornFlag, path);
            TorbjornFlag = !TorbjornFlag;
        }
        private void TracerPic_Click(object sender, EventArgs e)
        {
            if (!TracerFlag)
            {
                GenjiPoints++;
                WinstonPoints++;
                DvaPoints++;
            }
            else
            {
                GenjiPoints--;
                WinstonPoints--;
                DvaPoints--;
            }

            string path = @"images\Characters\Tracer\Tracer";
            damageDealerMethod(TracerPic, TracerFlag, path);
            TracerFlag = !TracerFlag;
        }
        private void PharraPic_Click(object sender, EventArgs e)
        {
            if (!PharraFlag)
            {
                MercyPoints++;
                ZenyattaPoints++;
                ZaryaPoints++;
            }
            else
            {
                MercyPoints--;
                ZenyattaPoints--;
                ZaryaPoints--;
            }

            string path = @"images\Characters\Pharra\Pharra";
            damageDealerMethod(PharraPic, PharraFlag, path);
            PharraFlag = !PharraFlag;
        }
        private void HanzoPic_Click(object sender, EventArgs e)
        {
            if (!HanzoFlag)
            {
                WidowPoints++;
                MccreePoints++;
                AshPoints++;
            }
            else
            {
                WidowPoints--;
                MccreePoints--;
                AshPoints--;
            }

            string path = @"images\Characters\Hanzo\Hanzo";
            damageDealerMethod(HanzoPic, HanzoFlag, path);
            HanzoFlag = !HanzoFlag;
        }
        private void MccreePic_Click(object sender, EventArgs e)
        {
            if (!MccreeFlag)
            {
                ReaperPoints++;
                ReinhardtPoints++;
                LucioPoints++;
            }
            else
            {
                ReaperPoints--;
                ReinhardtPoints--;
                LucioPoints--;
            }

            string path = @"images\Characters\Mccree\Mccree";
            damageDealerMethod(MccreePic, MccreeFlag, path);
            MccreeFlag = !MccreeFlag;
        }
        private void GenjiPic_Click(object sender, EventArgs e)
        {
            if (!GenjiFlag)
            {
                WinstonPoints++;
                TaranPoints++;
                TracerPoints++;
            }
            else
            {
                WinstonPoints--;
                TaranPoints--;
                TracerPoints--;
            }

            string path = @"images\Characters\Genji\Genji";
            damageDealerMethod(GenjiPic, GenjiFlag, path);
            GenjiFlag = !GenjiFlag;
        }
        private void ZaryaPic_Click(object sender, EventArgs e)
        {
            if (!ZaryaFlag)
            {
                ReinhardtPoints++;
                HanzoPoints++;
                TaranPoints++;
            }
            else
            {
                ReinhardtPoints--;
                HanzoPoints--;
                TaranPoints--;
            }

            string path = @"images\Characters\Zarya\Zarya";
            tankMethod(ZaryaPic, ZaryaFlag, path);
            ZaryaFlag = !ZaryaFlag;
        }
        private void OrisaPic_Click(object sender, EventArgs e)
        {
            if (!OrisaFlag)
            {
                RoadhogPoints++;
                AshPoints++;
                HanzoPoints++;
            }
            else
            {
                RoadhogPoints--;
                AshPoints--;
                HanzoPoints--;
            }

            string path = @"images\Characters\Orisa\Orisa";
            tankMethod(OrisaPic, OrisaFlag, path);
            OrisaFlag = !OrisaFlag;
        }
        private void ReinhardtPic_Click(object sender, EventArgs e)
        {
            if (!ReinhardtFlag)
            {
                ZaryaPoints++;
                AnaPoints++;
                LucioPoints++;
            }
            else
            {
                ZaryaPoints--;
                AnaPoints--;
                LucioPoints--;
            }

            string path = @"images\Characters\Reinhardt\Reinhardt";
            tankMethod(ReinhardtPic, ReinhardtFlag, path);
            ReinhardtFlag = !ReinhardtFlag;
        }
        private void WinstonPic_Click(object sender, EventArgs e)
        {
            if (!WinstonFlag)
            {
                DvaPoints++;
                GenjiPoints++;
                TracerPoints++;
            }
            else
            {
                DvaPoints--;
                GenjiPoints--;
                TracerPoints--;
            }

            string path = @"images\Characters\Winston\Winston";
            tankMethod(WinstonPic, WinstonFlag, path);
            WinstonFlag = !WinstonFlag;
        }
        private void RoadhogPic_Click(object sender, EventArgs e)
        {
            if (!RoadhogFlag)
            {
                OrisaPoints++;
                ZaryaPoints++;
                ZenyattaPoints++;
            }
            else
            {
                OrisaPoints--;
                ZaryaPoints--;
                ZenyattaPoints--;
            }

            string path = @"images\Characters\Roadhog\Roadhog";
            tankMethod(RoadhogPic, RoadhogFlag, path);
            RoadhogFlag = !RoadhogFlag;
        }
        private void TaranPic_Click(object sender, EventArgs e)
        {
            if (!TaranFlag)
            {
                OrisaPoints++;
                AshPoints++;
                GenjiPoints++;
            }
            else
            {
                OrisaPoints--;
                AshPoints--;
                GenjiPoints--;
            }

            string path = @"images\Characters\Taran\Taran";
            tankMethod(TaranPic, TaranFlag, path);
            TaranFlag = !TaranFlag;
        }
        private void DvaPic_Click(object sender, EventArgs e)
        {
            if (!DvaFlag)
            {
                WinstonPoints++;
                TaranPoints++;
                SombraPoints++;
            }
            else
            {
                WinstonPoints--;
                TaranPoints--;
                SombraPoints--;
            }

            string path = @"images\Characters\d.va\Dva";
            tankMethod(DvaPic, DvaFlag, path);
            DvaFlag = !DvaFlag;
        }
        private void BaptistPic_Click(object sender, EventArgs e)
        {
            if (!BaptistFlag)
            {
                BastionPoints++;
                OrisaPoints++;
                MccreePoints++;
            }
            else
            {
                BastionPoints--;
                OrisaPoints--;
                MccreePoints--;
            }

            string path = @"images\Characters\Baptist\Baptist";
            healerMethod(BaptistPic, BaptistFlag, path);
            BaptistFlag = !BaptistFlag;
        }
        private void BrigittaPic_Click(object sender, EventArgs e)
        {
            if (!BrigittaFlag)
            {
                ReinhardtPoints++;
                LucioPoints++;
                ReaperPoints++;
            }
            else
            {
                ReinhardtPoints--;
                LucioPoints--;
                ReaperPoints--;
            }

            string path = @"images\Characters\Brigitta\Brigitta";
            healerMethod(BrigittaPic, BrigittaFlag, path);
            BrigittaFlag = !BrigittaFlag;
        }
        private void ZenyattaPic_Click(object sender, EventArgs e)
        {
            if (!ZenyattaFlag)
            {
                AnaPoints++;
                WinstonPoints++;
                TracerPoints++;
            }
            else
            {
                AnaPoints--;
                WinstonPoints--;
                TracerPoints--;
            }

            string path = @"images\Characters\Zenyatta\Zenyatta";
            healerMethod(ZenyattaPic, ZenyattaFlag, path);
            ZenyattaFlag = !ZenyattaFlag;
        }
        private void LucioPic_Click(object sender, EventArgs e)
        {
            if (!LucioFlag)
            {
                ReinhardtPoints++;
                ZaryaPoints++;
                ReaperPoints++;
            }
            else
            {
                ReinhardtPoints--;
                ZaryaPoints--;
                ReaperPoints--;
            }

            string path = @"images\Characters\Lucio\Lucio";
            healerMethod(LucioPic, LucioFlag, path);
            LucioFlag = !LucioFlag;
        }
        private void MoiraPic_Click(object sender, EventArgs e)
        {
            if (!MoiraFlag)
            {
                ReinhardtPoints++;
                OrisaPoints++;
                RoadhogPoints++;
            }
            else
            {
                ReinhardtPoints--;
                OrisaPoints--;
                RoadhogPoints--;
            }

            string path = @"images\Characters\Moira\Moira";
            healerMethod(MoiraPic, MoiraFlag, path);
            MoiraFlag = !MoiraFlag;
        }

        public void healerMethod(PictureBox box, bool flag, string path)
        {
            if (!blockButtons)
            {
                if (totalCount == 5)
                {
                    if (!flag)
                    {
                        path += @"Prior.jpg";
                        box.Image = Image.FromFile(path);
                    }
                }
                else
                {
                    if (flag)
                    {
                        path += @"Main.jpg";
                        box.Image = Image.FromFile(path);
                        healers--;
                        totalCount--;
                    }
                    else
                    {
                        if (totalCount < 6 && totalCount >= 0)
                        {
                            healers++;
                            totalCount++;
                            if (totalCount == 5)
                            {
                                showPick();
                            }
                            path += @"Picked.jpg";
                            box.Image = Image.FromFile(path);
                        }
                    }
                }
            }
        }
        public void damageDealerMethod(PictureBox box, bool flag, string path)
        {
            if (!blockButtons)
            {
                if (totalCount == 5)
                {
                    if (!flag)
                    {
                        path += @"Prior.jpg";
                        box.Image = Image.FromFile(path);
                    }
                }
                else
                {
                    if (!flag)
                    {
                        if (totalCount < 6 && totalCount >= 0)
                        {
                            damageDealers++;
                            totalCount++;
                            if (totalCount == 5)
                            {
                                showPick();
                            }
                            path += @"Picked.jpg";
                            box.Image = Image.FromFile(path);
                        }
                    }

                    else
                    {
                        path += @"Main.jpg";
                        box.Image = Image.FromFile(path);
                        damageDealers--;
                        totalCount--;
                    }

                }
            }
        }
        public void tankMethod(PictureBox box, bool flag, string path)
        {
            if (!blockButtons)
            {
                if (totalCount == 5)
                {
                    if (!flag)
                    {
                        path += @"Prior.jpg";
                        box.Image = Image.FromFile(path);
                    }
                }
                else
                {
                    if (!flag)
                    {
                        if (totalCount < 6 && totalCount >= 0)
                        {
                            tanks++;
                            totalCount++;
                            if (totalCount == 5)
                            {
                                showPick();
                            }
                            path += @"Picked.jpg";
                            box.Image = Image.FromFile(path);
                        }
                    }

                    else
                    {
                        path += @"Main.jpg";
                        box.Image = Image.FromFile(path);
                        tanks--;
                        totalCount--;
                    }
                }
            }
        }

        public void showPick()
        {
            CountMaxPoints();
            //Вызов функции подсчета
            //составление структуры

            if (tanks < 2)
            {
                yellowTank();
                if (healers < 2)
                {
                    yellowHealers();
                }

                if (damageDealers < 2)
                {
                    yellowDd();
                }
            }
            else
            {
                if (healers < 2)
                {
                    yellowHealers();
                }
                else
                {
                    yellowDd();
                }
            }
            blockButtons = true;
            label1.Text = "Жёлтым отображены подходящие герои для выбора,\nа зеленым наиболее выгодные";

            //Замена подсвеченных героев на оптимального
        }

        void CountMaxPoints()
        {
            MaxHeroPoints = AnaPoints;
            if (MaxHeroPoints < MercyPoints)
                MaxHeroPoints = MercyPoints;
            if (MaxHeroPoints < ReaperPoints)
                MaxHeroPoints = ReaperPoints;
            if (MaxHeroPoints < JunkratPoints)
                MaxHeroPoints = JunkratPoints;
            if (MaxHeroPoints < DoomfistPoints)
                MaxHeroPoints = DoomfistPoints;
            if (MaxHeroPoints < BastionPoints)
                MaxHeroPoints = BastionPoints;
            if (MaxHeroPoints < MeiPoints)
                MaxHeroPoints = MeiPoints;
            if (MaxHeroPoints < WidowPoints)
                MaxHeroPoints = WidowPoints;
            if (MaxHeroPoints < SymmetraPoints)
                MaxHeroPoints = SymmetraPoints;
            if (MaxHeroPoints < SoldierPoints)
                MaxHeroPoints = SoldierPoints;
            if (MaxHeroPoints < SombraPoints)
                MaxHeroPoints = SombraPoints;
            if (MaxHeroPoints < TorbjornPoints)
                MaxHeroPoints = TorbjornPoints;
            if (MaxHeroPoints < TracerPoints)
                MaxHeroPoints = TracerPoints;
            if (MaxHeroPoints < PharraPoints)
                MaxHeroPoints = PharraPoints;
            if (MaxHeroPoints < HanzoPoints)
                MaxHeroPoints = HanzoPoints;
            if (MaxHeroPoints < MccreePoints)
                MaxHeroPoints = MccreePoints;
            if (MaxHeroPoints < AshPoints)
                MaxHeroPoints = AshPoints;
            if (MaxHeroPoints < GenjiPoints)
                MaxHeroPoints = GenjiPoints;
            if (MaxHeroPoints < ZaryaPoints)
                MaxHeroPoints = ZaryaPoints;
            if (MaxHeroPoints < OrisaPoints)
                MaxHeroPoints = OrisaPoints;
            if (MaxHeroPoints < ReinhardtPoints)
                MaxHeroPoints = ReinhardtPoints;
            if (MaxHeroPoints < WinstonPoints)
                MaxHeroPoints = WinstonPoints;
            if (MaxHeroPoints < RoadhogPoints)
                MaxHeroPoints = RoadhogPoints;
            if (MaxHeroPoints < TaranPoints)
                MaxHeroPoints = TaranPoints;
            if (MaxHeroPoints < DvaPoints)
                MaxHeroPoints = DvaPoints;
            if (MaxHeroPoints < BaptistPoints)
                MaxHeroPoints = BaptistPoints;
            if (MaxHeroPoints < BrigittaPoints)
                MaxHeroPoints = BrigittaPoints;
            if (MaxHeroPoints < ZenyattaPoints)
                MaxHeroPoints = ZenyattaPoints;
            if (MaxHeroPoints < LucioPoints)
                MaxHeroPoints = LucioPoints;
            if (MaxHeroPoints < MoiraPoints)
                MaxHeroPoints = MoiraPoints;

            if (MaxHeroPoints == AnaPoints && !AnaFlag)
                PrefferableHealers.Add("Ana");
            if (MaxHeroPoints == MercyPoints && !MercyFlag)
                PrefferableHealers.Add("Mercy");
            if (MaxHeroPoints == ReaperPoints && !ReaperFlag)
                PrefferableDDs.Add("Reaper");
            if (MaxHeroPoints == JunkratPoints && !JunkratFlag)
                PrefferableDDs.Add("Junkrat");
            if (MaxHeroPoints == DoomfistPoints && !DoomfistFlag)
                PrefferableDDs.Add("Doomfist");
            if (MaxHeroPoints == BastionPoints && !BastionFlag)
                PrefferableDDs.Add("Bastion");
            if (MaxHeroPoints == MeiPoints && !MeiFlag)
                PrefferableDDs.Add("Mei");
            if (MaxHeroPoints == WidowPoints && !WidowFlag)
                PrefferableDDs.Add("Widow");
            if (MaxHeroPoints == SymmetraPoints && !SymmetraFlag)
                PrefferableDDs.Add("Symmetra");
            if (MaxHeroPoints == SoldierPoints && !SoldierFlag)
                PrefferableDDs.Add("Soldier");
            if (MaxHeroPoints == SombraPoints && !SombraFlag)
                PrefferableDDs.Add("Sombra");
            if (MaxHeroPoints == TorbjornPoints && !TorbjornFlag)
                PrefferableDDs.Add("Torbjorn");
            if (MaxHeroPoints == TracerPoints && !TracerFlag)
                PrefferableDDs.Add("Tracer");
            if (MaxHeroPoints == PharraPoints && !PharraFlag)
                PrefferableDDs.Add("Pharra");
            if (MaxHeroPoints == HanzoPoints && !HanzoFlag)
                PrefferableDDs.Add("Hanzo");
            if (MaxHeroPoints == MccreePoints && !MccreeFlag)
                PrefferableDDs.Add("Mccree");
            if (MaxHeroPoints == AshPoints && !AshFlag)
                PrefferableDDs.Add("Ash");
            if (MaxHeroPoints == GenjiPoints && !GenjiFlag)
                PrefferableDDs.Add("Genji");
            if (MaxHeroPoints == ZaryaPoints && !ZaryaFlag)
                PrefferableTanks.Add("Zarya");
            if (MaxHeroPoints == OrisaPoints && !OrisaFlag)
                PrefferableTanks.Add("Orisa");
            if (MaxHeroPoints == ReinhardtPoints && !ReinhardtFlag)
                PrefferableTanks.Add("Reinhardt");
            if (MaxHeroPoints == WinstonPoints && !WinstonFlag)
                PrefferableTanks.Add("Winston");
            if (MaxHeroPoints == RoadhogPoints && !RoadhogFlag)
                PrefferableTanks.Add("Roadhog");
            if (MaxHeroPoints == TaranPoints && !TaranFlag)
                PrefferableTanks.Add("Taran");
            if (MaxHeroPoints == DvaPoints && !DvaFlag)
                PrefferableTanks.Add("Dva");
            if (MaxHeroPoints == BaptistPoints && !BaptistFlag)
                PrefferableHealers.Add("Baptist");
            if (MaxHeroPoints == BrigittaPoints && !BrigittaFlag)
                PrefferableHealers.Add("Brigitta");
            if (MaxHeroPoints == ZenyattaPoints && !ZenyattaFlag)
                PrefferableHealers.Add("Zenyatta");
            if (MaxHeroPoints == LucioPoints && !LucioFlag)
                PrefferableHealers.Add("Lucio");
            if (MaxHeroPoints == MoiraPoints && !MoiraFlag)
                PrefferableHealers.Add("Moira");
        }
        void Replace(string Hero)
        {
            if (Hero == "Ana")
                AnaPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Mercy")
                MercyPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Reaper")
                ReaperPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Junkrat")
                JunkratPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Doomfist")
                DoomfistPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Bastion")
                BastionPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Mei")
                MeiPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Widow")
                WidowPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Symmetra")
                SymmetraPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Soldier")
                SoldierPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "")
                SombraPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Torbjorn")
                TorbjornPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Tracer")
                TracerPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Pharra")
                PharraPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Hanzo")
                HanzoPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Mccree")
                MccreePic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Ash")
                AshPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Genji")
                GenjiPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Zarya")
                ZaryaPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Orisa")
                OrisaPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Reinhardt")
                ReinhardtPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Winston")
                WinstonPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Roadhog")
                RoadhogPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Taran")
                TaranPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Dva")
                DvaPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Baptist")
                BaptistPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Brigitta")
                BrigittaPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Zenyatta")
                ZenyattaPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Lucio")
                LucioPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
            if (Hero == "Moira")
                MoiraPic.Image = Image.FromFile(@$"images\Characters\{Hero}\{Hero}Green.png");
        }

        public void yellowTank()
        {
            DvaPic_Click(new object(), new EventArgs());
            ReinhardtPic_Click(new object(), new EventArgs());
            OrisaPic_Click(new object(), new EventArgs());
            ZaryaPic_Click(new object(), new EventArgs());
            WinstonPic_Click(new object(), new EventArgs());
            TaranPic_Click(new object(), new EventArgs());
            RoadhogPic_Click(new object(), new EventArgs());

            foreach (string Hero in PrefferableTanks)
            {
                Replace(Hero);
            }
        }
        public void yellowDd()
        {
            BastionPic_Click(new object(), new EventArgs());
            GenjiPic_Click(new object(), new EventArgs());
            ReaperPic_Click(new object(), new EventArgs());
            JunkratPic_Click(new object(), new EventArgs());
            DoomfistPic_Click(new object(), new EventArgs());
            MccreePic_Click(new object(), new EventArgs());
            MeiPic_Click(new object(), new EventArgs());
            WidowPic_Click(new object(), new EventArgs());
            SymmetraPic_Click(new object(), new EventArgs());
            SoldierPic_Click(new object(), new EventArgs());
            SombraPic_Click(new object(), new EventArgs());
            TorbjornPic_Click(new object(), new EventArgs());
            TracerPic_Click(new object(), new EventArgs());
            PharraPic_Click(new object(), new EventArgs());
            HanzoPic_Click(new object(), new EventArgs());
            AshPic_Click(new object(), new EventArgs());

            foreach (string Hero in PrefferableDDs)
            {
                Replace(Hero);
            }
        }
        public void yellowHealers()
        {
            AnaPic_Click(new object(), new EventArgs());
            MercyPic_Click(new object(), new EventArgs());
            LucioPic_Click(new object(), new EventArgs());
            MoiraPic_Click(new object(), new EventArgs());
            ZenyattaPic_Click(new object(), new EventArgs());
            BaptistPic_Click(new object(), new EventArgs());
            BrigittaPic_Click(new object(), new EventArgs());

            foreach (string Hero in PrefferableHealers)
            {
                Replace(Hero);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            totalCount = 0;
            healers = 0;
            damageDealers = 0;
            tanks = 0;
            blockButtons = false;
            AnaPic.Image = Image.FromFile(@"images\Characters\Ana\AnaMain.jpg");
            MercyPic.Image = Image.FromFile(@"images\Characters\Mercy\MercyMain.jpg");
            LucioPic.Image = Image.FromFile(@"images\Characters\Lucio\LucioMain.jpg");
            MoiraPic.Image = Image.FromFile(@"images\Characters\Moira\MoiraMain.jpg");
            ZenyattaPic.Image = Image.FromFile(@"images\Characters\Zenyatta\ZenyattaMain.jpg");
            BaptistPic.Image = Image.FromFile(@"images\Characters\Baptist\BaptistMain.jpg");
            BrigittaPic.Image = Image.FromFile(@"images\Characters\Brigitta\BrigittaMain.jpg");
            BastionPic.Image = Image.FromFile(@"images\Characters\Bastion\BastionMain.jpg");
            GenjiPic.Image = Image.FromFile(@"images\Characters\Genji\GenjiMain.jpg");
            ReaperPic.Image = Image.FromFile(@"images\Characters\Reaper\ReaperMain.jpg");
            DoomfistPic.Image = Image.FromFile(@"images\Characters\Doomfist\DoomfistMain.jpg");
            MccreePic.Image = Image.FromFile(@"images\Characters\Mccree\MccreeMain.jpg");
            MeiPic.Image = Image.FromFile(@"images\Characters\Mei\MeiMain.jpg");
            WidowPic.Image = Image.FromFile(@"images\Characters\Widow\WidowMain.jpg");
            SymmetraPic.Image = Image.FromFile(@"images\Characters\Symmetra\SymmetraMain.jpg");
            SoldierPic.Image = Image.FromFile(@"images\Characters\Soldier\SoldierMain.jpg");
            SombraPic.Image = Image.FromFile(@"images\Characters\Sombra\SombraMain.jpg");
            TorbjornPic.Image = Image.FromFile(@"images\Characters\Torbjorn\TorbjornMain.jpg");
            TracerPic.Image = Image.FromFile(@"images\Characters\Tracer\TracerMain.jpg");
            PharraPic.Image = Image.FromFile(@"images\Characters\Pharra\PharraMain.jpg");
            HanzoPic.Image = Image.FromFile(@"images\Characters\Hanzo\HanzoMain.jpg");
            AshPic.Image = Image.FromFile(@"images\Characters\Ash\AshMain.jpg");
            DvaPic.Image = Image.FromFile(@"images\Characters\d.va\DvaMain.jpg");
            ReinhardtPic.Image = Image.FromFile(@"images\Characters\Reinhardt\ReinhardtMain.jpg");
            OrisaPic.Image = Image.FromFile(@"images\Characters\Orisa\OrisaMain.jpg");
            ZaryaPic.Image = Image.FromFile(@"images\Characters\Zarya\ZaryaMain.jpg");
            WinstonPic.Image = Image.FromFile(@"images\Characters\Winston\WinstonMain.jpg");
            TaranPic.Image = Image.FromFile(@"images\Characters\Taran\TaranMain.jpg");
            RoadhogPic.Image = Image.FromFile(@"images\Characters\Roadhog\RoadhogMain.jpg");
            JunkratPic.Image = Image.FromFile(@"images\Characters\Junkrat\JunkratMain.jpg");
            AnaFlag = false;
            MercyFlag = false;
            ReaperFlag = false;
            JunkratFlag = false;
            DoomfistFlag = false;
            BastionFlag = false;
            MeiFlag = false;
            WidowFlag = false;
            SymmetraFlag = false;
            SoldierFlag = false;
            SombraFlag = false;
            TorbjornFlag = false;
            TracerFlag = false;
            PharraFlag = false;
            HanzoFlag = false;
            MccreeFlag = false;
            AshFlag = false;
            GenjiFlag = false;
            ZaryaFlag = false;
            OrisaFlag = false;
            ReinhardtFlag = false;
            WinstonFlag = false;
            RoadhogFlag = false;
            TaranFlag = false;
            DvaFlag = false;
            BaptistFlag = false;
            BrigittaFlag = false;
            ZenyattaFlag = false;
            LucioFlag = false;
            MoiraFlag = false;

            AnaPoints = 0;
            MercyPoints = 0;
            ReaperPoints = 0;
            JunkratPoints = 0;
            DoomfistPoints = 0;
            BastionPoints = 0;
            MeiPoints = 0;
            WidowPoints = 0;
            SymmetraPoints = 0;
            SoldierPoints = 0;
            SombraPoints = 0;
            TorbjornPoints = 0;
            TracerPoints = 0;
            PharraPoints = 0;
            HanzoPoints = 0;
            MccreePoints = 0;
            AshPoints = 0;
            GenjiPoints = 0;
            ZaryaPoints = 0;
            OrisaPoints = 0;
            ReinhardtPoints = 0;
            WinstonPoints = 0;
            RoadhogPoints = 0;
            TaranPoints = 0;
            DvaPoints = 0;
            BaptistPoints = 0;
            BrigittaPoints = 0;
            ZenyattaPoints = 0;
            LucioPoints = 0;
            MoiraPoints = 0;

            PrefferableDDs.Clear();
            PrefferableHealers.Clear();
            PrefferableTanks.Clear();

            MaxHeroPoints = 0;

            label1.Text = "Выберете 5 героев в вашей команде";
        }
    }
}