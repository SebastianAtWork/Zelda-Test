using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelda_Test
{
    public partial class Form2 : Form
    {
        public List<int> skulltulasMax = new List<int>();
        public List<int> skulltulaActual = new List<int>();

        public List<string> locationNames = new List<string>();
        public int locationTrackerInt = 0;
        public int locationTrackerIntMax;
        public int locationTrackerIntMin = 0;

        public int locationTrackerByteOne;
        public int locationTrackerByteTwo;

        public bool callChangeLocation = false;
        public bool locked = false;

        public static OoT form1 = new OoT();

        //public static System.Windows.Forms.TabControl tabControl1;

        public Form2()
        {
            InitializeComponent();

            locationNames.Add("Kokiri Forest"); //0
            locationNames.Add("Lost Woods/Sacred Forest Meadow"); //1
            locationNames.Add("Kakariko Village"); //2
            locationNames.Add("Hyrule Castle/Ganon's Castle"); //3
            locationNames.Add("Market/Temple of Time"); //4
            locationNames.Add("Hyrule Field"); //5
            locationNames.Add("Lake Hylia"); //6
            locationNames.Add("Zora River"); //7
            locationNames.Add("Zora's Domain"); //8
            locationNames.Add("Death Mountain/Crater"); //9
            locationNames.Add("Goron City"); //10
            locationNames.Add("Gerudo Valley/Fortress"); //11
            locationNames.Add("Desert Colossus/Wasteland"); //12

            locationNames.Add("Deku Tree"); //13
            locationNames.Add("Dodongo's Cavern"); //14
            locationNames.Add("Jabu Jabu's Belly"); //15
            locationNames.Add("Bottom of The Well"); //16
            locationNames.Add("Forest Temple"); //17
            locationNames.Add("Fire Temple"); //18
            locationNames.Add("Ice Cavern"); //19
            locationNames.Add("Zora's Fountain"); //20
            locationNames.Add("Water Temple"); //21
            locationNames.Add("Shadow Temple"); //22
            locationNames.Add("Spirit Temple"); //23
            locationNames.Add("Gerudo Training Grounds"); //24
            locationNames.Add("Ganon's Castle"); //25
            locationNames.Add("Lon Lon Ranch"); // 26

            locationTrackerIntMax = locationNames.Count - 1;

            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.SizeMode = TabSizeMode.Fixed;

            skulltulasMax.Add(3);// kokiri forest //
            skulltulasMax.Add(4);// lost woods //
            skulltulasMax.Add(8);// kakariko village //
            skulltulasMax.Add(3);// hyrule castle //
            skulltulasMax.Add(1);// market //
            skulltulasMax.Add(2);// hyrule field //
            skulltulasMax.Add(5);// lake hylia //
            skulltulasMax.Add(4);// zora river //
            skulltulasMax.Add(1);// zora's domain //
            skulltulasMax.Add(6);// death mountain //
            skulltulasMax.Add(2);// goron city //
            skulltulasMax.Add(6);// gerudo valley+fortress //
            skulltulasMax.Add(4);// desert colossus + wasteland //
            skulltulasMax.Add(4);// deku tree //
            skulltulasMax.Add(5);// dc //
            skulltulasMax.Add(4);// jabu //
            skulltulasMax.Add(3);// botw //
            skulltulasMax.Add(5);// forest //
            skulltulasMax.Add(5);// fire //
            skulltulasMax.Add(3);// ice //
            skulltulasMax.Add(3);// zoras fountain //
            skulltulasMax.Add(5);// water //
            skulltulasMax.Add(5);// shadow //
            skulltulasMax.Add(5);// spirit //
            skulltulasMax.Add(0);// gtg //
            skulltulasMax.Add(0);// ganons castle //
            skulltulasMax.Add(4);// lon lon //

            skulltulaActual.Add(0);// kokiri forest //
            skulltulaActual.Add(0);// lost woods //
            skulltulaActual.Add(0);// kakariko village //
            skulltulaActual.Add(0);// hyrule castle //
            skulltulaActual.Add(0);// market //
            skulltulaActual.Add(0);// hyrule field //
            skulltulaActual.Add(0);// lake hylia //
            skulltulaActual.Add(0);// zora river //
            skulltulaActual.Add(0);// zora's domain //
            skulltulaActual.Add(0);// death mountain //
            skulltulaActual.Add(0);// goron city //
            skulltulaActual.Add(0);// gerudo valley+fortress //
            skulltulaActual.Add(0);// desert colossus + wasteland //
            skulltulaActual.Add(0);// deku tree //
            skulltulaActual.Add(0);// dc //
            skulltulaActual.Add(0);// jabu //
            skulltulaActual.Add(0);// botw //
            skulltulaActual.Add(0);// forest //
            skulltulaActual.Add(0);// fire //
            skulltulaActual.Add(0);// ice //
            skulltulaActual.Add(0);// zoras fountain //
            skulltulaActual.Add(0);// water //
            skulltulaActual.Add(0);// shadow //
            skulltulaActual.Add(0);// spirit //
            skulltulaActual.Add(0);// gtg //
            skulltulaActual.Add(0);// ganons castle //
            skulltulaActual.Add(0);// lon lon //

        }

        private const int TCM_ADJUSTRECT = 0x1328;

        public void Start()
        {

        }

        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        public void ChangeLocationTexts()
        {
            label1.Text = locationNames[locationTrackerInt];
            tabControl1.SelectedTab = tabControl1.TabPages[locationTrackerInt];
        }

        public void ChangePageBasedOnLocation()
        {
                
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //up
            if (locationTrackerInt < locationTrackerIntMax)
            {
                locationTrackerInt++;
            }
            else
            {
                locationTrackerInt = locationTrackerIntMin;
            }
            ChangeLocationTexts();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //down
            if (locationTrackerInt > locationTrackerIntMin)
            {
                locationTrackerInt--;
            }
            else
            {
                locationTrackerInt = locationTrackerIntMax;
            }
            ChangeLocationTexts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(locked)
            {
                locked = false;
                button3.Text = "Unlock";
            }
            else if(!locked)
            {
                locked = true;
                button3.Text = "Lock";
            }
            //((Control)"NAME OF CONTROL YOU WANT TO SHOW").Show();
            //((Control)"NAME OF CONTROL YOU WANT TO HIDE").Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                if (KokiriMidoHouse.ForeColor == Color.Red)
                {
                    KokiriMidoHouse.Text = "[X] MIDO'S HOUSE";
                    KokiriMidoHouse.ForeColor = Color.Green;
                }
                else if(KokiriMidoHouse.ForeColor == Color.Green)
                {
                    KokiriMidoHouse.Text = "[  ] MIDO'S HOUSE";
                    KokiriMidoHouse.ForeColor = Color.Red;
                }
            }
        }

        private void KokiriSword_Click(object sender, EventArgs e)
        {

        }

        private void KokiriSword_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (KokiriSword.ForeColor == Color.Red)
                {
                    KokiriSword.Text = "[X] KOKIRI SWORD";
                    KokiriSword.ForeColor = Color.Green;
                }
                else if (KokiriSword.ForeColor == Color.Green)
                {
                    KokiriSword.Text = "[  ] KOKIRI SWORD";
                    KokiriSword.ForeColor = Color.Red;
                }
            }
        }

        private void Shop_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Shop.ForeColor == Color.Red)
                {
                    Shop.Text = "[X] SHOP";
                    Shop.ForeColor = Color.Green;
                }
                else if (Shop.ForeColor == Color.Green)
                {
                    Shop.Text = "[  ] SHOP";
                    Shop.ForeColor = Color.Red;
                }
            }
        }

        private void SOSGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SOSGrotto.ForeColor == Color.Red)
                {
                    SOSGrotto.Text = "[X] SOS GROTTO";
                    SOSGrotto.ForeColor = Color.Green;
                }
                else if (Shop.ForeColor == Color.Green)
                {
                    SOSGrotto.Text = "[  ] SOS GROTTO";
                    SOSGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DrawTab(object sender, DrawItemEventArgs e)
        {
            
        }

        private void ScrubLeft_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ScrubLeft.ForeColor == Color.Red)
                {
                    ScrubLeft.Text = "[X] SCRUB LEFT";
                    ScrubLeft.ForeColor = Color.Green;
                }
                else if (ScrubLeft.ForeColor == Color.Green)
                {
                    ScrubLeft.Text = "[  ] SCRUB LEFT";
                    ScrubLeft.ForeColor = Color.Red;
                }
            }
        }

        private void ScrubGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ScrubGrotto.ForeColor == Color.Red)
                {
                    ScrubGrotto.Text = "[X] SCRUB GROTTO";
                    ScrubGrotto.ForeColor = Color.Green;
                }
                else if (ScrubGrotto.ForeColor == Color.Green)
                {
                    ScrubGrotto.Text = "[  ] SCRUB GROTTO";
                    ScrubGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void GenericGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GenericGrotto.ForeColor == Color.Red)
                {
                    GenericGrotto.Text = "[X] GENERIC GROTTO";
                    GenericGrotto.ForeColor = Color.Green;
                }
                else if (GenericGrotto.ForeColor == Color.Green)
                {
                    GenericGrotto.Text = "[  ] GENERIC GROTTO";
                    GenericGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void OcarinaGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (OcarinaGame.ForeColor == Color.Red)
                {
                    OcarinaGame.Text = "[X] OCARINA GAME";
                    OcarinaGame.ForeColor = Color.Green;
                }
                else if (OcarinaGame.ForeColor == Color.Green)
                {
                    OcarinaGame.Text = "[  ] OCARINA GAME";
                    OcarinaGame.ForeColor = Color.Red;
                }
            }
        }

        private void Target_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Target.ForeColor == Color.Red)
                {
                    Target.Text = "[X] TARGET";
                    Target.ForeColor = Color.Green;
                }
                else if (Target.ForeColor == Color.Green)
                {
                    Target.Text = "[  ] TARGET";
                    Target.ForeColor = Color.Red;
                }
            }
        }

        private void SkullKid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SkullKid.ForeColor == Color.Red)
                {
                    SkullKid.Text = "[X] SKULL KID";
                    SkullKid.ForeColor = Color.Green;
                }
                else if (SkullKid.ForeColor == Color.Green)
                {
                    SkullKid.Text = "[  ] SKULL KID";
                    SkullKid.ForeColor = Color.Red;
                }
            }
        }

        private void SkullMask_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SkullMask.ForeColor == Color.Red)
                {
                    SkullMask.Text = "[X] SKULL MASK";
                    SkullMask.ForeColor = Color.Green;
                }
                else if (SkullMask.ForeColor == Color.Green)
                {
                    SkullMask.Text = "[  ] SKULL MASK";
                    SkullMask.ForeColor = Color.Red;
                }
            }
        }

        private void MaskOfTruth_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MaskOfTruth.ForeColor == Color.Red)
                {
                    MaskOfTruth.Text = "[X] MASK OF TRUTH";
                    MaskOfTruth.ForeColor = Color.Green;
                }
                else if (MaskOfTruth.ForeColor == Color.Green)
                {
                    MaskOfTruth.Text = "[  ] MASK OF TRUTH";
                    MaskOfTruth.ForeColor = Color.Red;
                }
            }
        }

        private void MeadowGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MeadowGrotto.ForeColor == Color.Red)
                {
                    MeadowGrotto.Text = "[X] MEADOW GROTTO";
                    MeadowGrotto.ForeColor = Color.Green;
                }
                else if (MeadowGrotto.ForeColor == Color.Green)
                {
                    MeadowGrotto.Text = "[  ] MEADOW GROTTO";
                    MeadowGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void SariasSong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SariasSong.ForeColor == Color.Red)
                {
                    SariasSong.Text = "[X] SARIA'S SONG";
                    SariasSong.ForeColor = Color.Green;
                }
                else if (SariasSong.ForeColor == Color.Green)
                {
                    SariasSong.Text = "[  ] SARIA'S SONG";
                    SariasSong.ForeColor = Color.Red;
                }
            }
        }

        private void Cuccos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Cuccos.ForeColor == Color.Red)
                {
                    Cuccos.Text = "[X] CUCCOS";
                    Cuccos.ForeColor = Color.Green;
                }
                else if (Cuccos.ForeColor == Color.Green)
                {
                    Cuccos.Text = "[  ] CUCCOS";
                    Cuccos.ForeColor = Color.Red;
                }
            }
        }

        private void Minuet_Click(object sender, EventArgs e)
        {

        }

        private void Minuet_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Minuet.ForeColor == Color.Red)
                {
                    Minuet.Text = "[X] MINUET";
                    Minuet.ForeColor = Color.Green;
                }
                else if (Minuet.ForeColor == Color.Green)
                {
                    Minuet.Text = "[  ] MINUET";
                    Minuet.ForeColor = Color.Red;
                }
            }
        }

        private void AnjuAdult_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (AnjuAdult.ForeColor == Color.Red)
                {
                    AnjuAdult.Text = "[X] ANJU ADULT";
                    AnjuAdult.ForeColor = Color.Green;
                }
                else if (AnjuAdult.ForeColor == Color.Green)
                {
                    AnjuAdult.Text = "[  ] ANJU ADULT";
                    AnjuAdult.ForeColor = Color.Red;
                }
            }
        }

        private void Windmill_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Windmill.ForeColor == Color.Red)
                {
                    Windmill.Text = "[X] WINDMILL SONG";
                    Windmill.ForeColor = Color.Green;
                }
                else if (Windmill.ForeColor == Color.Green)
                {
                    Windmill.Text = "[  ] WINDMILL SONG";
                    Windmill.ForeColor = Color.Red;
                }
            }
        }

        private void WindmillHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WindmillHP.ForeColor == Color.Red)
                {
                    WindmillHP.Text = "[X] WINDMILL HP";
                    WindmillHP.ForeColor = Color.Green;
                }
                else if (WindmillHP.ForeColor == Color.Green)
                {
                    WindmillHP.Text = "[  ] WINDMILL HP";
                    WindmillHP.ForeColor = Color.Red;
                }
            }
        }

        private void ImpasHouse_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ImpasHouse.ForeColor == Color.Red)
                {
                    ImpasHouse.Text = "[X] IMPA'S HOUSE";
                    ImpasHouse.ForeColor = Color.Green;
                }
                else if (ImpasHouse.ForeColor == Color.Green)
                {
                    ImpasHouse.Text = "[  ] IMPA'S HOUSE";
                    ImpasHouse.ForeColor = Color.Red;
                }
            }
        }

        private void ManOnRoof_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ManOnRoof.ForeColor == Color.Red)
                {
                    ManOnRoof.Text = "[X] MAN ON ROOF";
                    ManOnRoof.ForeColor = Color.Green;
                }
                else if (ManOnRoof.ForeColor == Color.Green)
                {
                    ManOnRoof.Text = "[  ] MAN ON ROOF";
                    ManOnRoof.ForeColor = Color.Red;
                }
            }
        }

        private void FrontGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FrontGrotto.ForeColor == Color.Red)
                {
                    FrontGrotto.Text = "[X] FRONT GROTTO";
                    FrontGrotto.ForeColor = Color.Green;
                }
                else if (FrontGrotto.ForeColor == Color.Green)
                {
                    FrontGrotto.Text = "[  ] FRONT GROTTO";
                    FrontGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void BackGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BackGrotto.ForeColor == Color.Red)
                {
                    BackGrotto.Text = "[X] BACK GROTTO";
                    BackGrotto.ForeColor = Color.Green;
                }
                else if (BackGrotto.ForeColor == Color.Green)
                {
                    BackGrotto.Text = "[  ] BACK GROTTO";
                    BackGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void BowGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BowGame.ForeColor == Color.Red)
                {
                    BowGame.Text = "[X] BOW GAME";
                    BowGame.ForeColor = Color.Green;
                }
                else if (BowGame.ForeColor == Color.Green)
                {
                    BowGame.Text = "[  ] BOW GAME";
                    BowGame.ForeColor = Color.Red;
                }
            }
        }

        private void TenSkulltulas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TenSkulltulas.ForeColor == Color.Red)
                {
                    TenSkulltulas.Text = "[X] 10 SKULLTULAS";
                    TenSkulltulas.ForeColor = Color.Green;
                }
                else if (TenSkulltulas.ForeColor == Color.Green)
                {
                    TenSkulltulas.Text = "[  ] 10 SKULLTULAS";
                    TenSkulltulas.ForeColor = Color.Red;
                }
            }
        }

        private void TwentySkulltulas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TwentySkulltulas.ForeColor == Color.Red)
                {
                    TwentySkulltulas.Text = "[X] 20 SKULLTULAS";
                    TwentySkulltulas.ForeColor = Color.Green;
                }
                else if (TwentySkulltulas.ForeColor == Color.Green)
                {
                    TwentySkulltulas.Text = "[  ] 20 SKULLTULAS";
                    TwentySkulltulas.ForeColor = Color.Red;
                }
            }
        }

        private void ThirtySkulltulas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ThirtySkulltulas.ForeColor == Color.Red)
                {
                    ThirtySkulltulas.Text = "[X] 30 SKULLTULAS";
                    ThirtySkulltulas.ForeColor = Color.Green;
                }
                else if (ThirtySkulltulas.ForeColor == Color.Green)
                {
                    ThirtySkulltulas.Text = "[  ] 30 SKULLTULAS";
                    ThirtySkulltulas.ForeColor = Color.Red;
                }
            }
        }

        private void ThirtySkulltulas_Click(object sender, EventArgs e)
        {

        }

        private void FourtySkulltulas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FourtySkulltulas.ForeColor == Color.Red)
                {
                    FourtySkulltulas.Text = "[X] 40 SKULLTULAS";
                    FourtySkulltulas.ForeColor = Color.Green;
                }
                else if (FourtySkulltulas.ForeColor == Color.Green)
                {
                    FourtySkulltulas.Text = "[  ] 40 SKULLTULAS";
                    FourtySkulltulas.ForeColor = Color.Red;
                }
            }
        }

        private void FiftySkulltulas_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FiftySkulltulas.ForeColor == Color.Red)
                {
                    FiftySkulltulas.Text = "[X] 50 SKULLTULAS";
                    FiftySkulltulas.ForeColor = Color.Green;
                }
                else if (FiftySkulltulas.ForeColor == Color.Green)
                {
                    FiftySkulltulas.Text = "[  ] 50 SKULLTULAS";
                    FiftySkulltulas.ForeColor = Color.Red;
                }
            }
        }

        private void DampeRaceOne_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (DampeRaceOne.ForeColor == Color.Red)
                {
                    DampeRaceOne.Text = "[X] DAMPE RACE 1";
                    DampeRaceOne.ForeColor = Color.Green;
                }
                else if (DampeRaceOne.ForeColor == Color.Green)
                {
                    DampeRaceOne.Text = "[  ] DAMPE RACE 1";
                    DampeRaceOne.ForeColor = Color.Red;
                }
            }
        }

        private void DampeRaceTwo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (DampeRaceTwo.ForeColor == Color.Red)
                {
                    DampeRaceTwo.Text = "[X] DAMPE RACE 2";
                    DampeRaceTwo.ForeColor = Color.Green;
                }
                else if (DampeRaceTwo.ForeColor == Color.Green)
                {
                    DampeRaceTwo.Text = "[  ] DAMPE RACE 2";
                    DampeRaceTwo.ForeColor = Color.Red;
                }
            }
        }

        private void DampeDig_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (DampeDig.ForeColor == Color.Red)
                {
                    DampeDig.Text = "[X] DAMPE DIG";
                    DampeDig.ForeColor = Color.Green;
                }
                else if (DampeDig.ForeColor == Color.Green)
                {
                    DampeDig.Text = "[  ] DAMPE DIG";
                    DampeDig.ForeColor = Color.Red;
                }
            }
        }

        private void Nocturne_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Nocturne.ForeColor == Color.Red)
                {
                    Nocturne.Text = "[X] NOCTURNE";
                    Nocturne.ForeColor = Color.Green;
                }
                else if (Nocturne.ForeColor == Color.Green)
                {
                    Nocturne.Text = "[  ] NOCTURNE";
                    Nocturne.ForeColor = Color.Red;
                }
            }
        }

        private void SunSong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SunSong.ForeColor == Color.Red)
                {
                    SunSong.Text = "[X] SUN'S SONG";
                    SunSong.ForeColor = Color.Green;
                }
                else if (SunSong.ForeColor == Color.Green)
                {
                    SunSong.Text = "[  ] SUN'S SONG";
                    SunSong.ForeColor = Color.Red;
                }
            }
        }

        private void ShieldGrave_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ShieldGrave.ForeColor == Color.Red)
                {
                    ShieldGrave.Text = "[X] SHIELD GRAVE";
                    ShieldGrave.ForeColor = Color.Green;
                }
                else if (ShieldGrave.ForeColor == Color.Green)
                {
                    ShieldGrave.Text = "[  ] SHIELD GRAVE";
                    ShieldGrave.ForeColor = Color.Red;
                }
            }
        }

        private void ReadeadGrave_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RedeadGrave.ForeColor == Color.Red)
                {
                    RedeadGrave.Text = "[X] REDEAD GRAVE";
                    RedeadGrave.ForeColor = Color.Green;
                }
                else if (RedeadGrave.ForeColor == Color.Green)
                {
                    RedeadGrave.Text = "[  ] REDEAD GRAVE";
                    RedeadGrave.ForeColor = Color.Red;
                }
            }
        }

        private void TorchesGrave_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TorchesGrave.ForeColor == Color.Red)
                {
                    TorchesGrave.Text = "[X] TORCHES GRAVE";
                    TorchesGrave.ForeColor = Color.Green;
                }
                else if (TorchesGrave.ForeColor == Color.Green)
                {
                    TorchesGrave.Text = "[  ] TORCHES GRAVE";
                    TorchesGrave.ForeColor = Color.Red;
                }
            }
        }

        private void GraveyardCrate_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GraveyardCrate.ForeColor == Color.Red)
                {
                    GraveyardCrate.Text = "[X] GRAVEYARD CRATE";
                    GraveyardCrate.ForeColor = Color.Green;
                }
                else if (GraveyardCrate.ForeColor == Color.Green)
                {
                    GraveyardCrate.Text = "[  ] GRAVEYARD CRATE";
                    GraveyardCrate.ForeColor = Color.Red;
                }
            }
        }

        private void ChuBowlingBag_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChuBowlingBag.ForeColor == Color.Red)
                {
                    ChuBowlingBag.Text = "[X] CHU BOWLING (BAG)";
                    ChuBowlingBag.ForeColor = Color.Green;
                }
                else if (ChuBowlingBag.ForeColor == Color.Green)
                {
                    ChuBowlingBag.Text = "[  ] CHU BOWLING (BAG)";
                    ChuBowlingBag.ForeColor = Color.Red;
                }
            }
        }

        private void ChuBowlingHeart_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChuBowlingHeart.ForeColor == Color.Red)
                {
                    ChuBowlingHeart.Text = "[X] CHU BOWLING (HEART)";
                    ChuBowlingHeart.ForeColor = Color.Green;
                }
                else if (ChuBowlingHeart.ForeColor == Color.Green)
                {
                    ChuBowlingHeart.Text = "[  ] CHU BOWLING (HEART)";
                    ChuBowlingHeart.ForeColor = Color.Red;
                }
            }
        }

        private void Slingshotgame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Slingshotgame.ForeColor == Color.Red)
                {
                    Slingshotgame.Text = "[X] SLINGSHOT GAME";
                    Slingshotgame.ForeColor = Color.Green;
                }
                else if (Slingshotgame.ForeColor == Color.Green)
                {
                    Slingshotgame.Text = "[  ] SLINGSHOT GAME";
                    Slingshotgame.ForeColor = Color.Red;
                }
            }
        }

        private void Richard_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Richard.ForeColor == Color.Red)
                {
                    Richard.Text = "[X] RICHARD";
                    Richard.ForeColor = Color.Green;
                }
                else if (Richard.ForeColor == Color.Green)
                {
                    Richard.Text = "[  ] RICHARD";
                    Richard.ForeColor = Color.Red;
                }
            }
        }

        private void TreasureGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TreasureGame.ForeColor == Color.Red)
                {
                    TreasureGame.Text = "[X] TREASURE GAME";
                    TreasureGame.ForeColor = Color.Green;
                }
                else if (TreasureGame.ForeColor == Color.Green)
                {
                    TreasureGame.Text = "[  ] TREASURE GAME";
                    TreasureGame.ForeColor = Color.Red;
                }
            }
        }

        private void Prelude_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Prelude.ForeColor == Color.Red)
                {
                    Prelude.Text = "[X] PRELUDE";
                    Prelude.ForeColor = Color.Green;
                }
                else if (Prelude.ForeColor == Color.Green)
                {
                    Prelude.Text = "[  ] PRELUDE";
                    Prelude.ForeColor = Color.Red;
                }
            }
        }

        private void LightArrows_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LightArrows.ForeColor == Color.Red)
                {
                    LightArrows.Text = "[X] LIGHT ARROWS";
                    LightArrows.ForeColor = Color.Green;
                }
                else if (LightArrows.ForeColor == Color.Green)
                {
                    LightArrows.Text = "[  ] LIGHT ARROWS";
                    LightArrows.ForeColor = Color.Red;
                }
            }
        }

        private void BigPoes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BigPoes.ForeColor == Color.Red)
                {
                    BigPoes.Text = "[X] 10 BIG POES";
                    BigPoes.ForeColor = Color.Green;
                }
                else if (BigPoes.ForeColor == Color.Green)
                {
                    BigPoes.Text = "[  ] 10 BIG POES";
                    BigPoes.ForeColor = Color.Red;
                }
            }
        }

        private void PotionShop_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (PotionShop.ForeColor == Color.Red)
                {
                    PotionShop.Text = "[X] POTION SHOP";
                    PotionShop.ForeColor = Color.Green;
                }
                else if (PotionShop.ForeColor == Color.Green)
                {
                    PotionShop.Text = "[  ] POTION SHOP";
                    PotionShop.ForeColor = Color.Red;
                }
            }
        }

        private void Bazaar_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Bazaar.ForeColor == Color.Red)
                {
                    Bazaar.Text = "[X] BAZAAR";
                    Bazaar.ForeColor = Color.Green;
                }
                else if (Bazaar.ForeColor == Color.Green)
                {
                    Bazaar.Text = "[  ] BAZAAR";
                    Bazaar.ForeColor = Color.Red;
                }
            }
        }

        private void CastleFairy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CastleFairy.ForeColor == Color.Red)
                {
                    CastleFairy.Text = "[X] CASTLE FAIRY";
                    CastleFairy.ForeColor = Color.Green;
                }
                else if (CastleFairy.ForeColor == Color.Green)
                {
                    CastleFairy.Text = "[  ] CASTLE FAIRY";
                    CastleFairy.ForeColor = Color.Red;
                }
            }
        }

        private void GanonsCastleFairy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GanonsCastleFairy.ForeColor == Color.Red)
                {
                    GanonsCastleFairy.Text = "[X] GANON'S CASTLE FAIRY";
                    GanonsCastleFairy.ForeColor = Color.Green;
                }
                else if (GanonsCastleFairy.ForeColor == Color.Green)
                {
                    GanonsCastleFairy.Text = "[  ] GANON'S CASTLE FAIRY";
                    GanonsCastleFairy.ForeColor = Color.Red;
                }
            }
        }

        private void Richard_Click(object sender, EventArgs e)
        {

        }

        private void FenceScrub_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FenceScrub.ForeColor == Color.Red)
                {
                    FenceScrub.Text = "[X] FENCE SCRUB";
                    FenceScrub.ForeColor = Color.Green;
                }
                else if (FenceScrub.ForeColor == Color.Green)
                {
                    FenceScrub.Text = "[  ] FENCE SCRUB";
                    FenceScrub.ForeColor = Color.Red;
                }
            }
        }

        private void GrottoNearLake_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GrottoNearLake.ForeColor == Color.Red)
                {
                    GrottoNearLake.Text = "[X] GROTTO NEAR LAKE";
                    GrottoNearLake.ForeColor = Color.Green;
                }
                else if (GrottoNearLake.ForeColor == Color.Green)
                {
                    GrottoNearLake.Text = "[  ] GROTTO NEAR LAKE";
                    GrottoNearLake.ForeColor = Color.Red;
                }
            }
        }

        private void WaterGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WaterGrotto.ForeColor == Color.Red)
                {
                    WaterGrotto.Text = "[X] WATER GROTTO";
                    WaterGrotto.ForeColor = Color.Green;
                }
                else if (WaterGrotto.ForeColor == Color.Green)
                {
                    WaterGrotto.Text = "[  ] WATER GROTTO";
                    WaterGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void GrottoNearCastle_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GrottoNearCastle.ForeColor == Color.Red)
                {
                    GrottoNearCastle.Text = "[X] GROTTO NEAR CASTLE";
                    GrottoNearCastle.ForeColor = Color.Green;
                }
                else if (GrottoNearCastle.ForeColor == Color.Green)
                {
                    GrottoNearCastle.Text = "[  ] GROTTO NEAR CASTLE";
                    GrottoNearCastle.ForeColor = Color.Red;
                }
            }
        }

        private void OcarinaOfTime_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (OcarinaOfTime.ForeColor == Color.Red)
                {
                    OcarinaOfTime.Text = "[X] OCARINA OF TIME";
                    OcarinaOfTime.ForeColor = Color.Green;
                }
                else if (OcarinaOfTime.ForeColor == Color.Green)
                {
                    OcarinaOfTime.Text = "[  ] OCARINA OF TIME";
                    OcarinaOfTime.ForeColor = Color.Red;
                }
            }
        }

        private void SongOfTime_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SongOfTime.ForeColor == Color.Red)
                {
                    SongOfTime.Text = "[X] SONG OF TIME";
                    SongOfTime.ForeColor = Color.Green;
                }
                else if (SongOfTime.ForeColor == Color.Green)
                {
                    SongOfTime.Text = "[  ] SONG OF TIME";
                    SongOfTime.ForeColor = Color.Red;
                }
            }
        }

        private void ScrubsAboveTheater_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ScrubsAboveTheater.ForeColor == Color.Red)
                {
                    ScrubsAboveTheater.Text = "[X] SCRUBS ABOVE THEATER";
                    ScrubsAboveTheater.ForeColor = Color.Green;
                }
                else if (ScrubsAboveTheater.ForeColor == Color.Green)
                {
                    ScrubsAboveTheater.Text = "[  ] SCRUBS ABOVE THEATER";
                    ScrubsAboveTheater.ForeColor = Color.Red;
                }
            }
        }

        private void ChildFishing_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChildFishing.ForeColor == Color.Red)
                {
                    ChildFishing.Text = "[X] CHILD FISHING";
                    ChildFishing.ForeColor = Color.Green;
                }
                else if (ChildFishing.ForeColor == Color.Green)
                {
                    ChildFishing.Text = "[  ] CHILD FISHING";
                    ChildFishing.ForeColor = Color.Red;
                }
            }
        }

        private void AdultFishing_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (AdultFishing.ForeColor == Color.Red)
                {
                    AdultFishing.Text = "[X] ADULT FISHING";
                    AdultFishing.ForeColor = Color.Green;
                }
                else if (AdultFishing.ForeColor == Color.Green)
                {
                    AdultFishing.Text = "[  ] ADULT FISHING";
                    AdultFishing.ForeColor = Color.Red;
                }
            }
        }

        private void GraveScrubs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GraveScrubs.ForeColor == Color.Red)
                {
                    GraveScrubs.Text = "[X] GRAVE SCRUBS";
                    GraveScrubs.ForeColor = Color.Green;
                }
                else if (GraveScrubs.ForeColor == Color.Green)
                {
                    GraveScrubs.Text = "[  ] GRAVE SCRUBS";
                    GraveScrubs.ForeColor = Color.Red;
                }
            }
        }

        private void ScarecrowChild_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ScarecrowChild.ForeColor == Color.Red)
                {
                    ScarecrowChild.Text = "[X] SCARECROW CHILD";
                    ScarecrowChild.ForeColor = Color.Green;
                }
                else if (ScarecrowChild.ForeColor == Color.Green)
                {
                    ScarecrowChild.Text = "[  ] SCARECROW CHILD";
                    ScarecrowChild.ForeColor = Color.Red;
                }
            }
        }

        private void ScarecrowAdult_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ScarecrowAdult.ForeColor == Color.Red)
                {
                    ScarecrowAdult.Text = "[X] SCARECROW ADULT";
                    ScarecrowAdult.ForeColor = Color.Green;
                }
                else if (ScarecrowAdult.ForeColor == Color.Green)
                {
                    ScarecrowAdult.Text = "[  ] SCARECROW ADULT";
                    ScarecrowAdult.ForeColor = Color.Red;
                }
            }
        }

        private void LabDive_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LabDive.ForeColor == Color.Red)
                {
                    LabDive.Text = "[X] LAB DIVE";
                    LabDive.ForeColor = Color.Green;
                }
                else if (LabDive.ForeColor == Color.Green)
                {
                    LabDive.Text = "[  ] LAB DIVE";
                    LabDive.ForeColor = Color.Red;
                }
            }
        }

        private void HPAboveLab_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HPAboveLab.ForeColor == Color.Red)
                {
                    HPAboveLab.Text = "[X] HP ABOVE LAB";
                    HPAboveLab.ForeColor = Color.Green;
                }
                else if (HPAboveLab.ForeColor == Color.Green)
                {
                    HPAboveLab.Text = "[  ] HP ABOVE LAB";
                    HPAboveLab.ForeColor = Color.Red;
                }
            }
        }

        private void SunkenBottle_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SunkenBottle.ForeColor == Color.Red)
                {
                    SunkenBottle.Text = "[X] SUNKEN BOTTLE";
                    SunkenBottle.ForeColor = Color.Green;
                }
                else if (SunkenBottle.ForeColor == Color.Green)
                {
                    SunkenBottle.Text = "[  ] SUNKEN BOTTLE";
                    SunkenBottle.ForeColor = Color.Red;
                }
            }
        }

        private void ShootTheSun_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ShootTheSun.ForeColor == Color.Red)
                {
                    ShootTheSun.Text = "[X] SHOOT THE SUN";
                    ShootTheSun.ForeColor = Color.Green;
                }
                else if (ShootTheSun.ForeColor == Color.Green)
                {
                    ShootTheSun.Text = "[  ] SHOOT THE SUN";
                    ShootTheSun.ForeColor = Color.Red;
                }
            }
        }

        private void HPOne_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HPOne.ForeColor == Color.Red)
                {
                    HPOne.Text = "[X] HP 1";
                    HPOne.ForeColor = Color.Green;
                }
                else if (HPOne.ForeColor == Color.Green)
                {
                    HPOne.Text = "[  ] HP 1";
                    HPOne.ForeColor = Color.Red;
                }
            }
        }

        private void HPTwo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HPTwo.ForeColor == Color.Red)
                {
                    HPTwo.Text = "[X] HP 2";
                    HPTwo.ForeColor = Color.Green;
                }
                else if (HPTwo.ForeColor == Color.Green)
                {
                    HPTwo.Text = "[  ] HP 2";
                    HPTwo.ForeColor = Color.Red;
                }
            }
        }

        private void MagicBeans_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MagicBeans.ForeColor == Color.Red)
                {
                    MagicBeans.Text = "[X] MAGIC BEANS";
                    MagicBeans.ForeColor = Color.Green;
                }
                else if (MagicBeans.ForeColor == Color.Green)
                {
                    MagicBeans.Text = "[  ] MAGIC BEANS";
                    MagicBeans.ForeColor = Color.Red;
                }
            }
        }

        private void OpenGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (OpenGrotto.ForeColor == Color.Red)
                {
                    OpenGrotto.Text = "[X] OPEN GROTTO";
                    OpenGrotto.ForeColor = Color.Green;
                }
                else if (OpenGrotto.ForeColor == Color.Green)
                {
                    OpenGrotto.Text = "[  ] OPEN GROTTO";
                    OpenGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void FrogsInTheRain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FrogsInTheRain.ForeColor == Color.Red)
                {
                    FrogsInTheRain.Text = "[X] FROGS IN THE RAIN";
                    FrogsInTheRain.ForeColor = Color.Green;
                }
                else if (FrogsInTheRain.ForeColor == Color.Green)
                {
                    FrogsInTheRain.Text = "[  ] FROGS IN THE RAIN";
                    FrogsInTheRain.ForeColor = Color.Red;
                }
            }
        }

        private void FrogsSong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FrogsSong.ForeColor == Color.Red)
                {
                    FrogsSong.Text = "[X] FROGS SONG";
                    FrogsSong.ForeColor = Color.Green;
                }
                else if (FrogsSong.ForeColor == Color.Green)
                {
                    FrogsSong.Text = "[  ] FROGS SONG";
                    FrogsSong.ForeColor = Color.Red;
                }
            }
        }

        private void DivingGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (DivingGame.ForeColor == Color.Red)
                {
                    DivingGame.Text = "[X] DIVING GAME";
                    DivingGame.ForeColor = Color.Green;
                }
                else if (DivingGame.ForeColor == Color.Green)
                {
                    DivingGame.Text = "[  ] DIVING GAME";
                    DivingGame.ForeColor = Color.Red;
                }
            }
        }

        private void TorchesChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TorchesChest.ForeColor == Color.Red)
                {
                    TorchesChest.Text = "[X] TORCHES CHEST";
                    TorchesChest.ForeColor = Color.Green;
                }
                else if (TorchesChest.ForeColor == Color.Green)
                {
                    TorchesChest.Text = "[  ] TORCHES CHEST";
                    TorchesChest.ForeColor = Color.Red;
                }
            }
        }

        private void ZoraShop_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ZoraShop.ForeColor == Color.Red)
                {
                    ZoraShop.Text = "[X] SHOP";
                    ZoraShop.ForeColor = Color.Green;
                }
                else if (ZoraShop.ForeColor == Color.Green)
                {
                    ZoraShop.Text = "[  ] SHOP";
                    ZoraShop.ForeColor = Color.Red;
                }
            }
        }

        private void KingZora_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (KingZora.ForeColor == Color.Red)
                {
                    KingZora.Text = "[X] KING ZORA";
                    KingZora.ForeColor = Color.Green;
                }
                else if (KingZora.ForeColor == Color.Green)
                {
                    KingZora.Text = "[  ] KING ZORA";
                    KingZora.ForeColor = Color.Red;
                }
            }
        }

        private void TrailBombWall_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TrailBombWall.ForeColor == Color.Red)
                {
                    TrailBombWall.Text = "[X] TRAIL BOMB WALL";
                    TrailBombWall.ForeColor = Color.Green;
                }
                else if (TrailBombWall.ForeColor == Color.Green)
                {
                    TrailBombWall.Text = "[  ] TRAIL BOMB WALL";
                    TrailBombWall.ForeColor = Color.Red;
                }
            }
        }

        private void HPAboveDC_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HPAboveDC.ForeColor == Color.Red)
                {
                    HPAboveDC.Text = "[X] HP ABOVE DC";
                    HPAboveDC.ForeColor = Color.Green;
                }
                else if (HPAboveDC.ForeColor == Color.Green)
                {
                    HPAboveDC.Text = "[  ] HP ABOVE DC";
                    HPAboveDC.ForeColor = Color.Red;
                }
            }
        }

        private void SOSGrottoRocks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SOSGrottoRocks.ForeColor == Color.Red)
                {
                    SOSGrottoRocks.Text = "[X] SOS GROTTO";
                    SOSGrottoRocks.ForeColor = Color.Green;
                }
                else if (SOSGrottoRocks.ForeColor == Color.Green)
                {
                    SOSGrottoRocks.Text = "[  ] SOS GROTTO";
                    SOSGrottoRocks.ForeColor = Color.Red;
                }
            }
        }

        private void CraterWallHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CraterWallHP.ForeColor == Color.Red)
                {
                    CraterWallHP.Text = "[X] CRATER WALL HP";
                    CraterWallHP.ForeColor = Color.Green;
                }
                else if (CraterWallHP.ForeColor == Color.Green)
                {
                    CraterWallHP.Text = "[  ] CRATER WALL HP";
                    CraterWallHP.ForeColor = Color.Red;
                }
            }
        }

        private void CraterGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CraterGrotto.ForeColor == Color.Red)
                {
                    CraterGrotto.Text = "[X] CRATER GROTTO";
                    CraterGrotto.ForeColor = Color.Green;
                }
                else if (CraterGrotto.ForeColor == Color.Green)
                {
                    CraterGrotto.Text = "[  ] CRATER GROTTO";
                    CraterGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void CraterTopHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CraterTopHP.ForeColor == Color.Red)
                {
                    CraterTopHP.Text = "[X] CRATER TOP HP";
                    CraterTopHP.ForeColor = Color.Green;
                }
                else if (CraterTopHP.ForeColor == Color.Green)
                {
                    CraterTopHP.Text = "[  ] CRATER TOP HP";
                    CraterTopHP.ForeColor = Color.Red;
                }
            }
        }

        private void CraterFairy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CraterFairy.ForeColor == Color.Red)
                {
                    CraterFairy.Text = "[X] CRATER FAIRY";
                    CraterFairy.ForeColor = Color.Green;
                }
                else if (CraterFairy.ForeColor == Color.Green)
                {
                    CraterFairy.Text = "[  ] CRATER FAIRY";
                    CraterFairy.ForeColor = Color.Red;
                }
            }
        }

        private void BiggoronTrade_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BiggoronTrade.ForeColor == Color.Red)
                {
                    BiggoronTrade.Text = "[X] BIGGORON TRADE";
                    BiggoronTrade.ForeColor = Color.Green;
                }
                else if (BiggoronTrade.ForeColor == Color.Green)
                {
                    BiggoronTrade.Text = "[  ] BIGGORON TRADE";
                    BiggoronTrade.ForeColor = Color.Red;
                }
            }
        }

        private void SummitFairy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SummitFairy.ForeColor == Color.Red)
                {
                    SummitFairy.Text = "[X] SUMMIT FAIRY";
                    SummitFairy.ForeColor = Color.Green;
                }
                else if (SummitFairy.ForeColor == Color.Green)
                {
                    SummitFairy.Text = "[  ] SUMMIT FAIRY";
                    SummitFairy.ForeColor = Color.Red;
                }
            }
        }

        private void MazeLeft_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeLeft.ForeColor == Color.Red)
                {
                    MazeLeft.Text = "[X] MAZE LEFT";
                    MazeLeft.ForeColor = Color.Green;
                }
                else if (MazeLeft.ForeColor == Color.Green)
                {
                    MazeLeft.Text = "[  ] MAZE LEFT";
                    MazeLeft.ForeColor = Color.Red;
                }
            }
        }

        private void MazeCenter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeCenter.ForeColor == Color.Red)
                {
                    MazeCenter.Text = "[X] MAZE CENTER";
                    MazeCenter.ForeColor = Color.Green;
                }
                else if (MazeCenter.ForeColor == Color.Green)
                {
                    MazeCenter.Text = "[  ] MAZE CENTER";
                    MazeCenter.ForeColor = Color.Red;
                }
            }
        }

        private void MazeRight_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeRight.ForeColor == Color.Red)
                {
                    MazeRight.Text = "[X] MAZE RIGHT";
                    MazeRight.ForeColor = Color.Green;
                }
                else if (MazeRight.ForeColor == Color.Green)
                {
                    MazeRight.Text = "[  ] MAZE RIGHT";
                    MazeRight.ForeColor = Color.Red;
                }
            }
        }

        private void Bolero_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Bolero.ForeColor == Color.Red)
                {
                    Bolero.Text = "[X] BOLERO";
                    Bolero.ForeColor = Color.Green;
                }
                else if (Bolero.ForeColor == Color.Green)
                {
                    Bolero.Text = "[  ] BOLERO";
                    Bolero.ForeColor = Color.Red;
                }
            }
        }

        private void RollingGoronSmall_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RollingGoronSmall.ForeColor == Color.Red)
                {
                    RollingGoronSmall.Text = "[X] ROLLING GORON SMALL";
                    RollingGoronSmall.ForeColor = Color.Green;
                }
                else if (RollingGoronSmall.ForeColor == Color.Green)
                {
                    RollingGoronSmall.Text = "[  ] ROLLING GORON SMALL";
                    RollingGoronSmall.ForeColor = Color.Red;
                }
            }
        }

        private void RollingGoronLarge_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RollingGoronLarge.ForeColor == Color.Red)
                {
                    RollingGoronLarge.Text = "[X] ROLLING GORON LARGE";
                    RollingGoronLarge.ForeColor = Color.Green;
                }
                else if (RollingGoronLarge.ForeColor == Color.Green)
                {
                    RollingGoronLarge.Text = "[  ] ROLLING GORON LARGE";
                    RollingGoronLarge.ForeColor = Color.Red;
                }
            }
        }

        private void Darunia_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Darunia.ForeColor == Color.Red)
                {
                    Darunia.Text = "[X] DARUNIA";
                    Darunia.ForeColor = Color.Green;
                }
                else if (Darunia.ForeColor == Color.Green)
                {
                    Darunia.Text = "[  ] DARUNIA";
                    Darunia.ForeColor = Color.Red;
                }
            }
        }

        private void LavaRoomGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LavaRoomGrotto.ForeColor == Color.Red)
                {
                    LavaRoomGrotto.Text = "[X] LAVA ROOM GROTTO";
                    LavaRoomGrotto.ForeColor = Color.Green;
                }
                else if (LavaRoomGrotto.ForeColor == Color.Green)
                {
                    LavaRoomGrotto.Text = "[  ] LAVA ROOM GROTTO";
                    LavaRoomGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void SpinningPot_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SpinningPot.ForeColor == Color.Red)
                {
                    SpinningPot.Text = "[X] SPINNING POT";
                    SpinningPot.ForeColor = Color.Green;
                }
                else if (SpinningPot.ForeColor == Color.Green)
                {
                    SpinningPot.Text = "[  ] SPINNING POT";
                    SpinningPot.ForeColor = Color.Red;
                }
            }
        }

        private void ZeldasLullaby_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ZeldasLullaby.ForeColor == Color.Red)
                {
                    ZeldasLullaby.Text = "[X] ZELDA'S LULLABY";
                    ZeldasLullaby.ForeColor = Color.Green;
                }
                else if (ZeldasLullaby.ForeColor == Color.Green)
                {
                    ZeldasLullaby.Text = "[  ] ZELDA'S LULLABY";
                    ZeldasLullaby.ForeColor = Color.Red;
                }
            }
        }

        private void HammerRocks_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HammerRocks.ForeColor == Color.Red)
                {
                    HammerRocks.Text = "[X] HAMMER ROCKS";
                    HammerRocks.ForeColor = Color.Green;
                }
                else if (HammerRocks.ForeColor == Color.Green)
                {
                    HammerRocks.Text = "[  ] HAMMER ROCKS";
                    HammerRocks.ForeColor = Color.Red;
                }
            }
        }

        private void CrateHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CrateHP.ForeColor == Color.Red)
                {
                    CrateHP.Text = "[X] CRATE HP";
                    CrateHP.ForeColor = Color.Green;
                }
                else if (CrateHP.ForeColor == Color.Green)
                {
                    CrateHP.Text = "[  ] CRATE HP";
                    CrateHP.ForeColor = Color.Red;
                }
            }
        }

        private void WaterfallHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WaterfallHP.ForeColor == Color.Red)
                {
                    WaterfallHP.Text = "[X] WATERFALL HP";
                    WaterfallHP.ForeColor = Color.Green;
                }
                else if (WaterfallHP.ForeColor == Color.Green)
                {
                    WaterfallHP.Text = "[  ] WATERFALL HP";
                    WaterfallHP.ForeColor = Color.Red;
                }
            }
        }

        private void FortressRooftop_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FortressRooftop.ForeColor == Color.Red)
                {
                    FortressRooftop.Text = "[X] FORTRESS ROOFTOP";
                    FortressRooftop.ForeColor = Color.Green;
                }
                else if (FortressRooftop.ForeColor == Color.Green)
                {
                    FortressRooftop.Text = "[  ] FORTRESS ROOFTOP";
                    FortressRooftop.ForeColor = Color.Red;
                }
            }
        }

        private void PrisonerOne_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (PrisonerOne.ForeColor == Color.Red)
                {
                    PrisonerOne.Text = "[X] PRISONER 1";
                    PrisonerOne.ForeColor = Color.Green;
                }
                else if (PrisonerOne.ForeColor == Color.Green)
                {
                    PrisonerOne.Text = "[  ] PRISONER 1";
                    PrisonerOne.ForeColor = Color.Red;
                }
            }
        }

        private void PrisonerTwo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (PrisonerTwo.ForeColor == Color.Red)
                {
                    PrisonerTwo.Text = "[X] PRISONER 2";
                    PrisonerTwo.ForeColor = Color.Green;
                }
                else if (PrisonerTwo.ForeColor == Color.Green)
                {
                    PrisonerTwo.Text = "[  ] PRISONER 2";
                    PrisonerTwo.ForeColor = Color.Red;
                }
            }
        }

        private void PrisonerThree_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (PrisonerThree.ForeColor == Color.Red)
                {
                    PrisonerThree.Text = "[X] PRISONER 3";
                    PrisonerThree.ForeColor = Color.Green;
                }
                else if (PrisonerThree.ForeColor == Color.Green)
                {
                    PrisonerThree.Text = "[  ] PRISONER 3";
                    PrisonerThree.ForeColor = Color.Red;
                }
            }
        }

        private void PrisonerFour_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (PrisonerFour.ForeColor == Color.Red)
                {
                    PrisonerFour.Text = "[X] PRISONER 4";
                    PrisonerFour.ForeColor = Color.Green;
                }
                else if (PrisonerFour.ForeColor == Color.Green)
                {
                    PrisonerFour.Text = "[  ] PRISONER 4";
                    PrisonerFour.ForeColor = Color.Red;
                }
            }
        }

        private void GerudosLetter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GerudosLetter.ForeColor == Color.Red)
                {
                    GerudosLetter.Text = "[X] GERUDO'S LETTER";
                    GerudosLetter.ForeColor = Color.Green;
                }
                else if (GerudosLetter.ForeColor == Color.Green)
                {
                    GerudosLetter.Text = "[  ] GERUDO'S LETTER";
                    GerudosLetter.ForeColor = Color.Red;
                }
            }
        }

        private void ArcheryOne_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ArcheryOne.ForeColor == Color.Red)
                {
                    ArcheryOne.Text = "[X] ARCHERY 1000";
                    ArcheryOne.ForeColor = Color.Green;
                }
                else if (ArcheryOne.ForeColor == Color.Green)
                {
                    ArcheryOne.Text = "[  ] ARCHERY 1000";
                    ArcheryOne.ForeColor = Color.Red;
                }
            }
        }

        private void ArcheryTwo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ArcheryTwo.ForeColor == Color.Red)
                {
                    ArcheryTwo.Text = "[X] ARCHERY 1500";
                    ArcheryTwo.ForeColor = Color.Green;
                }
                else if (ArcheryTwo.ForeColor == Color.Green)
                {
                    ArcheryTwo.Text = "[  ] ARCHERY 1500";
                    ArcheryTwo.ForeColor = Color.Red;
                }
            }
        }

        private void ColossusHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ColossusHP.ForeColor == Color.Red)
                {
                    ColossusHP.Text = "[X] COLOSSUS HP";
                    ColossusHP.ForeColor = Color.Green;
                }
                else if (ColossusHP.ForeColor == Color.Green)
                {
                    ColossusHP.Text = "[  ] COLOSSUS HP";
                    ColossusHP.ForeColor = Color.Red;
                }
            }
        }

        private void Requiem_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Requiem.ForeColor == Color.Red)
                {
                    Requiem.Text = "[X] REQUIEM";
                    Requiem.ForeColor = Color.Green;
                }
                else if (Requiem.ForeColor == Color.Green)
                {
                    Requiem.Text = "[  ] REQUIEM";
                    Requiem.ForeColor = Color.Red;
                }
            }
        }

        private void StatueHandChild_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (StatueHandChild.ForeColor == Color.Red)
                {
                    StatueHandChild.Text = "[X] STATUE HAND CHILD";
                    StatueHandChild.ForeColor = Color.Green;
                }
                else if (StatueHandChild.ForeColor == Color.Green)
                {
                    StatueHandChild.Text = "[  ] STATUE HAND CHILD";
                    StatueHandChild.ForeColor = Color.Red;
                }
            }
        }

        private void StatueHandAdult_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (StatueHandAdult.ForeColor == Color.Red)
                {
                    StatueHandAdult.Text = "[X] STATUE HAND ADULT";
                    StatueHandAdult.ForeColor = Color.Green;
                }
                else if (StatueHandAdult.ForeColor == Color.Green)
                {
                    StatueHandAdult.Text = "[  ] STATUE HAND ADULT";
                    StatueHandAdult.ForeColor = Color.Red;
                }
            }
        }

        private void ColossusFairy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ColossusFairy.ForeColor == Color.Red)
                {
                    ColossusFairy.Text = "[X] COLOSSUS FAIRY";
                    ColossusFairy.ForeColor = Color.Green;
                }
                else if (ColossusFairy.ForeColor == Color.Green)
                {
                    ColossusFairy.Text = "[  ] COLOSSUS FAIRY";
                    ColossusFairy.ForeColor = Color.Red;
                }
            }
        }

        private void ColossusGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ColossusGrotto.ForeColor == Color.Red)
                {
                    ColossusGrotto.Text = "[X] COLOSSUS GROTTO";
                    ColossusGrotto.ForeColor = Color.Green;
                }
                else if (ColossusGrotto.ForeColor == Color.Green)
                {
                    ColossusGrotto.Text = "[  ] COLOSSUS GROTTO";
                    ColossusGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void WastelandTorches_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WastelandTorches.ForeColor == Color.Red)
                {
                    WastelandTorches.Text = "[X] WASTELAND TORCHES";
                    WastelandTorches.ForeColor = Color.Green;
                }
                else if (WastelandTorches.ForeColor == Color.Green)
                {
                    WastelandTorches.Text = "[  ] WASTELAND TORCHES";
                    WastelandTorches.ForeColor = Color.Red;
                }
            }
        }

        private void EponasSong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (EponasSong.ForeColor == Color.Red)
                {
                    EponasSong.Text = "[X] EPONA'S SONG";
                    EponasSong.ForeColor = Color.Green;
                }
                else if (EponasSong.ForeColor == Color.Green)
                {
                    EponasSong.Text = "[  ] EPONA'S SONG";
                    EponasSong.ForeColor = Color.Red;
                }
            }
        }

        private void CuccoGame_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CuccoGame.ForeColor == Color.Red)
                {
                    CuccoGame.Text = "[X] CUCCO GAME";
                    CuccoGame.ForeColor = Color.Green;
                }
                else if (CuccoGame.ForeColor == Color.Green)
                {
                    CuccoGame.Text = "[  ] CUCCO GAME";
                    CuccoGame.ForeColor = Color.Red;
                }
            }
        }

        private void LonLonGrotto_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LonLonGrotto.ForeColor == Color.Red)
                {
                    LonLonGrotto.Text = "[X] LON LON GROTTO";
                    LonLonGrotto.ForeColor = Color.Green;
                }
                else if (LonLonGrotto.ForeColor == Color.Green)
                {
                    LonLonGrotto.Text = "[  ] LON LON GROTTO";
                    LonLonGrotto.ForeColor = Color.Red;
                }
            }
        }

        private void CratesHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CratesHP.ForeColor == Color.Red)
                {
                    CratesHP.Text = "[X] CRATES HP";
                    CratesHP.ForeColor = Color.Green;
                }
                else if (CratesHP.ForeColor == Color.Green)
                {
                    CratesHP.Text = "[  ] CRATES HP";
                    CratesHP.ForeColor = Color.Red;
                }
            }
        }

        private void Lobby_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Lobby.ForeColor == Color.Red)
                {
                    Lobby.Text = "[X] LOBBY";
                    Lobby.ForeColor = Color.Green;
                }
                else if (Lobby.ForeColor == Color.Green)
                {
                    Lobby.Text = "[  ] LOBBY";
                    Lobby.ForeColor = Color.Red;
                }
            }
        }

        private void FallingPlatform_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FallingPlatform.ForeColor == Color.Red)
                {
                    FallingPlatform.Text = "[X] FALLING PLATFORM 1";
                    FallingPlatform.ForeColor = Color.Green;
                }
                else if (FallingPlatform.ForeColor == Color.Green)
                {
                    FallingPlatform.Text = "[  ] FALLING PLATFORM 1";
                    FallingPlatform.ForeColor = Color.Red;
                }
            }
        }

        private void FallingPlatformTwo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FallingPlatform2.ForeColor == Color.Red)
                {
                    FallingPlatform2.Text = "[X] FALLING PLATFORM 2";
                    FallingPlatform2.ForeColor = Color.Green;
                }
                else if (FallingPlatform2.ForeColor == Color.Green)
                {
                    FallingPlatform2.Text = "[  ] FALLING PLATFORM 2";
                    FallingPlatform2.ForeColor = Color.Red;
                }
            }
        }

        private void RisingPlatforms1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RisingPlatforms1.ForeColor == Color.Red)
                {
                    RisingPlatforms1.Text = "[X] RISING PLATFORMS 1";
                    RisingPlatforms1.ForeColor = Color.Green;
                }
                else if (RisingPlatforms1.ForeColor == Color.Green)
                {
                    RisingPlatforms1.Text = "[  ] RISING PLATFORMS 1";
                    RisingPlatforms1.ForeColor = Color.Red;
                }
            }
        }

        private void RisingPlatforms2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RisingPlatforms2.ForeColor == Color.Red)
                {
                    RisingPlatforms2.Text = "[X] RISING PLATFORMS 2";
                    RisingPlatforms2.ForeColor = Color.Green;
                }
                else if (RisingPlatforms2.ForeColor == Color.Green)
                {
                    RisingPlatforms2.Text = "[  ] RISING PLATFORMS 2";
                    RisingPlatforms2.ForeColor = Color.Red;
                }
            }
        }

        private void Basement_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Basement.ForeColor == Color.Red)
                {
                    Basement.Text = "[X] BASEMENT";
                    Basement.ForeColor = Color.Green;
                }
                else if (Basement.ForeColor == Color.Green)
                {
                    Basement.Text = "[  ] BASEMENT";
                    Basement.ForeColor = Color.Red;
                }
            }
        }

        private void GohmaHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GohmaHP.ForeColor == Color.Red)
                {
                    GohmaHP.Text = "[X] GOHMA HP";
                    GohmaHP.ForeColor = Color.Green;
                }
                else if (GohmaHP.ForeColor == Color.Green)
                {
                    GohmaHP.Text = "[  ] GOHMA HP";
                    GohmaHP.ForeColor = Color.Red;
                }
            }
        }

        private void GoronShop_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GoronShop.ForeColor == Color.Red)
                {
                    GoronShop.Text = "[X] SHOP";
                    GoronShop.ForeColor = Color.Green;
                }
                else if (GoronShop.ForeColor == Color.Green)
                {
                    GoronShop.Text = "[  ] SHOP";
                    GoronShop.ForeColor = Color.Red;
                }
            }
        }

        private void LobbyChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LobbyChest.ForeColor == Color.Red)
                {
                    LobbyChest.Text = "[X] LOBBY CHEST";
                    LobbyChest.ForeColor = Color.Green;
                }
                else if (LobbyChest.ForeColor == Color.Green)
                {
                    LobbyChest.Text = "[  ] LOBBY CHEST";
                    LobbyChest.ForeColor = Color.Red;
                }
            }
        }

        private void LobbyScrub_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LobbyScrub.ForeColor == Color.Red)
                {
                    LobbyScrub.Text = "[X] LOBBY SCRUB";
                    LobbyScrub.ForeColor = Color.Green;
                }
                else if (LobbyScrub.ForeColor == Color.Green)
                {
                    LobbyScrub.Text = "[  ] LOBBY SCRUB";
                    LobbyScrub.ForeColor = Color.Red;
                }
            }
        }

        private void BladeRoomSmall_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BladeRoomSmall.ForeColor == Color.Red)
                {
                    BladeRoomSmall.Text = "[X] BLADE ROOM SMALL";
                    BladeRoomSmall.ForeColor = Color.Green;
                }
                else if (BladeRoomSmall.ForeColor == Color.Green)
                {
                    BladeRoomSmall.Text = "[  ] BLADE ROOM SMALL";
                    BladeRoomSmall.ForeColor = Color.Red;
                }
            }
        }

        private void BladeRoomBig_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BladeRoomBig.ForeColor == Color.Red)
                {
                    BladeRoomBig.Text = "[X] BLADE ROOM BIG";
                    BladeRoomBig.ForeColor = Color.Green;
                }
                else if (BladeRoomBig.ForeColor == Color.Green)
                {
                    BladeRoomBig.Text = "[  ] BLADE ROOM BIG";
                    BladeRoomBig.ForeColor = Color.Red;
                }
            }
        }

        private void TorchScrubs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TorchScrubs.ForeColor == Color.Red)
                {
                    TorchScrubs.Text = "[X] TORCH ROOM SCRUBS";
                    TorchScrubs.ForeColor = Color.Green;
                }
                else if (TorchScrubs.ForeColor == Color.Green)
                {
                    TorchScrubs.Text = "[  ] TORCH ROOM SCRUBS";
                    TorchScrubs.ForeColor = Color.Red;
                }
            }
        }

        private void BladeRoomScrubs_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BladeRoomScrubs.ForeColor == Color.Red)
                {
                    BladeRoomScrubs.Text = "[X] BLADE ROOM SCRUBS";
                    BladeRoomScrubs.ForeColor = Color.Green;
                }
                else if (BladeRoomScrubs.ForeColor == Color.Green)
                {
                    BladeRoomScrubs.Text = "[  ] BLADE ROOM SCRUBS";
                    BladeRoomScrubs.ForeColor = Color.Red;
                }
            }
        }

        private void EndOfBridge_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (EndOfBridge.ForeColor == Color.Red)
                {
                    EndOfBridge.Text = "[X] END OF BRIDGE";
                    EndOfBridge.ForeColor = Color.Green;
                }
                else if (EndOfBridge.ForeColor == Color.Green)
                {
                    EndOfBridge.Text = "[  ] END OF BRIDGE";
                    EndOfBridge.ForeColor = Color.Red;
                }
            }
        }

        private void AboveDodongo_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (AboveDodongo.ForeColor == Color.Red)
                {
                    AboveDodongo.Text = "[X] ABOVE DODONGO";
                    AboveDodongo.ForeColor = Color.Green;
                }
                else if (AboveDodongo.ForeColor == Color.Green)
                {
                    AboveDodongo.Text = "[  ] ABOVE DODONGO";
                    AboveDodongo.ForeColor = Color.Red;
                }
            }
        }

        private void DodongoHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (DodongoHP.ForeColor == Color.Red)
                {
                    DodongoHP.Text = "[X] DODONGO HP";
                    DodongoHP.ForeColor = Color.Green;
                }
                else if (DodongoHP.ForeColor == Color.Green)
                {
                    DodongoHP.Text = "[  ] DODONGO HP";
                    DodongoHP.ForeColor = Color.Red;
                }
            }
        }

        private void BubblesChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BubblesChest.ForeColor == Color.Red)
                {
                    BubblesChest.Text = "[X] BUBBLES CHEST";
                    BubblesChest.ForeColor = Color.Green;
                }
                else if (BubblesChest.ForeColor == Color.Green)
                {
                    BubblesChest.Text = "[  ] BUBBLES CHEST";
                    BubblesChest.ForeColor = Color.Red;
                }
            }
        }

        private void MapChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MapChest.ForeColor == Color.Red)
                {
                    MapChest.Text = "[X] MAP CHEST";
                    MapChest.ForeColor = Color.Green;
                }
                else if (MapChest.ForeColor == Color.Green)
                {
                    MapChest.Text = "[  ] MAP CHEST";
                    MapChest.ForeColor = Color.Red;
                }
            }
        }

        private void CompassChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CompassChest.ForeColor == Color.Red)
                {
                    CompassChest.Text = "[X] COMPASS CHEST";
                    CompassChest.ForeColor = Color.Green;
                }
                else if (CompassChest.ForeColor == Color.Green)
                {
                    CompassChest.Text = "[  ] COMPASS CHEST";
                    CompassChest.ForeColor = Color.Red;
                }
            }
        }

        private void BarinadeHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BarinadeHP.ForeColor == Color.Red)
                {
                    BarinadeHP.Text = "[X] BARINADE HP";
                    BarinadeHP.ForeColor = Color.Green;
                }
                else if (BarinadeHP.ForeColor == Color.Green)
                {
                    BarinadeHP.Text = "[  ] BARINADE HP";
                    BarinadeHP.ForeColor = Color.Red;
                }
            }
        }

        private void FrontLeftHidden_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FrontLeftHidden.ForeColor == Color.Red)
                {
                    FrontLeftHidden.Text = "[X] FRONT LEFT HIDDEN";
                    FrontLeftHidden.ForeColor = Color.Green;
                }
                else if (FrontLeftHidden.ForeColor == Color.Green)
                {
                    FrontLeftHidden.Text = "[  ] FRONT LEFT HIDDEN";
                    FrontLeftHidden.ForeColor = Color.Red;
                }
            }
        }

        private void FrontRightHidden_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FrontRightHidden.ForeColor == Color.Red)
                {
                    FrontRightHidden.Text = "[X] FRONT RIGHT HIDDEN";
                    FrontRightHidden.ForeColor = Color.Green;
                }
                else if (FrontRightHidden.ForeColor == Color.Green)
                {
                    FrontRightHidden.Text = "[  ] FRONT RIGHT HIDDEN";
                    FrontRightHidden.ForeColor = Color.Red;
                }
            }
        }

        private void FrontBomb_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FrontBomb.ForeColor == Color.Red)
                {
                    FrontBomb.Text = "[X] FRONT BOMB";
                    FrontBomb.ForeColor = Color.Green;
                }
                else if (FrontBomb.ForeColor == Color.Green)
                {
                    FrontBomb.Text = "[  ] FRONT BOMB";
                    FrontBomb.ForeColor = Color.Red;
                }
            }
        }

        private void CenterLarge_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CenterLarge.ForeColor == Color.Red)
                {
                    CenterLarge.Text = "[X] CENTER LARGE";
                    CenterLarge.ForeColor = Color.Green;
                }
                else if (CenterLarge.ForeColor == Color.Green)
                {
                    CenterLarge.Text = "[  ] CENTER LARGE";
                    CenterLarge.ForeColor = Color.Red;
                }
            }
        }

        private void CenterSmall_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CenterSmall.ForeColor == Color.Red)
                {
                    CenterSmall.Text = "[X] CENTER SMALL";
                    CenterSmall.ForeColor = Color.Green;
                }
                else if (CenterSmall.ForeColor == Color.Green)
                {
                    CenterSmall.Text = "[  ] CENTER SMALL";
                    CenterSmall.ForeColor = Color.Red;
                }
            }
        }

        private void BackLeftBomb_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BackLeftBomb.ForeColor == Color.Red)
                {
                    BackLeftBomb.Text = "[X] BACK LEFT BOMB";
                    BackLeftBomb.ForeColor = Color.Green;
                }
                else if (BackLeftBomb.ForeColor == Color.Green)
                {
                    BackLeftBomb.Text = "[  ] BACK LEFT BOMB";
                    BackLeftBomb.ForeColor = Color.Red;
                }
            }
        }

        private void BOTWBasement_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BOTWBasement.ForeColor == Color.Red)
                {
                    BOTWBasement.Text = "[X] BASEMENT";
                    BOTWBasement.ForeColor = Color.Green;
                }
                else if (BOTWBasement.ForeColor == Color.Green)
                {
                    BOTWBasement.Text = "[  ] BASEMENT";
                    BOTWBasement.ForeColor = Color.Red;
                }
            }
        }

        private void FrontWater_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FrontWater.ForeColor == Color.Red)
                {
                    FrontWater.Text = "[X] FRONT WATER";
                    FrontWater.ForeColor = Color.Green;
                }
                else if (FrontWater.ForeColor == Color.Green)
                {
                    FrontWater.Text = "[  ] FRONT WATER";
                    FrontWater.ForeColor = Color.Red;
                }
            }
        }

        private void LeftWater_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LeftWater.ForeColor == Color.Red)
                {
                    LeftWater.Text = "[X] LEFT WATER";
                    LeftWater.ForeColor = Color.Green;
                }
                else if (LeftWater.ForeColor == Color.Green)
                {
                    LeftWater.Text = "[  ] LEFT WATER";
                    LeftWater.ForeColor = Color.Red;
                }
            }
        }

        private void Coffin_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Coffin.ForeColor == Color.Red)
                {
                    Coffin.Text = "[X] COFFIN";
                    Coffin.ForeColor = Color.Green;
                }
                else if (Coffin.ForeColor == Color.Green)
                {
                    Coffin.Text = "[  ] COFFIN";
                    Coffin.ForeColor = Color.Red;
                }
            }
        }

        private void DeadHandChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (DeadHandChest.ForeColor == Color.Red)
                {
                    DeadHandChest.Text = "[X] DEAD HAND CHEST";
                    DeadHandChest.ForeColor = Color.Green;
                }
                else if (DeadHandChest.ForeColor == Color.Green)
                {
                    DeadHandChest.Text = "[  ] DEAD HAND CHEST";
                    DeadHandChest.ForeColor = Color.Red;
                }
            }
        }

        private void DeadHandChestHidden_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (DeadHandChestHidden.ForeColor == Color.Red)
                {
                    DeadHandChestHidden.Text = "[X] DEAD HAND CHEST HIDDEN";
                    DeadHandChestHidden.ForeColor = Color.Green;
                }
                else if (DeadHandChestHidden.ForeColor == Color.Green)
                {
                    DeadHandChestHidden.Text = "[  ] DEAD HAND CHEST HIDDEN";
                    DeadHandChestHidden.ForeColor = Color.Red;
                }
            }
        }

        private void PitsChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (PitsChest.ForeColor == Color.Red)
                {
                    PitsChest.Text = "[X] PITS CHEST";
                    PitsChest.ForeColor = Color.Green;
                }
                else if (PitsChest.ForeColor == Color.Green)
                {
                    PitsChest.Text = "[  ] PITS CHEST";
                    PitsChest.ForeColor = Color.Red;
                }
            }
        }

        private void LikeLikeChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LikeLikeChest.ForeColor == Color.Red)
                {
                    LikeLikeChest.Text = "[X] LIKE LIKE CHEST";
                    LikeLikeChest.ForeColor = Color.Green;
                }
                else if (LikeLikeChest.ForeColor == Color.Green)
                {
                    LikeLikeChest.Text = "[  ] LIKE LIKE CHEST";
                    LikeLikeChest.ForeColor = Color.Red;
                }
            }
        }

        private void TopOfTree_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TopOfTree.ForeColor == Color.Red)
                {
                    TopOfTree.Text = "[X] TOP OF TREE";
                    TopOfTree.ForeColor = Color.Green;
                }
                else if (TopOfTree.ForeColor == Color.Green)
                {
                    TopOfTree.Text = "[  ] TOP OF TREE";
                    TopOfTree.ForeColor = Color.Red;
                }
            }
        }

        private void StalfosBehindLobby_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (StalfosBehindLobby.ForeColor == Color.Red)
                {
                    StalfosBehindLobby.Text = "[X] STALFOS BEHIND LOBBY";
                    StalfosBehindLobby.ForeColor = Color.Green;
                }
                else if (StalfosBehindLobby.ForeColor == Color.Green)
                {
                    StalfosBehindLobby.Text = "[  ] STALFOS BEHIND LOBBY";
                    StalfosBehindLobby.ForeColor = Color.Red;
                }
            }
        }

        private void InsideWell_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (InsideWell.ForeColor == Color.Red)
                {
                    InsideWell.Text = "[X] INSIDE WELL";
                    InsideWell.ForeColor = Color.Green;
                }
                else if (InsideWell.ForeColor == Color.Green)
                {
                    InsideWell.Text = "[  ] INSIDE WELL";
                    InsideWell.ForeColor = Color.Red;
                }
            }
        }

        private void FlameSkullChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FlameSkullChest.ForeColor == Color.Red)
                {
                    FlameSkullChest.Text = "[X] FLAME SKULL CHEST";
                    FlameSkullChest.ForeColor = Color.Green;
                }
                else if (FlameSkullChest.ForeColor == Color.Green)
                {
                    FlameSkullChest.Text = "[  ] FLAME SKULL CHEST";
                    FlameSkullChest.ForeColor = Color.Red;
                }
            }
        }

        private void TopOfMoat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TopOfMoat.ForeColor == Color.Red)
                {
                    TopOfMoat.Text = "[X] TOP OF MOAT";
                    TopOfMoat.ForeColor = Color.Green;
                }
                else if (TopOfMoat.ForeColor == Color.Green)
                {
                    TopOfMoat.Text = "[  ] TOP OF MOAT";
                    TopOfMoat.ForeColor = Color.Red;
                }
            }
        }

        private void EyeTargetChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (EyeTargetChest.ForeColor == Color.Red)
                {
                    EyeTargetChest.Text = "[X] EYE TARGET CHEST";
                    EyeTargetChest.ForeColor = Color.Green;
                }
                else if (EyeTargetChest.ForeColor == Color.Green)
                {
                    EyeTargetChest.Text = "[  ] EYE TARGET CHEST";
                    EyeTargetChest.ForeColor = Color.Red;
                }
            }
        }

        private void BossKeyChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BossKeyChest.ForeColor == Color.Red)
                {
                    BossKeyChest.Text = "[X] BOSS KEY CHEST";
                    BossKeyChest.ForeColor = Color.Green;
                }
                else if (BossKeyChest.ForeColor == Color.Green)
                {
                    BossKeyChest.Text = "[  ] BOSS KEY CHEST";
                    BossKeyChest.ForeColor = Color.Red;
                }
            }
        }

        private void FloormasterChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FloormasterChest.ForeColor == Color.Red)
                {
                    FloormasterChest.Text = "[X] FLOORMASTER CHEST";
                    FloormasterChest.ForeColor = Color.Green;
                }
                else if (FloormasterChest.ForeColor == Color.Green)
                {
                    FloormasterChest.Text = "[  ] FLOORMASTER CHEST";
                    FloormasterChest.ForeColor = Color.Red;
                }
            }
        }

        private void StalfosWaves_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (StalfosWaves.ForeColor == Color.Red)
                {
                    StalfosWaves.Text = "[X] STALFOS WAVES";
                    StalfosWaves.ForeColor = Color.Green;
                }
                else if (StalfosWaves.ForeColor == Color.Green)
                {
                    StalfosWaves.Text = "[  ] STALFOS WAVES";
                    StalfosWaves.ForeColor = Color.Red;
                }
            }
        }

        private void RedPoe_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RedPoe.ForeColor == Color.Red)
                {
                    RedPoe.Text = "[X] RED POE";
                    RedPoe.ForeColor = Color.Green;
                }
                else if (RedPoe.ForeColor == Color.Green)
                {
                    RedPoe.Text = "[  ] RED POE";
                    RedPoe.ForeColor = Color.Red;
                }
            }
        }

        private void BluePoe_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BluePoe.ForeColor == Color.Red)
                {
                    BluePoe.Text = "[X] BLUE POE";
                    BluePoe.ForeColor = Color.Green;
                }
                else if (BluePoe.ForeColor == Color.Green)
                {
                    BluePoe.Text = "[  ] BLUE POE";
                    BluePoe.ForeColor = Color.Red;
                }
            }
        }

        private void FallingRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FallingRoom.ForeColor == Color.Red)
                {
                    FallingRoom.Text = "[X] FALLING ROOM";
                    FallingRoom.ForeColor = Color.Green;
                }
                else if (FallingRoom.ForeColor == Color.Green)
                {
                    FallingRoom.Text = "[  ] FALLING ROOM";
                    FallingRoom.ForeColor = Color.Red;
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void StalfosWaves_Click(object sender, EventArgs e)
        {

        }

        private void FallingRoom_Click(object sender, EventArgs e)
        {

        }

        private void RotatingRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RotatingRoom.ForeColor == Color.Red)
                {
                    RotatingRoom.Text = "[X] ROTATING ROOM";
                    RotatingRoom.ForeColor = Color.Green;
                }
                else if (RotatingRoom.ForeColor == Color.Green)
                {
                    RotatingRoom.Text = "[  ] ROTATING ROOM";
                    RotatingRoom.ForeColor = Color.Red;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PhantomGannonHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (PhantomGannonHP.ForeColor == Color.Red)
                {
                    PhantomGannonHP.Text = "[X] PHANTOM GANON HP";
                    PhantomGannonHP.ForeColor = Color.Green;
                }
                else if (PhantomGannonHP.ForeColor == Color.Green)
                {
                    PhantomGannonHP.Text = "[  ] PHANTOM GANON HP";
                    PhantomGannonHP.ForeColor = Color.Red;
                }
            }
        }

        private void NearBossDoor_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (NearBossDoor.ForeColor == Color.Red)
                {
                    NearBossDoor.Text = "[X] NEAR BOSS DOOR";
                    NearBossDoor.ForeColor = Color.Green;
                }
                else if (NearBossDoor.ForeColor == Color.Green)
                {
                    NearBossDoor.Text = "[  ] NEAR BOSS DOOR";
                    NearBossDoor.ForeColor = Color.Red;
                }
            }
        }

        private void BossKeyArea1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BossKeyArea1.ForeColor == Color.Red)
                {
                    BossKeyArea1.Text = "[X] BOSS KEY AREA 1";
                    BossKeyArea1.ForeColor = Color.Green;
                }
                else if (BossKeyArea1.ForeColor == Color.Green)
                {
                    BossKeyArea1.Text = "[  ] BOSS KEY AREA 1";
                    BossKeyArea1.ForeColor = Color.Red;
                }
            }
        }

        private void BossKeyArea2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BossKeyArea2.ForeColor == Color.Red)
                {
                    BossKeyArea2.Text = "[X] BOSS KEY AREA 2";
                    BossKeyArea2.ForeColor = Color.Green;
                }
                else if (BossKeyArea2.ForeColor == Color.Green)
                {
                    BossKeyArea2.Text = "[  ] BOSS KEY AREA 2";
                    BossKeyArea2.ForeColor = Color.Red;
                }
            }
        }

        private void NorthLavaRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (NorthLavaRoom.ForeColor == Color.Red)
                {
                    NorthLavaRoom.Text = "[X] NORTH LAVA ROOM";
                    NorthLavaRoom.ForeColor = Color.Green;
                }
                else if (NorthLavaRoom.ForeColor == Color.Green)
                {
                    NorthLavaRoom.Text = "[  ] NORTH LAVA ROOM";
                    NorthLavaRoom.ForeColor = Color.Red;
                }
            }
        }

        private void MazeChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeChest.ForeColor == Color.Red)
                {
                    MazeChest.Text = "[X] MAZE CHEST";
                    MazeChest.ForeColor = Color.Green;
                }
                else if (MazeChest.ForeColor == Color.Green)
                {
                    MazeChest.Text = "[  ] MAZE CHEST";
                    MazeChest.ForeColor = Color.Red;
                }
            }
        }

        private void RoomNextToMaze_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RoomNextToMaze.ForeColor == Color.Red)
                {
                    RoomNextToMaze.Text = "[X] ROOM NEXT TO MAZE";
                    RoomNextToMaze.ForeColor = Color.Green;
                }
                else if (RoomNextToMaze.ForeColor == Color.Green)
                {
                    RoomNextToMaze.Text = "[  ] ROOM NEXT TO MAZE";
                    RoomNextToMaze.ForeColor = Color.Red;
                }
            }
        }

        private void TopOfMazeChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TopOfMazeChest.ForeColor == Color.Red)
                {
                    TopOfMazeChest.Text = "[X] TOP OF MAZE CHEST";
                    TopOfMazeChest.ForeColor = Color.Green;
                }
                else if (TopOfMazeChest.ForeColor == Color.Green)
                {
                    TopOfMazeChest.Text = "[  ] TOP OF MAZE CHEST";
                    TopOfMazeChest.ForeColor = Color.Red;
                }
            }
        }

        private void ChestBelowMaze_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChestBelowMaze.ForeColor == Color.Red)
                {
                    ChestBelowMaze.Text = "[X] CHEST BELOW MAZE";
                    ChestBelowMaze.ForeColor = Color.Green;
                }
                else if (ChestBelowMaze.ForeColor == Color.Green)
                {
                    ChestBelowMaze.Text = "[  ] CHEST BELOW MAZE";
                    ChestBelowMaze.ForeColor = Color.Red;
                }
            }
        }

        private void ScarecrowChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ScarecrowChest.ForeColor == Color.Red)
                {
                    ScarecrowChest.Text = "[X] SCARECROW CHEST";
                    ScarecrowChest.ForeColor = Color.Green;
                }
                else if (ScarecrowChest.ForeColor == Color.Green)
                {
                    ScarecrowChest.Text = "[  ] SCARECROW CHEST";
                    ScarecrowChest.ForeColor = Color.Red;
                }
            }
        }

        private void SideOfFirewallChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SideOfFirewallChest.ForeColor == Color.Red)
                {
                    SideOfFirewallChest.Text = "[X] SIDE OF FIREWALL CHEST";
                    SideOfFirewallChest.ForeColor = Color.Green;
                }
                else if (SideOfFirewallChest.ForeColor == Color.Green)
                {
                    SideOfFirewallChest.Text = "[  ] SIDE OF FIREWALL CHEST";
                    SideOfFirewallChest.ForeColor = Color.Red;
                }
            }
        }

        private void FireMazeSide_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FireMazeSide.ForeColor == Color.Red)
                {
                    FireMazeSide.Text = "[X] FIRE MAZE SIDE";
                    FireMazeSide.ForeColor = Color.Green;
                }
                else if (FireMazeSide.ForeColor == Color.Green)
                {
                    FireMazeSide.Text = "[  ] FIRE MAZE SIDE";
                    FireMazeSide.ForeColor = Color.Red;
                }
            }
        }

        private void FireMazeCenter_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FireMazeCenter.ForeColor == Color.Red)
                {
                    FireMazeCenter.Text = "[X] FIRE MAZE CENTER";
                    FireMazeCenter.ForeColor = Color.Green;
                }
                else if (FireMazeCenter.ForeColor == Color.Green)
                {
                    FireMazeCenter.Text = "[  ] FIRE MAZE CENTER";
                    FireMazeCenter.ForeColor = Color.Red;
                }
            }
        }

        private void SouthLavaRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SouthLavaRoom.ForeColor == Color.Red)
                {
                    SouthLavaRoom.Text = "[X] SOUTH LAVA ROOM";
                    SouthLavaRoom.ForeColor = Color.Green;
                }
                else if (SouthLavaRoom.ForeColor == Color.Green)
                {
                    SouthLavaRoom.Text = "[  ] SOUTH LAVA ROOM";
                    SouthLavaRoom.ForeColor = Color.Red;
                }
            }
        }

        private void HammerChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HammerChest.ForeColor == Color.Red)
                {
                    HammerChest.Text = "[X] HAMMER CHEST";
                    HammerChest.ForeColor = Color.Green;
                }
                else if (HammerChest.ForeColor == Color.Green)
                {
                    HammerChest.Text = "[  ] HAMMER CHEST";
                    HammerChest.ForeColor = Color.Red;
                }
            }
        }

        private void VolvagiaHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (VolvagiaHP.ForeColor == Color.Red)
                {
                    VolvagiaHP.Text = "[X] VOLVAGIA HP";
                    VolvagiaHP.ForeColor = Color.Green;
                }
                else if (VolvagiaHP.ForeColor == Color.Green)
                {
                    VolvagiaHP.Text = "[  ] VOLVAGIA HP";
                    VolvagiaHP.ForeColor = Color.Red;
                }
            }
        }

        private void BatRoomChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BatRoomChest.ForeColor == Color.Red)
                {
                    BatRoomChest.Text = "[X] BAT ROOM CHEST";
                    BatRoomChest.ForeColor = Color.Green;
                }
                else if (BatRoomChest.ForeColor == Color.Green)
                {
                    BatRoomChest.Text = "[  ] BAT ROOM CHEST";
                    BatRoomChest.ForeColor = Color.Red;
                }
            }
        }

        private void StalagmiteChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (StalagmiteChest.ForeColor == Color.Red)
                {
                    StalagmiteChest.Text = "[X] STALAGMITE CHEST";
                    StalagmiteChest.ForeColor = Color.Green;
                }
                else if (StalagmiteChest.ForeColor == Color.Green)
                {
                    StalagmiteChest.Text = "[  ] STALAGMITE CHEST";
                    StalagmiteChest.ForeColor = Color.Red;
                }
            }
        }

        private void FrozenHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FrozenHP.ForeColor == Color.Red)
                {
                    FrozenHP.Text = "[X] FROZEN HP";
                    FrozenHP.ForeColor = Color.Green;
                }
                else if (FrozenHP.ForeColor == Color.Green)
                {
                    FrozenHP.Text = "[  ] FROZEN HP";
                    FrozenHP.ForeColor = Color.Red;
                }
            }
        }

        private void WolfChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WolfChest.ForeColor == Color.Red)
                {
                    WolfChest.Text = "[X] WOLF CHEST/SERENADE";
                    WolfChest.ForeColor = Color.Green;
                }
                else if (WolfChest.ForeColor == Color.Green)
                {
                    WolfChest.Text = "[  ] WOLF CHEST/SERENADE";
                    WolfChest.ForeColor = Color.Red;
                }
            }
        }

        private void IcePlatformHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (IcePlatformHP.ForeColor == Color.Red)
                {
                    IcePlatformHP.Text = "[X] ICE PLATFORM HP";
                    IcePlatformHP.ForeColor = Color.Green;
                }
                else if (IcePlatformHP.ForeColor == Color.Green)
                {
                    IcePlatformHP.Text = "[  ] ICE PLATFORM HP";
                    IcePlatformHP.ForeColor = Color.Red;
                }
            }
        }

        private void BottomOfLakeHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BottomOfLakeHP.ForeColor == Color.Red)
                {
                    BottomOfLakeHP.Text = "[X] BOTTOM OF LAKE HP";
                    BottomOfLakeHP.ForeColor = Color.Green;
                }
                else if (BottomOfLakeHP.ForeColor == Color.Green)
                {
                    BottomOfLakeHP.Text = "[  ] BOTTOM OF LAKE HP";
                    BottomOfLakeHP.ForeColor = Color.Red;
                }
            }
        }

        private void GreatFairy_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (GreatFairy.ForeColor == Color.Red)
                {
                    GreatFairy.Text = "[X] GREAT FAIRY";
                    GreatFairy.ForeColor = Color.Green;
                }
                else if (GreatFairy.ForeColor == Color.Green)
                {
                    GreatFairy.Text = "[  ] GREAT FAIRY";
                    GreatFairy.ForeColor = Color.Red;
                }
            }
        }

        private void RutoTopChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RutoTopChest.ForeColor == Color.Red)
                {
                    RutoTopChest.Text = "[X] RUTO TOP CHEST";
                    RutoTopChest.ForeColor = Color.Green;
                }
                else if (RutoTopChest.ForeColor == Color.Green)
                {
                    RutoTopChest.Text = "[  ] RUTO TOP CHEST";
                    RutoTopChest.ForeColor = Color.Red;
                }
            }
        }

        private void WaterBarrierChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WaterBarrierChest.ForeColor == Color.Red)
                {
                    WaterBarrierChest.Text = "[X] WATER BARRIER CHEST";
                    WaterBarrierChest.ForeColor = Color.Green;
                }
                else if (WaterBarrierChest.ForeColor == Color.Green)
                {
                    WaterBarrierChest.Text = "[  ] WATER BARRIER CHEST";
                    WaterBarrierChest.ForeColor = Color.Red;
                }
            }
        }

        private void ChestNearTorches_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChestNearTorches.ForeColor == Color.Red)
                {
                    ChestNearTorches.Text = "[X] TORCHES CHEST";
                    ChestNearTorches.ForeColor = Color.Green;
                }
                else if (ChestNearTorches.ForeColor == Color.Green)
                {
                    ChestNearTorches.Text = "[  ] TORCHES CHEST";
                    ChestNearTorches.ForeColor = Color.Red;
                }
            }
        }

        private void DragonHead_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (DragonHead.ForeColor == Color.Red)
                {
                    DragonHead.Text = "[X] DRAGON HEAD";
                    DragonHead.ForeColor = Color.Green;
                }
                else if (DragonHead.ForeColor == Color.Green)
                {
                    DragonHead.Text = "[  ] DRAGON HEAD";
                    DragonHead.ForeColor = Color.Red;
                }
            }
        }

        private void EyeChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (EyeChest.ForeColor == Color.Red)
                {
                    EyeChest.Text = "[X] EYE TARGET CHEST";
                    EyeChest.ForeColor = Color.Green;
                }
                else if (EyeChest.ForeColor == Color.Green)
                {
                    EyeChest.Text = "[  ] EYE TARGET CHEST";
                    EyeChest.ForeColor = Color.Red;
                }
            }
        }

        private void BelowCenterRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BelowCenterRoom.ForeColor == Color.Red)
                {
                    BelowCenterRoom.Text = "[X] BELOW CENTER ROOM";
                    BelowCenterRoom.ForeColor = Color.Green;
                }
                else if (BelowCenterRoom.ForeColor == Color.Green)
                {
                    BelowCenterRoom.Text = "[  ] BELOW CENTER ROOM";
                    BelowCenterRoom.ForeColor = Color.Red;
                }
            }
        }

        private void CrackedWallChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CrackedWallChest.ForeColor == Color.Red)
                {
                    CrackedWallChest.Text = "[X] CRACKED WALL CHEST";
                    CrackedWallChest.ForeColor = Color.Green;
                }
                else if (CrackedWallChest.ForeColor == Color.Green)
                {
                    CrackedWallChest.Text = "[  ] CRACKED WALL CHEST";
                    CrackedWallChest.ForeColor = Color.Red;
                }
            }
        }

        private void BossKeyChestWater_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BossKeyChestWater.ForeColor == Color.Red)
                {
                    BossKeyChestWater.Text = "[X] BOSS KEY CHEST";
                    BossKeyChestWater.ForeColor = Color.Green;
                }
                else if (BossKeyChestWater.ForeColor == Color.Green)
                {
                    BossKeyChestWater.Text = "[  ] BOSS KEY CHEST";
                    BossKeyChestWater.ForeColor = Color.Red;
                }
            }
        }

        private void LongshotChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LongshotChest.ForeColor == Color.Red)
                {
                    LongshotChest.Text = "[X] LONGSHOT CHEST";
                    LongshotChest.ForeColor = Color.Green;
                }
                else if (LongshotChest.ForeColor == Color.Green)
                {
                    LongshotChest.Text = "[  ] LONGSHOT CHEST";
                    LongshotChest.ForeColor = Color.Red;
                }
            }
        }

        private void RiverChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (RiverChest.ForeColor == Color.Red)
                {
                    RiverChest.Text = "[X] RIVER CHEST";
                    RiverChest.ForeColor = Color.Green;
                }
                else if (RiverChest.ForeColor == Color.Green)
                {
                    RiverChest.Text = "[  ] RIVER CHEST";
                    RiverChest.ForeColor = Color.Red;
                }
            }
        }

        private void MorphaHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MorphaHP.ForeColor == Color.Red)
                {
                    MorphaHP.Text = "[X] MORPHA HP";
                    MorphaHP.ForeColor = Color.Green;
                }
                else if (MorphaHP.ForeColor == Color.Green)
                {
                    MorphaHP.Text = "[  ] MORPHA HP";
                    MorphaHP.ForeColor = Color.Red;
                }
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Maze1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Maze1.ForeColor == Color.Red)
                {
                    Maze1.Text = "[X] MAZE 1";
                    Maze1.ForeColor = Color.Green;
                }
                else if (Maze1.ForeColor == Color.Green)
                {
                    Maze1.Text = "[  ] MAZE 1";
                    Maze1.ForeColor = Color.Red;
                }
            }
        }

        private void Maze2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Maze2.ForeColor == Color.Red)
                {
                    Maze2.Text = "[X] MAZE 2";
                    Maze2.ForeColor = Color.Green;
                }
                else if (Maze2.ForeColor == Color.Green)
                {
                    Maze2.Text = "[  ] MAZE 2";
                    Maze2.ForeColor = Color.Red;
                }
            }
        }

        private void ChestRightOfBeamos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChestRightOfBeamos.ForeColor == Color.Red)
                {
                    ChestRightOfBeamos.Text = "[X] CHEST RIGHT OF BEAMOS";
                    ChestRightOfBeamos.ForeColor = Color.Green;
                }
                else if (ChestRightOfBeamos.ForeColor == Color.Green)
                {
                    ChestRightOfBeamos.Text = "[  ] CHEST RIGHT OF BEAMOS";
                    ChestRightOfBeamos.ForeColor = Color.Red;
                }
            }
        }

        private void SilverRupeesChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SilverRupeesChest.ForeColor == Color.Red)
                {
                    SilverRupeesChest.Text = "[X] SILVER RUPEES CHEST";
                    SilverRupeesChest.ForeColor = Color.Green;
                }
                else if (SilverRupeesChest.ForeColor == Color.Green)
                {
                    SilverRupeesChest.Text = "[  ] SILVER RUPEES CHEST";
                    SilverRupeesChest.ForeColor = Color.Red;
                }
            }
        }

        private void InvisibleBlades1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (InvisibleBlades1.ForeColor == Color.Red)
                {
                    InvisibleBlades1.Text = "[X] INVISIBLE BLADES 1";
                    InvisibleBlades1.ForeColor = Color.Green;
                }
                else if (InvisibleBlades1.ForeColor == Color.Green)
                {
                    InvisibleBlades1.Text = "[  ] INVISIBLE BLADES 1";
                    InvisibleBlades1.ForeColor = Color.Red;
                }
            }
        }

        private void InvisibleBlades2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (InvisibleBlades2.ForeColor == Color.Red)
                {
                    InvisibleBlades2.Text = "[X] INVISIBLE BLADES 2";
                    InvisibleBlades2.ForeColor = Color.Green;
                }
                else if (InvisibleBlades2.ForeColor == Color.Green)
                {
                    InvisibleBlades2.Text = "[  ] INVISIBLE BLADES 2";
                    InvisibleBlades2.ForeColor = Color.Red;
                }
            }
        }

        private void FallingSpikesLower_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FallingSpikesLower.ForeColor == Color.Red)
                {
                    FallingSpikesLower.Text = "[X] FALLING SPIKES LOWER";
                    FallingSpikesLower.ForeColor = Color.Green;
                }
                else if (FallingSpikesLower.ForeColor == Color.Green)
                {
                    FallingSpikesLower.Text = "[  ] FALLING SPIKES LOWER";
                    FallingSpikesLower.ForeColor = Color.Red;
                }
            }
        }

        private void FallingSpikesUpper1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FallingSpikesUpper1.ForeColor == Color.Red)
                {
                    FallingSpikesUpper1.Text = "[X] FALLING SPIKES UPPER 1";
                    FallingSpikesUpper1.ForeColor = Color.Green;
                }
                else if (FallingSpikesUpper1.ForeColor == Color.Green)
                {
                    FallingSpikesUpper1.Text = "[  ] FALLING SPIKES UPPER 1";
                    FallingSpikesUpper1.ForeColor = Color.Red;
                }
            }
        }

        private void FallingSpikesUpper2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FallingSpikesUpper2.ForeColor == Color.Red)
                {
                    FallingSpikesUpper2.Text = "[X] FALLING SPIKES UPPER 2";
                    FallingSpikesUpper2.ForeColor = Color.Green;
                }
                else if (FallingSpikesUpper2.ForeColor == Color.Green)
                {
                    FallingSpikesUpper2.Text = "[  ] FALLING SPIKES UPPER 2";
                    FallingSpikesUpper2.ForeColor = Color.Red;
                }
            }
        }

        private void SkullPot_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SkullPot.ForeColor == Color.Red)
                {
                    SkullPot.Text = "[X] SKULL POT";
                    SkullPot.ForeColor = Color.Green;
                }
                else if (SkullPot.ForeColor == Color.Green)
                {
                    SkullPot.Text = "[  ] SKULL POT";
                    SkullPot.ForeColor = Color.Red;
                }
            }
        }

        private void HiddenSpikesRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HiddenSpikesRoom.ForeColor == Color.Red)
                {
                    HiddenSpikesRoom.Text = "[X] HIDDEN SPIKES ROOM";
                    HiddenSpikesRoom.ForeColor = Color.Green;
                }
                else if (HiddenSpikesRoom.ForeColor == Color.Green)
                {
                    HiddenSpikesRoom.Text = "[  ] HIDDEN SPIKES ROOM";
                    HiddenSpikesRoom.ForeColor = Color.Red;
                }
            }
        }

        private void BehindFan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BehindFan.ForeColor == Color.Red)
                {
                    BehindFan.Text = "[X] BEHIND FAN HIDDEN";
                    BehindFan.ForeColor = Color.Green;
                }
                else if (BehindFan.ForeColor == Color.Green)
                {
                    BehindFan.Text = "[  ] BEHIND FAN HIDDEN";
                    BehindFan.ForeColor = Color.Red;
                }
            }
        }

        private void AfterFan1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (AfterFan1.ForeColor == Color.Red)
                {
                    AfterFan1.Text = "[X] AFTER FAN 1";
                    AfterFan1.ForeColor = Color.Green;
                }
                else if (AfterFan1.ForeColor == Color.Green)
                {
                    AfterFan1.Text = "[  ] AFTER FAN 1";
                    AfterFan1.ForeColor = Color.Red;
                }
            }
        }

        private void AfterFan2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (AfterFan2.ForeColor == Color.Red)
                {
                    AfterFan2.Text = "[X] AFTER FAN 2";
                    AfterFan2.ForeColor = Color.Green;
                }
                else if (AfterFan2.ForeColor == Color.Green)
                {
                    AfterFan2.Text = "[  ] AFTER FAN 2";
                    AfterFan2.ForeColor = Color.Red;
                }
            }
        }

        private void WoodCross_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WoodCross.ForeColor == Color.Red)
                {
                    WoodCross.Text = "[X] WOOD CROSS";
                    WoodCross.ForeColor = Color.Green;
                }
                else if (WoodCross.ForeColor == Color.Green)
                {
                    WoodCross.Text = "[  ] WOOD CROSS";
                    WoodCross.ForeColor = Color.Red;
                }
            }
        }

        private void BossKeyRoom1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BossKeyRoom1.ForeColor == Color.Red)
                {
                    BossKeyRoom1.Text = "[X] BOSS KEY ROOM 1";
                    BossKeyRoom1.ForeColor = Color.Green;
                }
                else if (BossKeyRoom1.ForeColor == Color.Green)
                {
                    BossKeyRoom1.Text = "[  ] BOSS KEY ROOM 1";
                    BossKeyRoom1.ForeColor = Color.Red;
                }
            }
        }

        private void BossKeyRoom3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BossKeyRoom2.ForeColor == Color.Red)
                {
                    BossKeyRoom2.Text = "[X] BOSS KEY ROOM 2";
                    BossKeyRoom2.ForeColor = Color.Green;
                }
                else if (BossKeyRoom2.ForeColor == Color.Green)
                {
                    BossKeyRoom2.Text = "[  ] BOSS KEY ROOM 2";
                    BossKeyRoom2.ForeColor = Color.Red;
                }
            }
        }

        private void BongoBongoHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BongoBongoHP.ForeColor == Color.Red)
                {
                    BongoBongoHP.Text = "[X] BONGO BONGO HP";
                    BongoBongoHP.ForeColor = Color.Green;
                }
                else if (BongoBongoHP.ForeColor == Color.Green)
                {
                    BongoBongoHP.Text = "[  ] BONGO BONGO HP";
                    BongoBongoHP.ForeColor = Color.Red;
                }
            }
        }

        private void ChildSwitch_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChildSwitch.ForeColor == Color.Red)
                {
                    ChildSwitch.Text = "[X] CHILD SWITCH";
                    ChildSwitch.ForeColor = Color.Green;
                }
                else if (ChildSwitch.ForeColor == Color.Green)
                {
                    ChildSwitch.Text = "[  ] CHILD SWITCH";
                    ChildSwitch.ForeColor = Color.Red;
                }
            }
        }

        private void ChildTorches_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChildTorches.ForeColor == Color.Red)
                {
                    ChildTorches.Text = "[X] CHILD TORCHES";
                    ChildTorches.ForeColor = Color.Green;
                }
                else if (ChildTorches.ForeColor == Color.Green)
                {
                    ChildTorches.Text = "[  ] CHILD TORCHES";
                    ChildTorches.ForeColor = Color.Red;
                }
            }
        }

        private void ChildClimb1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChildClimb1.ForeColor == Color.Red)
                {
                    ChildClimb1.Text = "[X] CHILD CLIMB 1";
                    ChildClimb1.ForeColor = Color.Green;
                }
                else if (ChildClimb1.ForeColor == Color.Green)
                {
                    ChildClimb1.Text = "[  ] CHILD CLIMB 1";
                    ChildClimb1.ForeColor = Color.Red;
                }
            }
        }

        private void ChildClimb2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ChildClimb2.ForeColor == Color.Red)
                {
                    ChildClimb2.Text = "[X] CHILD CLIMB 2";
                    ChildClimb2.ForeColor = Color.Green;
                }
                else if (ChildClimb2.ForeColor == Color.Green)
                {
                    ChildClimb2.Text = "[  ] CHILD CLIMB 2";
                    ChildClimb2.ForeColor = Color.Red;
                }
            }
        }

        private void StatueBase_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (StatueBase.ForeColor == Color.Red)
                {
                    StatueBase.Text = "[X] STATUE BASE";
                    StatueBase.ForeColor = Color.Green;
                }
                else if (StatueBase.ForeColor == Color.Green)
                {
                    StatueBase.Text = "[  ] STATUE BASE";
                    StatueBase.ForeColor = Color.Red;
                }
            }
        }

        private void StatueHand_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (StatueHand.ForeColor == Color.Red)
                {
                    StatueHand.Text = "[X] STATUE HAND";
                    StatueHand.ForeColor = Color.Green;
                }
                else if (StatueHand.ForeColor == Color.Green)
                {
                    StatueHand.Text = "[  ] STATUE HAND";
                    StatueHand.ForeColor = Color.Red;
                }
            }
        }

        private void ByHammerSwitch_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ByHammerSwitch.ForeColor == Color.Red)
                {
                    ByHammerSwitch.Text = "[X] BY HAMMER SWITCH";
                    ByHammerSwitch.ForeColor = Color.Green;
                }
                else if (ByHammerSwitch.ForeColor == Color.Green)
                {
                    ByHammerSwitch.Text = "[  ] BY HAMMER SWITCH";
                    ByHammerSwitch.ForeColor = Color.Red;
                }
            }
        }

        private void LullabyChestAdult_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LullabyChestAdult.ForeColor == Color.Red)
                {
                    LullabyChestAdult.Text = "[X] LULLABY CHEST";
                    LullabyChestAdult.ForeColor = Color.Green;
                }
                else if (LullabyChestAdult.ForeColor == Color.Green)
                {
                    LullabyChestAdult.Text = "[  ] LULLABY CHEST";
                    LullabyChestAdult.ForeColor = Color.Red;
                }
            }
        }

        private void SilverRupeeChest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SilverRupeeChest.ForeColor == Color.Red)
                {
                    SilverRupeeChest.Text = "[X] SILVER RUPEE CHEST";
                    SilverRupeeChest.ForeColor = Color.Green;
                }
                else if (SilverRupeeChest.ForeColor == Color.Green)
                {
                    SilverRupeeChest.Text = "[  ] SILVER RUPEE CHEST";
                    SilverRupeeChest.ForeColor = Color.Red;
                }
            }
        }

        private void WallSuns1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WallSuns1.ForeColor == Color.Red)
                {
                    WallSuns1.Text = "[X] WALL SUNS 1";
                    WallSuns1.ForeColor = Color.Green;
                }
                else if (WallSuns1.ForeColor == Color.Green)
                {
                    WallSuns1.Text = "[  ] WALL SUNS 1";
                    WallSuns1.ForeColor = Color.Red;
                }
            }
        }

        private void WallSuns2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WallSuns2.ForeColor == Color.Red)
                {
                    WallSuns2.Text = "[X] WALL SUNS 2";
                    WallSuns2.ForeColor = Color.Green;
                }
                else if (WallSuns2.ForeColor == Color.Green)
                {
                    WallSuns2.Text = "[  ] WALL SUNS 2";
                    WallSuns2.ForeColor = Color.Red;
                }
            }
        }

        private void SunBlockRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SunBlockRoom.ForeColor == Color.Red)
                {
                    SunBlockRoom.Text = "[X] SUN BLOCK ROOM";
                    SunBlockRoom.ForeColor = Color.Green;
                }
                else if (SunBlockRoom.ForeColor == Color.Green)
                {
                    SunBlockRoom.Text = "[  ] SUN BLOCK ROOM";
                    SunBlockRoom.ForeColor = Color.Red;
                }
            }
        }

        private void WallSunArmosRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WallSunArmosRoom.ForeColor == Color.Red)
                {
                    WallSunArmosRoom.Text = "[X] WALL SUN ARMOS ROOM";
                    WallSunArmosRoom.ForeColor = Color.Green;
                }
                else if (WallSunArmosRoom.ForeColor == Color.Green)
                {
                    WallSunArmosRoom.Text = "[  ] WALL SUN ARMOS ROOM";
                    WallSunArmosRoom.ForeColor = Color.Red;
                }
            }
        }

        private void TwinrovaHP_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (TwinrovaHP.ForeColor == Color.Red)
                {
                    TwinrovaHP.Text = "[X] TWINROVA HP";
                    TwinrovaHP.ForeColor = Color.Green;
                }
                else if (TwinrovaHP.ForeColor == Color.Green)
                {
                    TwinrovaHP.Text = "[  ] TWINROVA HP";
                    TwinrovaHP.ForeColor = Color.Red;
                }
            }
        }

        private void HiddenChest1Adult_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HiddenChest1Adult.ForeColor == Color.Red)
                {
                    HiddenChest1Adult.Text = "[X] HIDDEN CHEST 1";
                    HiddenChest1Adult.ForeColor = Color.Green;
                }
                else if (HiddenChest1Adult.ForeColor == Color.Green)
                {
                    HiddenChest1Adult.Text = "[  ] HIDDEN CHEST 1";
                    HiddenChest1Adult.ForeColor = Color.Red;
                }
            }
        }

        private void HiddenChest2Adult_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HiddenChest2Adult.ForeColor == Color.Red)
                {
                    HiddenChest2Adult.Text = "[X] HIDDEN CHEST 2";
                    HiddenChest2Adult.ForeColor = Color.Green;
                }
                else if (HiddenChest2Adult.ForeColor == Color.Green)
                {
                    HiddenChest2Adult.Text = "[  ] HIDDEN CHEST 2";
                    HiddenChest2Adult.ForeColor = Color.Red;
                }
            }
        }

        private void BossKeyChestDesert_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BossKeyChestDesert.ForeColor == Color.Red)
                {
                    BossKeyChestDesert.Text = "[X] BOSS KEY CHEST";
                    BossKeyChestDesert.ForeColor = Color.Green;
                }
                else if (BossKeyChestDesert.ForeColor == Color.Green)
                {
                    BossKeyChestDesert.Text = "[  ] BOSS KEY CHEST";
                    BossKeyChestDesert.ForeColor = Color.Red;
                }
            }
        }

        private void WallSunTop_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WallSunTop.ForeColor == Color.Red)
                {
                    WallSunTop.Text = "[X] WALL SUN TOP";
                    WallSunTop.ForeColor = Color.Green;
                }
                else if (WallSunTop.ForeColor == Color.Green)
                {
                    WallSunTop.Text = "[  ] WALL SUN TOP";
                    WallSunTop.ForeColor = Color.Red;
                }
            }
        }

        private void Lobby1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Lobby1.ForeColor == Color.Red)
                {
                    Lobby1.Text = "[X] LOBBY 1";
                    Lobby1.ForeColor = Color.Green;
                }
                else if (Lobby1.ForeColor == Color.Green)
                {
                    Lobby1.Text = "[  ] LOBBY 1";
                    Lobby1.ForeColor = Color.Red;
                }
            }
        }

        private void Lobby2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Lobby2.ForeColor == Color.Red)
                {
                    Lobby2.Text = "[X] LOBBY 2";
                    Lobby2.ForeColor = Color.Green;
                }
                else if (Lobby2.ForeColor == Color.Green)
                {
                    Lobby2.Text = "[  ] LOBBY 2";
                    Lobby2.ForeColor = Color.Red;
                }
            }
        }

        private void Stalfos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Stalfos.ForeColor == Color.Red)
                {
                    Stalfos.Text = "[X] STALFOS";
                    Stalfos.ForeColor = Color.Green;
                }
                else if (Stalfos.ForeColor == Color.Green)
                {
                    Stalfos.Text = "[  ] STALFOS";
                    Stalfos.ForeColor = Color.Red;
                }
            }
        }

        private void Beamos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Beamos.ForeColor == Color.Red)
                {
                    Beamos.Text = "[X] BEAMOS";
                    Beamos.ForeColor = Color.Green;
                }
                else if (Beamos.ForeColor == Color.Green)
                {
                    Beamos.Text = "[  ] BEAMOS";
                    Beamos.ForeColor = Color.Red;
                }
            }
        }

        private void MazeGG1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeGG1.ForeColor == Color.Red)
                {
                    MazeGG1.Text = "[X] MAZE 1";
                    MazeGG1.ForeColor = Color.Green;
                }
                else if (MazeGG1.ForeColor == Color.Green)
                {
                    MazeGG1.Text = "[  ] MAZE 1";
                    MazeGG1.ForeColor = Color.Red;
                }
            }
        }

        private void MazeGG2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeGG2.ForeColor == Color.Red)
                {
                    MazeGG2.Text = "[X] MAZE 2";
                    MazeGG2.ForeColor = Color.Green;
                }
                else if (MazeGG2.ForeColor == Color.Green)
                {
                    MazeGG2.Text = "[  ] MAZE 2";
                    MazeGG2.ForeColor = Color.Red;
                }
            }
        }

        private void MazeGG3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeGG3.ForeColor == Color.Red)
                {
                    MazeGG3.Text = "[X] MAZE 3";
                    MazeGG3.ForeColor = Color.Green;
                }
                else if (MazeGG3.ForeColor == Color.Green)
                {
                    MazeGG3.Text = "[  ] MAZE 3";
                    MazeGG3.ForeColor = Color.Red;
                }
            }
        }

        private void MazeLedge1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeLedge1.ForeColor == Color.Red)
                {
                    MazeLedge1.Text = "[X] MAZE LEDGE 1";
                    MazeLedge1.ForeColor = Color.Green;
                }
                else if (MazeLedge1.ForeColor == Color.Green)
                {
                    MazeLedge1.Text = "[  ] MAZE LEDGE 1";
                    MazeLedge1.ForeColor = Color.Red;
                }
            }
        }

        private void MazeFinal_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeFinal.ForeColor == Color.Red)
                {
                    MazeFinal.Text = "[X] MAZE CENTER";
                    MazeFinal.ForeColor = Color.Green;
                }
                else if (MazeFinal.ForeColor == Color.Green)
                {
                    MazeFinal.Text = "[  ] MAZE CENTER";
                    MazeFinal.ForeColor = Color.Red;
                }
            }
        }

        private void MazeHiddenTop_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeHiddenTop.ForeColor == Color.Red)
                {
                    MazeHiddenTop.Text = "[X] MAZE HIDDEN TOP";
                    MazeHiddenTop.ForeColor = Color.Green;
                }
                else if (MazeHiddenTop.ForeColor == Color.Green)
                {
                    MazeHiddenTop.Text = "[  ] MAZE HIDDEN TOP";
                    MazeHiddenTop.ForeColor = Color.Red;
                }
            }
        }

        private void MazeLedge2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (MazeLedge2.ForeColor == Color.Red)
                {
                    MazeLedge2.Text = "[X] MAZE LEDGE 2";
                    MazeLedge2.ForeColor = Color.Green;
                }
                else if (MazeLedge2.ForeColor == Color.Green)
                {
                    MazeLedge2.Text = "[  ] MAZE LEDGE 2";
                    MazeLedge2.ForeColor = Color.Red;
                }
            }
        }

        private void WaterRupees_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (WaterRupees.ForeColor == Color.Red)
                {
                    WaterRupees.Text = "[X] WATER RUPEES";
                    WaterRupees.ForeColor = Color.Green;
                }
                else if (WaterRupees.ForeColor == Color.Green)
                {
                    WaterRupees.Text = "[  ] WATER RUPEES";
                    WaterRupees.ForeColor = Color.Red;
                }
            }
        }

        private void HammerRoomSwitch_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HammerRoomSwitch.ForeColor == Color.Red)
                {
                    HammerRoomSwitch.Text = "[X] HAMMER ROOM SWITCH";
                    HammerRoomSwitch.ForeColor = Color.Green;
                }
                else if (HammerRoomSwitch.ForeColor == Color.Green)
                {
                    HammerRoomSwitch.Text = "[  ] HAMMER ROOM SWITCH";
                    HammerRoomSwitch.ForeColor = Color.Red;
                }
            }
        }

        private void HammerRoomEnemies_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (HammerRoomEnemies.ForeColor == Color.Red)
                {
                    HammerRoomEnemies.Text = "[X] HAMMER ROOM ENEMIES";
                    HammerRoomEnemies.ForeColor = Color.Green;
                }
                else if (HammerRoomEnemies.ForeColor == Color.Green)
                {
                    HammerRoomEnemies.Text = "[  ] HAMMER ROOM ENEMIES";
                    HammerRoomEnemies.ForeColor = Color.Red;
                }
            }
        }

        private void EyeStatue_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (EyeStatue.ForeColor == Color.Red)
                {
                    EyeStatue.Text = "[X] EYE STATUE";
                    EyeStatue.ForeColor = Color.Green;
                }
                else if (EyeStatue.ForeColor == Color.Green)
                {
                    EyeStatue.Text = "[  ] EYE STATUE";
                    EyeStatue.ForeColor = Color.Red;
                }
            }
        }

        private void ByScareCrow_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ByScareCrow.ForeColor == Color.Red)
                {
                    ByScareCrow.Text = "[X] BY SCARECROW";
                    ByScareCrow.ForeColor = Color.Green;
                }
                else if (ByScareCrow.ForeColor == Color.Green)
                {
                    ByScareCrow.Text = "[  ] BY SCARECROW";
                    ByScareCrow.ForeColor = Color.Red;
                }
            }
        }

        private void ByHeavyBlock_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ByHeavyBlock.ForeColor == Color.Red)
                {
                    ByHeavyBlock.Text = "[X] BY HEAVY BLOCK";
                    ByHeavyBlock.ForeColor = Color.Green;
                }
                else if (ByHeavyBlock.ForeColor == Color.Green)
                {
                    ByHeavyBlock.Text = "[  ] BY HEAVY BLOCK";
                    ByHeavyBlock.ForeColor = Color.Red;
                }
            }
        }

        private void LikeLike1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LikeLike1.ForeColor == Color.Red)
                {
                    LikeLike1.Text = "[X] LIKE LIKE 1";
                    LikeLike1.ForeColor = Color.Green;
                }
                else if (LikeLike1.ForeColor == Color.Green)
                {
                    LikeLike1.Text = "[  ] LIKE LIKE 1";
                    LikeLike1.ForeColor = Color.Red;
                }
            }
        }

        private void LikeLike2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LikeLike2.ForeColor == Color.Red)
                {
                    LikeLike2.Text = "[X] LIKE LIKE 2";
                    LikeLike2.ForeColor = Color.Green;
                }
                else if (LikeLike2.ForeColor == Color.Green)
                {
                    LikeLike2.Text = "[  ] LIKE LIKE 2";
                    LikeLike2.ForeColor = Color.Red;
                }
            }
        }

        private void LikeLike3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LikeLike3.ForeColor == Color.Red)
                {
                    LikeLike3.Text = "[X] LIKE LIKE 3";
                    LikeLike3.ForeColor = Color.Green;
                }
                else if (LikeLike3.ForeColor == Color.Green)
                {
                    LikeLike3.Text = "[  ] LIKE LIKE 3";
                    LikeLike3.ForeColor = Color.Red;
                }
            }
        }

        private void Scrubs4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Scrubs4.ForeColor == Color.Red)
                {
                    Scrubs4.Text = "[X] SCRUBS";
                    Scrubs4.ForeColor = Color.Green;
                }
                else if (Scrubs4.ForeColor == Color.Green)
                {
                    Scrubs4.Text = "[  ] SCRUBS";
                    Scrubs4.ForeColor = Color.Red;
                }
            }
        }

        private void Shadow1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Shadow1.ForeColor == Color.Red)
                {
                    Shadow1.Text = "[X] SHADOW 1";
                    Shadow1.ForeColor = Color.Green;
                }
                else if (Shadow1.ForeColor == Color.Green)
                {
                    Shadow1.Text = "[  ] SHADOW 1";
                    Shadow1.ForeColor = Color.Red;
                }
            }
        }

        private void Shadow2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Shadow2.ForeColor == Color.Red)
                {
                    Shadow2.Text = "[X] SHADOW 2";
                    Shadow2.ForeColor = Color.Green;
                }
                else if (Shadow2.ForeColor == Color.Green)
                {
                    Shadow2.Text = "[  ] SHADOW 2";
                    Shadow2.ForeColor = Color.Red;
                }
            }
        }

        private void Forest_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Forest.ForeColor == Color.Red)
                {
                    Forest.Text = "[X] FOREST";
                    Forest.ForeColor = Color.Green;
                }
                else if (Forest.ForeColor == Color.Green)
                {
                    Forest.Text = "[  ] FOREST";
                    Forest.ForeColor = Color.Red;
                }
            }
        }

        private void Water1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Water1.ForeColor == Color.Red)
                {
                    Water1.Text = "[X] WATER 1";
                    Water1.ForeColor = Color.Green;
                }
                else if (Water1.ForeColor == Color.Green)
                {
                    Water1.Text = "[  ] WATER 1";
                    Water1.ForeColor = Color.Red;
                }
            }
        }

        private void Water2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Water2.ForeColor == Color.Red)
                {
                    Water2.Text = "[X] WATER 2";
                    Water2.ForeColor = Color.Green;
                }
                else if (Water2.ForeColor == Color.Green)
                {
                    Water2.Text = "[  ] WATER 2";
                    Water2.ForeColor = Color.Red;
                }
            }
        }

        private void Spirit1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Spirit1.ForeColor == Color.Red)
                {
                    Spirit1.Text = "[X] SPIRIT 1";
                    Spirit1.ForeColor = Color.Green;
                }
                else if (Spirit1.ForeColor == Color.Green)
                {
                    Spirit1.Text = "[  ] SPIRIT 1";
                    Spirit1.ForeColor = Color.Red;
                }
            }
        }

        private void Spirit2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Spirit2.ForeColor == Color.Red)
                {
                    Spirit2.Text = "[X] SPIRIT 2";
                    Spirit2.ForeColor = Color.Green;
                }
                else if (Spirit2.ForeColor == Color.Green)
                {
                    Spirit2.Text = "[  ] SPIRIT 2";
                    Spirit2.ForeColor = Color.Red;
                }
            }
        }

        private void Light7ChestRoom_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Light7ChestRoom.ForeColor == Color.Red)
                {
                    Light7ChestRoom.Text = "[X] LIGHT 7 CHEST ROOM";
                    Light7ChestRoom.ForeColor = Color.Green;
                }
                else if (Light7ChestRoom.ForeColor == Color.Green)
                {
                    Light7ChestRoom.Text = "[  ] LIGHT 7 CHEST ROOM";
                    Light7ChestRoom.ForeColor = Color.Red;
                }
            }
        }

        private void LightLullaby_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (LightLullaby.ForeColor == Color.Red)
                {
                    LightLullaby.Text = "[X] LIGHT LULLABY";
                    LightLullaby.ForeColor = Color.Green;
                }
                else if (LightLullaby.ForeColor == Color.Green)
                {
                    LightLullaby.Text = "[  ] LIGHT LULLABY";
                    LightLullaby.ForeColor = Color.Red;
                }
            }
        }

        private void BossKeyGanon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (BossKeyGanon.ForeColor == Color.Red)
                {
                    BossKeyGanon.Text = "[X] BOSS KEY CHEST";
                    BossKeyGanon.ForeColor = Color.Green;
                }
                else if (BossKeyGanon.ForeColor == Color.Green)
                {
                    BossKeyGanon.Text = "[  ] BOSS KEY CHEST";
                    BossKeyGanon.ForeColor = Color.Red;
                }
            }
        }

        private void ScrubsBehindOctorok_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (ScrubsBehindOctorok.ForeColor == Color.Red)
                {
                    ScrubsBehindOctorok.Text = "[X] SCRUB BEHIND OCTOROK";
                    ScrubsBehindOctorok.ForeColor = Color.Green;
                }
                else if (ScrubsBehindOctorok.ForeColor == Color.Green)
                {
                    ScrubsBehindOctorok.Text = "[  ] SCRUB BEHIND OCTOROK";
                    ScrubsBehindOctorok.ForeColor = Color.Red;
                }
            }
        }

        private void SOSScrub_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SOSScrub.ForeColor == Color.Red)
                {
                    SOSScrub.Text = "[X] SOS SCRUB";
                    SOSScrub.ForeColor = Color.Green;
                }
                else if (SOSScrub.ForeColor == Color.Green)
                {
                    SOSScrub.Text = "[  ] SOS SCRUB";
                    SOSScrub.ForeColor = Color.Red;
                }
            }
        }

        private void CraterScrub_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CraterScrub.ForeColor == Color.Red)
                {
                    CraterScrub.Text = "[X] CRATER HAMMER ROCK SCRUB";
                    CraterScrub.ForeColor = Color.Green;
                }
                else if (CraterScrub.ForeColor == Color.Green)
                {
                    CraterScrub.Text = "[  ] CRATER HAMMER ROCK SCRUB";
                    CraterScrub.ForeColor = Color.Red;
                }
            }
        }

        private void CraterChildScrub_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (CraterChildScrub.ForeColor == Color.Red)
                {
                    CraterChildScrub.Text = "[X] CRATER CHILD SCRUB";
                    CraterChildScrub.ForeColor = Color.Green;
                }
                else if (CraterChildScrub.ForeColor == Color.Green)
                {
                    CraterChildScrub.Text = "[  ] CRATER CHILD SCRUB";
                    CraterChildScrub.ForeColor = Color.Red;
                }
            }
        }

        private void SOSScrubG_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (SOSScrubG.ForeColor == Color.Red)
                {
                    SOSScrubG.Text = "[X] SOS SCRUB";
                    SOSScrubG.ForeColor = Color.Green;
                }
                else if (SOSScrubG.ForeColor == Color.Green)
                {
                    SOSScrubG.Text = "[  ] SOS SCRUB";
                    SOSScrubG.ForeColor = Color.Red;
                }
            }
        }

        private void KokiriSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //0
            if(e.Button == MouseButtons.Left)
            {
                if(skulltulaActual[0] == skulltulasMax[0])
                {
                    skulltulaActual[0] = 0;
                }
                else if(skulltulaActual[0] < skulltulasMax[0])
                {
                    skulltulaActual[0]++;
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[0] == 0)
                {
                    skulltulaActual[0] = skulltulasMax[0];
                }
                else if (skulltulaActual[0] > 0)
                {
                    skulltulaActual[0]--;
                }
            }

            KokiriSkulltula.Text = "SKULLTULAS - " + skulltulaActual[0] + "/" + skulltulasMax[0];
            if(skulltulaActual[0] == skulltulasMax[0])
            {
                KokiriSkulltula.ForeColor = Color.Green;
            }
            else
            {
                KokiriSkulltula.ForeColor = Color.Red;
            }
        }

        private void LostWoodsSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //1
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[1] == skulltulasMax[1])
                {
                    skulltulaActual[1] = 0;
                }
                else if (skulltulaActual[1] < skulltulasMax[1])
                {
                    skulltulaActual[1]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[1] == 0)
                {
                    skulltulaActual[1] = skulltulasMax[1];
                }
                else if (skulltulaActual[1] > 0)
                {
                    skulltulaActual[1]--;
                }
            }

            LostWoodsSkulltula.Text = "SKULLTULAS - " + skulltulaActual[1] + "/" + skulltulasMax[1];
            if (skulltulaActual[1] == skulltulasMax[1])
            {
                LostWoodsSkulltula.ForeColor = Color.Green;
            }
            else
            {
                LostWoodsSkulltula.ForeColor = Color.Red;
            }
        }

        private void KakarikoSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //2
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[2] == skulltulasMax[2])
                {
                    skulltulaActual[2] = 0;
                }
                else if (skulltulaActual[2] < skulltulasMax[2])
                {
                    skulltulaActual[2]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[2] == 0)
                {
                    skulltulaActual[2] = skulltulasMax[2];
                }
                else if (skulltulaActual[2] > 0)
                {
                    skulltulaActual[2]--;
                }
            }

            KakarikoSkulltula.Text = "SKULLTULAS - " + skulltulaActual[2] + "/" + skulltulasMax[2];
            if (skulltulaActual[2] == skulltulasMax[2])
            {
                KakarikoSkulltula.ForeColor = Color.Green;
            }
            else
            {
                KakarikoSkulltula.ForeColor = Color.Red;
            }
        }

        private void CastleSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //3
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[3] == skulltulasMax[3])
                {
                    skulltulaActual[3] = 0;
                }
                else if (skulltulaActual[3] < skulltulasMax[3])
                {
                    skulltulaActual[3]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[3] == 0)
                {
                    skulltulaActual[3] = skulltulasMax[3];
                }
                else if (skulltulaActual[3] > 0)
                {
                    skulltulaActual[3]--;
                }
            }

            CastleSkulltula.Text = "SKULLTULAS - " + skulltulaActual[3] + "/" + skulltulasMax[3];
            if (skulltulaActual[3] == skulltulasMax[3])
            {
                CastleSkulltula.ForeColor = Color.Green;
            }
            else
            {
                CastleSkulltula.ForeColor = Color.Red;
            }
        }

        private void MarketSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //4
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[4] == skulltulasMax[4])
                {
                    skulltulaActual[4] = 0;
                }
                else if (skulltulaActual[4] < skulltulasMax[4])
                {
                    skulltulaActual[4]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[4] == 0)
                {
                    skulltulaActual[4] = skulltulasMax[4];
                }
                else if (skulltulaActual[4] > 0)
                {
                    skulltulaActual[4]--;
                }
            }

            MarketSkulltula.Text = "SKULLTULAS - " + skulltulaActual[4] + "/" + skulltulasMax[4];
            if (skulltulaActual[4] == skulltulasMax[4])
            {
                MarketSkulltula.ForeColor = Color.Green;
            }
            else
            {
                MarketSkulltula.ForeColor = Color.Red;
            }
        }

        private void FieldSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //5
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[5] == skulltulasMax[5])
                {
                    skulltulaActual[5] = 0;
                }
                else if (skulltulaActual[5] < skulltulasMax[5])
                {
                    skulltulaActual[5]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[5] == 0)
                {
                    skulltulaActual[5] = skulltulasMax[5];
                }
                else if (skulltulaActual[5] > 0)
                {
                    skulltulaActual[5]--;
                }
            }

            FieldSkulltula.Text = "SKULLTULAS - " + skulltulaActual[5] + "/" + skulltulasMax[5];
            if (skulltulaActual[5] == skulltulasMax[5])
            {
                FieldSkulltula.ForeColor = Color.Green;
            }
            else
            {
                FieldSkulltula.ForeColor = Color.Red;
            }
        }

        private void LakeSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //6
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[6] == skulltulasMax[6])
                {
                    skulltulaActual[6] = 0;
                }
                else if (skulltulaActual[6] < skulltulasMax[6])
                {
                    skulltulaActual[6]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[6] == 0)
                {
                    skulltulaActual[6] = skulltulasMax[6];
                }
                else if (skulltulaActual[6] > 0)
                {
                    skulltulaActual[6]--;
                }
            }

            LakeSkulltula.Text = "SKULLTULAS - " + skulltulaActual[6] + "/" + skulltulasMax[6];
            if (skulltulaActual[6] == skulltulasMax[6])
            {
                LakeSkulltula.ForeColor = Color.Green;
            }
            else
            {
                LakeSkulltula.ForeColor = Color.Red;
            }
        }

        private void RiverSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //7
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[7] == skulltulasMax[7])
                {
                    skulltulaActual[7] = 0;
                }
                else if (skulltulaActual[7] < skulltulasMax[7])
                {
                    skulltulaActual[7]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[7] == 0)
                {
                    skulltulaActual[7] = skulltulasMax[7];
                }
                else if (skulltulaActual[7] > 0)
                {
                    skulltulaActual[7]--;
                }
            }

            RiverSkulltula.Text = "SKULLTULAS - " + skulltulaActual[7] + "/" + skulltulasMax[7];
            if (skulltulaActual[7] == skulltulasMax[7])
            {
                RiverSkulltula.ForeColor = Color.Green;
            }
            else
            {
                RiverSkulltula.ForeColor = Color.Red;
            }
        }

        private void DomainSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //8
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[8] == skulltulasMax[8])
                {
                    skulltulaActual[8] = 0;
                }
                else if (skulltulaActual[8] < skulltulasMax[8])
                {
                    skulltulaActual[8]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[8] == 0)
                {
                    skulltulaActual[8] = skulltulasMax[8];
                }
                else if (skulltulaActual[8] > 0)
                {
                    skulltulaActual[8]--;
                }
            }

            DomainSkulltula.Text = "SKULLTULAS - " + skulltulaActual[8] + "/" + skulltulasMax[8];
            if (skulltulaActual[8] == skulltulasMax[8])
            {
                DomainSkulltula.ForeColor = Color.Green;
            }
            else
            {
                DomainSkulltula.ForeColor = Color.Red;
            }
        }

        private void DMSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //9
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[9] == skulltulasMax[9])
                {
                    skulltulaActual[9] = 0;
                }
                else if (skulltulaActual[9] < skulltulasMax[9])
                {
                    skulltulaActual[9]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[9] == 0)
                {
                    skulltulaActual[9] = skulltulasMax[9];
                }
                else if (skulltulaActual[9] > 0)
                {
                    skulltulaActual[9]--;
                }
            }

            DMSkulltula.Text = "SKULLTULAS - " + skulltulaActual[9] + "/" + skulltulasMax[9];
            if (skulltulaActual[9] == skulltulasMax[9])
            {
                DMSkulltula.ForeColor = Color.Green;
            }
            else
            {
                DMSkulltula.ForeColor = Color.Red;
            }
        }

        private void GCSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //10
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[10] == skulltulasMax[10])
                {
                    skulltulaActual[10] = 0;
                }
                else if (skulltulaActual[10] < skulltulasMax[10])
                {
                    skulltulaActual[10]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[10] == 0)
                {
                    skulltulaActual[10] = skulltulasMax[10];
                }
                else if (skulltulaActual[10] > 0)
                {
                    skulltulaActual[10]--;
                }
            }

            GCSkulltula.Text = "SKULLTULAS - " + skulltulaActual[10] + "/" + skulltulasMax[10];
            if (skulltulaActual[10] == skulltulasMax[10])
            {
                GCSkulltula.ForeColor = Color.Green;
            }
            else
            {
                GCSkulltula.ForeColor = Color.Red;
            }
        }

        private void GVSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //11
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[11] == skulltulasMax[11])
                {
                    skulltulaActual[11] = 0;
                }
                else if (skulltulaActual[11] < skulltulasMax[11])
                {
                    skulltulaActual[11]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[11] == 0)
                {
                    skulltulaActual[11] = skulltulasMax[11];
                }
                else if (skulltulaActual[11] > 0)
                {
                    skulltulaActual[11]--;
                }
            }

            GVSkulltula.Text = "SKULLTULAS - " + skulltulaActual[11] + "/" + skulltulasMax[11];
            if (skulltulaActual[11] == skulltulasMax[11])
            {
                GVSkulltula.ForeColor = Color.Green;
            }
            else
            {
                GVSkulltula.ForeColor = Color.Red;
            }
        }

        private void DCWSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //12
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[12] == skulltulasMax[12])
                {
                    skulltulaActual[12] = 0;
                }
                else if (skulltulaActual[12] < skulltulasMax[12])
                {
                    skulltulaActual[12]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[12] == 0)
                {
                    skulltulaActual[12] = skulltulasMax[12];
                }
                else if (skulltulaActual[12] > 0)
                {
                    skulltulaActual[12]--;
                }
            }

            DCWSkulltula.Text = "SKULLTULAS - " + skulltulaActual[12] + "/" + skulltulasMax[12];
            if (skulltulaActual[12] == skulltulasMax[12])
            {
                DCWSkulltula.ForeColor = Color.Green;
            }
            else
            {
                DCWSkulltula.ForeColor = Color.Red;
            }
        }

        private void DTSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //13
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[13] == skulltulasMax[13])
                {
                    skulltulaActual[13] = 0;
                }
                else if (skulltulaActual[13] < skulltulasMax[13])
                {
                    skulltulaActual[13]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[13] == 0)
                {
                    skulltulaActual[13] = skulltulasMax[13];
                }
                else if (skulltulaActual[13] > 0)
                {
                    skulltulaActual[13]--;
                }
            }

            DTSkulltula.Text = "SKULLTULAS - " + skulltulaActual[13] + "/" + skulltulasMax[13];
            if (skulltulaActual[13] == skulltulasMax[13])
            {
                DTSkulltula.ForeColor = Color.Green;
            }
            else
            {
                DTSkulltula.ForeColor = Color.Red;
            }
        }

        private void DCSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //14
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[14] == skulltulasMax[14])
                {
                    skulltulaActual[14] = 0;
                }
                else if (skulltulaActual[14] < skulltulasMax[14])
                {
                    skulltulaActual[14]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[14] == 0)
                {
                    skulltulaActual[14] = skulltulasMax[14];
                }
                else if (skulltulaActual[14] > 0)
                {
                    skulltulaActual[14]--;
                }
            }

            DCSkulltula.Text = "SKULLTULAS - " + skulltulaActual[14] + "/" + skulltulasMax[14];
            if (skulltulaActual[14] == skulltulasMax[14])
            {
                DCSkulltula.ForeColor = Color.Green;
            }
            else
            {
                DCSkulltula.ForeColor = Color.Red;
            }
        }

        private void JabuSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //15
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[15] == skulltulasMax[15])
                {
                    skulltulaActual[15] = 0;
                }
                else if (skulltulaActual[15] < skulltulasMax[15])
                {
                    skulltulaActual[15]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[15] == 0)
                {
                    skulltulaActual[15] = skulltulasMax[15];
                }
                else if (skulltulaActual[15] > 0)
                {
                    skulltulaActual[15]--;
                }
            }

            JabuSkulltula.Text = "SKULLTULAS - " + skulltulaActual[15] + "/" + skulltulasMax[15];
            if (skulltulaActual[15] == skulltulasMax[15])
            {
                JabuSkulltula.ForeColor = Color.Green;
            }
            else
            {
                JabuSkulltula.ForeColor = Color.Red;
            }
        }

        private void BotwSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //16
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[16] == skulltulasMax[16])
                {
                    skulltulaActual[16] = 0;
                }
                else if (skulltulaActual[16] < skulltulasMax[16])
                {
                    skulltulaActual[16]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[16] == 0)
                {
                    skulltulaActual[16] = skulltulasMax[16];
                }
                else if (skulltulaActual[16] > 0)
                {
                    skulltulaActual[16]--;
                }
            }

            BotwSkulltula.Text = "SKULLTULAS - " + skulltulaActual[16] + "/" + skulltulasMax[16];
            if (skulltulaActual[16] == skulltulasMax[16])
            {
                BotwSkulltula.ForeColor = Color.Green;
            }
            else
            {
                BotwSkulltula.ForeColor = Color.Red;
            }
        }

        private void ForestSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //17
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[17] == skulltulasMax[17])
                {
                    skulltulaActual[17] = 0;
                }
                else if (skulltulaActual[17] < skulltulasMax[17])
                {
                    skulltulaActual[17]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[17] == 0)
                {
                    skulltulaActual[17] = skulltulasMax[17];
                }
                else if (skulltulaActual[17] > 0)
                {
                    skulltulaActual[17]--;
                }
            }

            ForestSkulltula.Text = "SKULLTULAS - " + skulltulaActual[17] + "/" + skulltulasMax[17];
            if (skulltulaActual[17] == skulltulasMax[17])
            {
                ForestSkulltula.ForeColor = Color.Green;
            }
            else
            {
                ForestSkulltula.ForeColor = Color.Red;
            }
        }

        private void FireSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //18
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[18] == skulltulasMax[18])
                {
                    skulltulaActual[18] = 0;
                }
                else if (skulltulaActual[18] < skulltulasMax[18])
                {
                    skulltulaActual[18]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[18] == 0)
                {
                    skulltulaActual[18] = skulltulasMax[18];
                }
                else if (skulltulaActual[18] > 0)
                {
                    skulltulaActual[18]--;
                }
            }

            FireSkulltula.Text = "SKULLTULAS - " + skulltulaActual[18] + "/" + skulltulasMax[18];
            if (skulltulaActual[18] == skulltulasMax[18])
            {
                FireSkulltula.ForeColor = Color.Green;
            }
            else
            {
                FireSkulltula.ForeColor = Color.Red;
            }
        }

        private void IceSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //19
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[19] == skulltulasMax[19])
                {
                    skulltulaActual[19] = 0;
                }
                else if (skulltulaActual[19] < skulltulasMax[19])
                {
                    skulltulaActual[19]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[19] == 0)
                {
                    skulltulaActual[19] = skulltulasMax[19];
                }
                else if (skulltulaActual[19] > 0)
                {
                    skulltulaActual[19]--;
                }
            }

            IceSkulltula.Text = "SKULLTULAS - " + skulltulaActual[19] + "/" + skulltulasMax[19];
            if (skulltulaActual[19] == skulltulasMax[19])
            {
                IceSkulltula.ForeColor = Color.Green;
            }
            else
            {
                IceSkulltula.ForeColor = Color.Red;
            }
        }

        private void ZFSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //20
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[20] == skulltulasMax[20])
                {
                    skulltulaActual[20] = 0;
                }
                else if (skulltulaActual[20] < skulltulasMax[20])
                {
                    skulltulaActual[20]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[20] == 0)
                {
                    skulltulaActual[20] = skulltulasMax[20];
                }
                else if (skulltulaActual[20] > 0)
                {
                    skulltulaActual[20]--;
                }
            }

            ZFSkulltula.Text = "SKULLTULAS - " + skulltulaActual[20] + "/" + skulltulasMax[20];
            if (skulltulaActual[20] == skulltulasMax[20])
            {
                ZFSkulltula.ForeColor = Color.Green;
            }
            else
            {
                ZFSkulltula.ForeColor = Color.Red;
            }
        }

        private void WaterSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //21
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[21] == skulltulasMax[21])
                {
                    skulltulaActual[21] = 0;
                }
                else if (skulltulaActual[21] < skulltulasMax[21])
                {
                    skulltulaActual[21]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[21] == 0)
                {
                    skulltulaActual[21] = skulltulasMax[21];
                }
                else if (skulltulaActual[21] > 0)
                {
                    skulltulaActual[21]--;
                }
            }

            WaterSkulltula.Text = "SKULLTULAS - " + skulltulaActual[21] + "/" + skulltulasMax[21];
            if (skulltulaActual[21] == skulltulasMax[21])
            {
                WaterSkulltula.ForeColor = Color.Green;
            }
            else
            {
                WaterSkulltula.ForeColor = Color.Red;
            }
        }

        private void ShadowSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //22
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[22] == skulltulasMax[22])
                {
                    skulltulaActual[22] = 0;
                }
                else if (skulltulaActual[22] < skulltulasMax[22])
                {
                    skulltulaActual[22]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[22] == 0)
                {
                    skulltulaActual[22] = skulltulasMax[22];
                }
                else if (skulltulaActual[22] > 0)
                {
                    skulltulaActual[22]--;
                }
            }

            ShadowSkulltula.Text = "SKULLTULAS - " + skulltulaActual[22] + "/" + skulltulasMax[22];
            if (skulltulaActual[22] == skulltulasMax[22])
            {
                ShadowSkulltula.ForeColor = Color.Green;
            }
            else
            {
                ShadowSkulltula.ForeColor = Color.Red;
            }
        }

        private void SpiritSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //23
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[23] == skulltulasMax[23])
                {
                    skulltulaActual[23] = 0;
                }
                else if (skulltulaActual[23] < skulltulasMax[23])
                {
                    skulltulaActual[23]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[23] == 0)
                {
                    skulltulaActual[23] = skulltulasMax[23];
                }
                else if (skulltulaActual[23] > 0)
                {
                    skulltulaActual[23]--;
                }
            }

            SpiritSkulltula.Text = "SKULLTULAS - " + skulltulaActual[23] + "/" + skulltulasMax[23];
            if (skulltulaActual[23] == skulltulasMax[23])
            {
                SpiritSkulltula.ForeColor = Color.Green;
            }
            else
            {
                SpiritSkulltula.ForeColor = Color.Red;
            }
        }

        private void LonLonSkulltula_MouseClick(object sender, MouseEventArgs e)
        {
            //26
            if (e.Button == MouseButtons.Left)
            {
                if (skulltulaActual[26] == skulltulasMax[26])
                {
                    skulltulaActual[26] = 0;
                }
                else if (skulltulaActual[26] < skulltulasMax[26])
                {
                    skulltulaActual[26]++;
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (skulltulaActual[26] == 0)
                {
                    skulltulaActual[26] = skulltulasMax[26];
                }
                else if (skulltulaActual[26] > 0)
                {
                    skulltulaActual[26]--;
                }
            }

            LonLonSkulltula.Text = "SKULLTULAS - " + skulltulaActual[26] + "/" + skulltulasMax[26];
            if (skulltulaActual[26] == skulltulasMax[26])
            {
                LonLonSkulltula.ForeColor = Color.Green;
            }
            else
            {
                LonLonSkulltula.ForeColor = Color.Red;
            }
        }
    }
}
