using Memory;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Zelda_Test
{
    public partial class OoT : Form
    {
        bool running = false;
        public string currentEmulator = "";
        public int location2ByteTwo;
        public int location2ByteOne;
        public int tempWeapon = 0;
        public int tempClothing = 0;
        public int tempMO = 0;
        public int tempMT = 0;
        public int tempS = 0;
        public int tempBS = 0;
        public int tempBQG = 0;
        public int tempDSN = 0;
        public int inPlay2Byte = 0;
        public int bottle2Byte = 0;
        public int bottleTwo2Byte = 0;
        public int bottleThree2Byte = 0;
        public int bottleFour2Byte = 0;
        public int dekuStick2Byte = 0;
        public int boomerang2Byte = 0;
        public int slingshot2Byte = 0;
        public int lensOfTruth2Byte = 0;
        public int ocarina2Byte = 0;
        public int dekuNuts2Byte = 0;
        public int magicBeans2Byte = 0;
        public int bombchu2Byte = 0;
        public int bombs2Byte = 0;
        public int megatonHammer2Byte = 0;
        public int hookshot2Byte = 0;
        public int fairyBow2Byte = 0;
        public int lightArrow2Byte = 0;
        public int iceArrow2Byte = 0;
        public int fireArrow2Byte = 0;
        public int nayru2Byte = 0;
        public int farore2Byte = 0;
        public int din2Byte = 0;
        public int adult2Byte = 0;
        public int child2Byte = 0;
        public int deku2Byte = 0;
        public int dodongo2Byte = 0;
        public int jabu2Byte = 0;
        public int forest2Byte = 0;
        public int forestKey2Byte = 0;
        public int fire2Byte = 0;
        public int fireKey2Byte = 0;
        public int water2Byte = 0;
        public int waterKey2Byte = 0;
        public int spirit2Byte = 0;
        public int spiritKey2Byte = 0;
        public int shadow2Byte = 0;
        public int shadowKey2Byte = 0;
        public int iceCavern2Byte = 0;
        public int BOTW2Byte = 0;
        public int BOTWKey2Byte = 0;
        public int gerudoTrainingGround2Byte = 0;
        public int gerudoFortress2Byte = 0;
        public int ganonsCastleBig2Byte = 0;
        public int ganonsCastleKey2Byte = 0;
        public int doubleDefense2Byte = 0;
        public int magic2Byte = 0;
        public int skulltula2Byte = 0;
        public int sNs2Byte = 0;
        public int bgs2Byte = 0;
        public int c2Byte = 0;
        public int MO2Byte = 0;
        public int MT2Byte = 0;
        public int s2Byte = 0;
        public int bs2Byte = 0;
        public int bqg2Byte = 0;
        public int ds2Byte = 0;
        public Mem MemLib = new Mem();
        public string firstFourHexDigits = "";
        public string workingPath = AppDomain.CurrentDomain.BaseDirectory + "\\Icons\\";
        public string logPath = AppDomain.CurrentDomain.BaseDirectory + "\\Logs\\";
        public string logDir = AppDomain.CurrentDomain.BaseDirectory + "\\Logs";
        bool open = false;
        public int pbutton1 = 0;
        public int pbutton2 = 0;
        public int pbutton3 = 0;
        public int pbutton4 = 0;
        public int pbutton5 = 0;
        public int pbutton6 = 0;
        public int pbutton7 = 0;
        public int pbutton8 = 0;
        public int pbutton9 = 0;
        public bool locked = false;
        public string currentLogFile;
        public int bottleOneValue;
        public int bottleTwoValue;
        public int bottleThreeValue;
        public int bottleFourValue;
        public int bottleOneTempValue;
        public int bottleTwoTempValue;
        public int bottleThreeTempValue;
        public int bottleFourTempValue;
        public bool dekuStick;
        public bool boomerang;
        public bool slingshot;
        public bool lensOfTruth;
        public bool ocarinaOne;
        public bool ocarinaTwo;
        public bool dekuNuts;
        public bool magicBeans;
        public bool bombchus;
        public bool bombs;
        public bool megatonHammer;
        public bool hookShotOne;
        public bool hookShotTwo;
        public bool bow;
        public bool lightArrow;
        public bool iceArrow;
        public bool fireArrow;
        public bool nayrusLove;
        public bool faroresWind;
        public bool dinsFire;
        public int adultTradeValue;
        public int adultTradeTempValue;
        public int childTradeValue;
        public int childTradeTempValue;
        public bool dekuMap;
        public bool dekuCompass;
        public bool dcMap;
        public bool dcCompass;
        public bool jabuMap;
        public bool jabuCompass;
        public bool forestBigKey;
        public bool forestMap;
        public bool forestCompass;
        public int forestKeyValue;
        public int forestKeyTempValue;
        public bool fireBigKey;
        public bool fireMap;
        public bool fireCompass;
        public int fireKeysValue;
        public int fireKeysTempValue;
        public bool waterBigKey;
        public bool waterMap;
        public bool waterCompass;
        public int waterKeysValue;
        public int waterKeysTempValue;
        public bool spiritBigKey;
        public bool spiritMap;
        public bool spiritCompass;
        public int spiritKeysValue;
        public int spiritKeysTempValue;
        public bool shadowBigKey;
        public bool shadowMap;
        public bool shadowCompass;
        public int shadowKeysValue;
        public int shadowKeysTempValue;
        public bool iceCavernMap;
        public bool iceCavernCompass;
        public bool botwMap;
        public bool botwCompass;
        public int botwKeysValue;
        public int botwKeysTempValue;
        public int gtgKeysValue;
        public int gtgKeysTempValue;
        public int fortressKeysValue;
        public int fortressKeysTempValue;
        public bool ganonBigKey;
        public int ganonKeysValue;
        public int ganonKeysTempValue;
        public bool doubleDefense;
        public bool magicOne;
        public bool magicTwo;
        public int skullValue;
        public int skullTempValue;
        public bool sAndH1;
        public bool sAndH2;
        public bool sAndH3;
        public bool sAndH4;
        public bool sAndH5;
        public bool sAndH6;
        public bool c1;
        public bool c2;
        public bool c3;
        public bool c4;
        public bool ms1;
        public bool ms2;
        public bool ms3;
        public bool ms4;
        public bool ms5;
        public bool ms6;
        public bool ms7;
        public bool ms8;
        public bool ss1;
        public bool ss2;
        public bool ss3;
        public bool ss4;
        public bool ss5;
        public bool ss6;
        public bool ss7;
        public bool s1;
        public bool s2;
        public bool s3;
        public bool s4;
        public bool s5;
        public bool s6;
        public bool s7;
        public bool s8;
        public bool bs1;
        public bool bs2;
        public bool bs3;
        public bool bs4;
        public bool bs5;
        public bool bs6;
        public bool bs7;
        public bool bs8;
        public bool bg1;
        public bool bg2;
        public bool bg3;
        public bool bg4;
        public bool bg5;
        public bool bg6;
        public bool bg7;
        public bool bg8;
        public bool bg9;
        public bool ds1;
        public bool ds2;
        public bool ds3;
        public bool ds4;
        public bool ds5;
        public bool ds6;
        public string inPlay2ByteStr;
        public string bottle2ByteStr;
        public string bottleTwo2ByteStr;
        public string bottleThree2ByteStr;
        public string bottleFour2ByteStr;
        public string dekuStick2ByteStr;
        public string boomerang2ByteStr;
        public string slingshot2ByteStr;
        public string lensOfTruth2ByteStr;
        public string ocarina2ByteStr;
        public string dekuNuts2ByteStr;
        public string magicBeans2ByteStr;
        public string bombchu2ByteStr;
        public string bombs2ByteStr;
        public string megatonHammer2ByteStr;
        public string hookshot2ByteStr;
        public string fairyBow2ByteStr;
        public string lightArrow2ByteStr;
        public string iceArrow2ByteStr;
        public string fireArrow2ByteStr;
        public string nayru2ByteStr;
        public string farore2ByteStr;
        public string din2ByteStr;
        public string adult2ByteStr;
        public string child2ByteStr;
        public string deku2ByteStr;
        public string dodongo2ByteStr;
        public string jabu2ByteStr;
        public string forest2ByteStr;
        public string forestKey2ByteStr;
        public string fire2ByteStr;
        public string fireKey2ByteStr;
        public string water2ByteStr;
        public string waterKey2ByteStr;
        public string spirit2ByteStr;
        public string spiritKey2ByteStr;
        public string shadow2ByteStr;
        public string shadowKey2ByteStr;
        public string iceCavern2ByteStr;
        public string BOTW2ByteStr;
        public string BOTWKey2ByteStr;
        public string gerudoTrainingGround2ByteStr;
        public string gerudoFortress2ByteStr;
        public string ganonsCastleBig2ByteStr;
        public string ganonsCastleKey2ByteStr;
        public string doubleDefense2ByteStr;
        public string magic2ByteStr;
        public string skulltula2ByteStr;
        public string sNs2ByteStr;
        public string bgs2ByteStr;
        public string c2ByteStr;
        public string MO2ByteStr;
        public string MT2ByteStr;
        public string s2ByteStr;
        public string bs2ByteStr;
        public string bqg2ByteStr;
        public string ds2ByteStr;
        public FileAttributes attributes;
        public string fullAddress;
        public List<string> logLines = new List<string>();
        public string baseAddress;
        public string tempDifference;

        public int bombChuCount;

public static Form2 form2 = new Form2();

        //public Form2 form2 = new Form2();

        //public bool callChange = false;

        public OoT()
        {
            InitializeComponent();
            button2.Enabled = true;
            //Form2 form2 = new Form2();
            //form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Form2 form2 = new Form2();
            //form2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        public void SetMemoryStrings()
        {
            //42BB (A5C8)

            int baseInt = int.Parse(baseAddress, System.Globalization.NumberStyles.HexNumber);

            int tempInt = baseInt + 66;
            tempDifference = tempInt.ToString("X4");
            inPlay2ByteStr = tempDifference;//"A60A";

            tempInt = baseInt + 141;
            tempDifference = tempInt.ToString("X4");
            bottle2ByteStr = tempDifference;//"A655";

            tempInt = baseInt + 140;
            tempDifference = tempInt.ToString("X4");
            bottleTwo2ByteStr = tempDifference;//"A654";

            tempInt = baseInt + 147;
            tempDifference = tempInt.ToString("X4");
            bottleThree2ByteStr = tempDifference;//"A65B";

            tempInt = baseInt + 146;
            tempDifference = tempInt.ToString("X4");
            bottleFour2ByteStr = tempDifference;//"A65A";

            tempInt = baseInt + 127;
            tempDifference = tempInt.ToString("X4");
            dekuStick2ByteStr = tempDifference;//"A647";

            tempInt = baseInt + 139;
            tempDifference = tempInt.ToString("X4");
            boomerang2ByteStr = tempDifference;//"A653";

            tempInt = baseInt + 129;
            tempDifference = tempInt.ToString("X4");
            slingshot2ByteStr = tempDifference;//"A649";

            tempInt = baseInt + 138;
            tempDifference = tempInt.ToString("X4");
            lensOfTruth2ByteStr = tempDifference;//"A652";

            tempInt = baseInt + 128;
            tempDifference = tempInt.ToString("X4");
            ocarina2ByteStr = tempDifference;//"A648";

            tempInt = baseInt + 126;
            tempDifference = tempInt.ToString("X4");
            dekuNuts2ByteStr = tempDifference;//"A646";

            tempInt = baseInt + 137;
            tempDifference = tempInt.ToString("X4");
            magicBeans2ByteStr = tempDifference;//"A651";

            tempInt = baseInt + 135;
            tempDifference = tempInt.ToString("X4");
            bombchu2ByteStr = tempDifference;//"A64F";

            tempInt = baseInt + 125;
            tempDifference = tempInt.ToString("X4");
            bombs2ByteStr = tempDifference;//"A645";

            tempInt = baseInt + 136;
            tempDifference = tempInt.ToString("X4");
            megatonHammer2ByteStr = tempDifference;//"A650";

            tempInt = baseInt + 134;
            tempDifference = tempInt.ToString("X4");
            hookshot2ByteStr = tempDifference;//"A64E";

            tempInt = baseInt + 124;
            tempDifference = tempInt.ToString("X4");
            fairyBow2ByteStr = tempDifference;//"A644";

            tempInt = baseInt + 143;
            tempDifference = tempInt.ToString("X4");
            lightArrow2ByteStr = tempDifference;//"A657";

            tempInt = baseInt + 133;
            tempDifference = tempInt.ToString("X4");
            iceArrow2ByteStr = tempDifference;//"A64D";

            tempInt = baseInt + 131;
            tempDifference = tempInt.ToString("X4");
            fireArrow2ByteStr = tempDifference;//"A64B";

            tempInt = baseInt + 142;
            tempDifference = tempInt.ToString("X4");
            nayru2ByteStr = tempDifference;//"A656";

            tempInt = baseInt + 132;
            tempDifference = tempInt.ToString("X4");
            farore2ByteStr = tempDifference;//"A64C";

            tempInt = baseInt + 130;
            tempDifference = tempInt.ToString("X4");
            din2ByteStr = tempDifference;//"A64A";

            tempInt = baseInt + 145;
            tempDifference = tempInt.ToString("X4");
            adult2ByteStr = tempDifference;//"A659";

            tempInt = baseInt + 144;
            tempDifference = tempInt.ToString("X4");
            child2ByteStr = tempDifference;//"A658";

            tempInt = baseInt + 179;
            tempDifference = tempInt.ToString("X4");
            deku2ByteStr = tempDifference;//"A67B";

            tempInt = baseInt + 178;
            tempDifference = tempInt.ToString("X4");
            dodongo2ByteStr = tempDifference;//"A67A";

            tempInt = baseInt + 177;
            tempDifference = tempInt.ToString("X4");
            jabu2ByteStr = tempDifference;//"A679";

            tempInt = baseInt + 176;
            tempDifference = tempInt.ToString("X4");
            forest2ByteStr = tempDifference;//"A678";

            tempInt = baseInt + 196;
            tempDifference = tempInt.ToString("X4");
            forestKey2ByteStr = tempDifference;//"A68C";

            tempInt = baseInt + 183;
            tempDifference = tempInt.ToString("X4");
            fire2ByteStr = tempDifference;//"A67F";

            tempInt = baseInt + 203;
            tempDifference = tempInt.ToString("X4");
            fireKey2ByteStr = tempDifference;//"A693";

            tempInt = baseInt + 182;
            tempDifference = tempInt.ToString("X4");
            water2ByteStr = tempDifference;//"A67E";

            tempInt = baseInt + 202;
            tempDifference = tempInt.ToString("X4");
            waterKey2ByteStr = tempDifference;//"A692";

            tempInt = baseInt + 181;
            tempDifference = tempInt.ToString("X4");
            spirit2ByteStr = tempDifference;//"A67D";

            tempInt = baseInt + 201;
            tempDifference = tempInt.ToString("X4");
            spiritKey2ByteStr = tempDifference;//"A691";

            tempInt = baseInt + 180;
            tempDifference = tempInt.ToString("X4");
            shadow2ByteStr = tempDifference;//"A67C";

            tempInt = baseInt + 200;
            tempDifference = tempInt.ToString("X4");
            shadowKey2ByteStr = tempDifference;//"A690";

            tempInt = baseInt + 186;
            tempDifference = tempInt.ToString("X4");
            iceCavern2ByteStr = tempDifference;//"A682";

            tempInt = baseInt + 187;
            tempDifference = tempInt.ToString("X4");
            BOTW2ByteStr = tempDifference;//"A683";

            tempInt = baseInt + 207;
            tempDifference = tempInt.ToString("X4");
            BOTWKey2ByteStr = tempDifference;//"A697";

            tempInt = baseInt + 204;
            tempDifference = tempInt.ToString("X4");
            gerudoTrainingGround2ByteStr = tempDifference;//"A694";

            tempInt = baseInt + 211;
            tempDifference = tempInt.ToString("X4");
            gerudoFortress2ByteStr = tempDifference;//"A69B";

            tempInt = baseInt + 185;
            tempDifference = tempInt.ToString("X4");
            ganonsCastleBig2ByteStr = tempDifference;//"A681";

            tempInt = baseInt + 210;
            tempDifference = tempInt.ToString("X4");
            ganonsCastleKey2ByteStr = tempDifference;//"A69A";

            tempInt = baseInt + 212;
            tempDifference = tempInt.ToString("X4");
            doubleDefense2ByteStr = tempDifference;//"A69C";

            tempInt = baseInt + 57;
            tempDifference = tempInt.ToString("X4");
            magic2ByteStr = tempDifference;//"A601";

            tempInt = baseInt + 218;
            tempDifference = tempInt.ToString("X4");
            skulltula2ByteStr = tempDifference;//"A6A2";

            tempInt = baseInt + 166;
            tempDifference = tempInt.ToString("X4");
            sNs2ByteStr = tempDifference;//"A66E";

            tempInt = baseInt + 69;
            tempDifference = tempInt.ToString("X4");
            bgs2ByteStr = tempDifference;//"A60D";

            tempInt = baseInt + 167;
            tempDifference = tempInt.ToString("X4");
            c2ByteStr = tempDifference;//"A66F";

            tempInt = baseInt + 172;
            tempDifference = tempInt.ToString("X4");
            MO2ByteStr = tempDifference;//"A674";

            tempInt = baseInt + 174;
            tempDifference = tempInt.ToString("X4");
            MT2ByteStr = tempDifference;//"A676";

            tempInt = baseInt + 173;
            tempDifference = tempInt.ToString("X4");
            s2ByteStr = tempDifference;//"A675";

            tempInt = baseInt + 169;
            tempDifference = tempInt.ToString("X4");
            bs2ByteStr = tempDifference;//"A671";

            tempInt = baseInt + 168;
            tempDifference = tempInt.ToString("X4");
            bqg2ByteStr = tempDifference;//"A670";

            tempInt = baseInt + 170;
            tempDifference = tempInt.ToString("X4");
            ds2ByteStr = tempDifference;//"A672";
            /*
            else if (currentEmulator == "RetroArch")
            {
                inPlay2ByteStr = "6BEA";
                bottle2ByteStr = "6C35";
                bottleTwo2ByteStr = "6C34";
                bottleThree2ByteStr = "6C3B";
                bottleFour2ByteStr = "6C3A";
                dekuStick2ByteStr = "6C27";
                boomerang2ByteStr = "6C33";
                slingshot2ByteStr = "6C29";
                lensOfTruth2ByteStr = "6C32";
                ocarina2ByteStr = "6C28";
                dekuNuts2ByteStr = "6C26";
                magicBeans2ByteStr = "6C31";
                bombchu2ByteStr = "6C2F";
                bombs2ByteStr = "6C25";
                megatonHammer2ByteStr = "6C30";
                hookshot2ByteStr = "6C2E";
                fairyBow2ByteStr = "6C24";
                lightArrow2ByteStr = "6C37";
                iceArrow2ByteStr = "6C2D";
                fireArrow2ByteStr = "6C2B";
                nayru2ByteStr = "6C36";
                farore2ByteStr = "6C2C";
                din2ByteStr = "6C2A";
                adult2ByteStr = "6C39";
                child2ByteStr = "6C38";
                deku2ByteStr = "6C5B";
                dodongo2ByteStr = "6C5A";
                jabu2ByteStr = "6C59";
                forest2ByteStr = "6C58";
                forestKey2ByteStr = "6C6C";
                fire2ByteStr = "6C5F";
                fireKey2ByteStr = "6C73";
                water2ByteStr = "6C5E";
                waterKey2ByteStr = "6C72";
                spirit2ByteStr = "6C5D";
                spiritKey2ByteStr = "6C71";
                shadow2ByteStr = "6C5C";
                shadowKey2ByteStr = "6C70";
                iceCavern2ByteStr = "6C62";
                BOTW2ByteStr = "6C63";
                BOTWKey2ByteStr = "6C77";
                gerudoTrainingGround2ByteStr = "6C74";
                gerudoFortress2ByteStr = "6C7B";
                ganonsCastleBig2ByteStr = "6C61";
                ganonsCastleKey2ByteStr = "6C7A";
                doubleDefense2ByteStr = "6C7C";
                magic2ByteStr = "6BE1";
                skulltula2ByteStr = "6C82";
                sNs2ByteStr = "6C4E";
                bgs2ByteStr = "6BED";
                c2ByteStr = "6C4F";
                MO2ByteStr = "6C54";
                MT2ByteStr = "6C56";
                s2ByteStr = "6C55";
                bs2ByteStr = "6C51";
                bqg2ByteStr = "6C50";
                ds2ByteStr = "6C52";
            }
            else if (currentEmulator == "Bizhawk")
            {
                inPlay2ByteStr = "47CA";
                bottle2ByteStr = "4815";
                bottleTwo2ByteStr = "4814";
                bottleThree2ByteStr = "481B";
                bottleFour2ByteStr = "481A";
                dekuStick2ByteStr = "4807";
                boomerang2ByteStr = "4813";
                slingshot2ByteStr = "4809";
                lensOfTruth2ByteStr = "4812";
                ocarina2ByteStr = "4808";
                dekuNuts2ByteStr = "4806";
                magicBeans2ByteStr = "4811";
                bombchu2ByteStr = "480F";
                bombs2ByteStr = "4805";
                megatonHammer2ByteStr = "4810";
                hookshot2ByteStr = "480E";
                fairyBow2ByteStr = "4804";
                lightArrow2ByteStr = "4817";
                iceArrow2ByteStr = "480D";
                fireArrow2ByteStr = "480B";
                nayru2ByteStr = "4816";
                farore2ByteStr = "480C";
                din2ByteStr = "480A";
                adult2ByteStr = "4819";
                child2ByteStr = "4818";
                deku2ByteStr = "483B";
                dodongo2ByteStr = "483A";
                jabu2ByteStr = "4839";
                forest2ByteStr = "4838";
                forestKey2ByteStr = "484C";
                fire2ByteStr = "483F";
                fireKey2ByteStr = "4853";
                water2ByteStr = "483E";
                waterKey2ByteStr = "4852";
                spirit2ByteStr = "483D";
                spiritKey2ByteStr = "4851";
                shadow2ByteStr = "483C";
                shadowKey2ByteStr = "4850";
                iceCavern2ByteStr = "4842";
                BOTW2ByteStr = "4843";
                BOTWKey2ByteStr = "4857";
                gerudoTrainingGround2ByteStr = "4854";
                gerudoFortress2ByteStr = "485B";
                ganonsCastleBig2ByteStr = "4841";
                ganonsCastleKey2ByteStr = "485A";
                doubleDefense2ByteStr = "485C";
                magic2ByteStr = "47C1";
                skulltula2ByteStr = "4862";
                sNs2ByteStr = "482E";
                bgs2ByteStr = "47CD";
                c2ByteStr = "482F";
                MO2ByteStr = "4834";
                MT2ByteStr = "4836";
                s2ByteStr = "4835";
                bs2ByteStr = "4831";
                bqg2ByteStr = "4830";
                ds2ByteStr = "4832";
            }
            */
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string dateAndTime = DateTime.Now.ToString();
            dateAndTime = dateAndTime.Replace("/",".");
            dateAndTime = dateAndTime.Replace(":",".");

            if (firstFourHexDigits.Length > 5 && firstFourHexDigits != "")
            {
                running = true;
                backgroundWorker1.RunWorkerAsync();
                button2.Enabled = false;

                if(!Directory.Exists(logDir))
                {
                    DirectoryInfo di = Directory.CreateDirectory(logDir);
                }

                if (currentEmulator == "Project64")
                {
                    currentLogFile = logPath + "Project64 " + dateAndTime + ".txt";
                    using (StreamWriter sw = File.CreateText(currentLogFile))
                    {
                        sw.WriteLine("Working Memory Address: " + fullAddress.ToString() + Environment.NewLine);
                    }
                    logLines.Add("Working Memory Address: " + fullAddress.ToString());
                    //baseAddress = fullAddress.Substring(2, fullAddress.Length-2);
                    /*
                    int baseInt = int.Parse("A5C8", System.Globalization.NumberStyles.HexNumber);
                    int tempInt = baseInt + 66;
                    tempDifference = tempInt.ToString("X4");
                    MessageBox.Show(tempDifference);
                    */
                }
                else if(currentEmulator == "RetroArch")
                {
                    currentLogFile = logPath + "RetroArch " + dateAndTime + ".txt";
                    using (StreamWriter sw = File.CreateText(currentLogFile))
                    {
                        sw.WriteLine("Working Memory Address: " + fullAddress.ToString() + Environment.NewLine);
                    }
                    logLines.Add("Working Memory Address: " + fullAddress.ToString());
                }
                else if (currentEmulator == "Bizhawk")
                {
                    currentLogFile = logPath + "Bizhawk " + dateAndTime + ".txt";
                    using (StreamWriter sw = File.CreateText(currentLogFile))
                    {
                        sw.WriteLine("Working Memory Address: " + fullAddress.ToString() + Environment.NewLine);
                    }
                    logLines.Add("Working Memory Address: " + fullAddress.ToString());
                }

                SetMemoryStrings();

                attributes = File.GetAttributes(currentLogFile);

                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    // Show the file.
                    attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                    File.SetAttributes(currentLogFile, attributes);
                    Console.WriteLine("The {0} file is no longer hidden.", currentLogFile);
                }
                else
                {
                    // Hide the file.
                    File.SetAttributes(currentLogFile, File.GetAttributes(currentLogFile) | FileAttributes.Hidden);
                    Console.WriteLine("The {0} file is now hidden.", currentLogFile);
                }
            }
            else
            {
                MessageBox.Show("Scan game properly before starting the tracker.");
            }
        }

        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void Start()
        {
            //(new Form2()).Show();
        }

        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                while (running)
                {
                    if (!Directory.Exists(logDir))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(logDir);
                    }

                    if (!File.Exists(currentLogFile))
                    {
                        using (StreamWriter sw = File.CreateText(currentLogFile))
                        {
                            //sw.WriteLine("Working Memory Address: " + fullAddress.ToString() + Environment.NewLine);
                        }
                        File.WriteAllLines(currentLogFile, logLines, Encoding.UTF8);

                        attributes = File.GetAttributes(currentLogFile);

                        if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                        {
                            // Show the file.
                            attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                            File.SetAttributes(currentLogFile, attributes);
                            Console.WriteLine("The {0} file is no longer hidden.", currentLogFile);
                        }
                        else
                        {
                            // Hide the file.
                            File.SetAttributes(currentLogFile, File.GetAttributes(currentLogFile) | FileAttributes.Hidden);
                            Console.WriteLine("The {0} file is now hidden.", currentLogFile);
                        }
                    }

                    if (currentEmulator == "Project64")
                    {
                        open = MemLib.OpenProcess("Project64");
                        if (!open)
                        {
                            MemLib.OpenProcess("Project64");
                        }
                    }
                    else if (currentEmulator == "RetroArch")
                    {
                        open = MemLib.OpenProcess("retroarch");
                        if (!open)
                        {
                            MemLib.OpenProcess("retroarch");
                        }
                    }
                    else if(currentEmulator == "Bizhawk")
                    {
                        open = MemLib.OpenProcess("EmuHawk");
                        if (!open)
                        {
                            MemLib.OpenProcess("EmuHawk");
                        }
                    }

                    //BOTTLE ONE
                    bottle2Byte = MemLib.readByte(firstFourHexDigits + bottle2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {

                        //project64
                        //bomb count = A65D
                        //bombchu count = A667
                        //health = A602

                        /////////////////////////////////
                        ////*
                        ///

                        /*
                        int levByte = MemLib.readByte("467B84B8");
                        int lev2Byte = MemLib.read2Byte("467B84B8");

                        if (inPlay2Byte != 0)
                        {
                            if (levByte == 32)
                            {
                                MemLib.writeMemory("477CAA93", "2bytes", "40CB");

                            }
                            if (lev2Byte == 32)
                            {
                                MemLib.writeMemory("477CAA93", "2bytes", "40CB");

                            }
                            //Console.WriteLine("levByte " + levByte);
                            //Console.WriteLine("lev2Byte " + lev2Byte);
                        }

                        if (MemLib.readByte(firstFourHexDigits + "A667") < 9)
                        {
                            MemLib.writeMemory((firstFourHexDigits + "A667"), "2bytes", "0009");
                            Console.WriteLine(MemLib.read2Byte(firstFourHexDigits + "A667"));
                        }*/
                        ////////////////////////////////


                        if (bottle2Byte != 255)
                        {
                            bool hasWritten = false;

                            bottleOneValue = bottle2Byte;

                            if (bottleOneValue != bottleOneTempValue)
                            {
                                hasWritten = false;
                            }
                            else if (bottleOneValue == bottleOneTempValue)
                            {
                                hasWritten = true;
                            }

                            string dateAndTime = DateTime.Now.ToString();
                            dateAndTime = dateAndTime.Replace("/", ".");
                            dateAndTime = dateAndTime.Replace(":", ".");

                            if (bottle2Byte == 20)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Empty Bottle.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Empty Bottle - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 21)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Red Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Red Potion - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 22)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Green Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Green Potion - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 23)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Blue Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Blue Potion - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 24)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Bottled Fairy.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottled Fairy - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 25)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Fish.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fish - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 26)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Milk.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Milk - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 27)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Ruto's Letter.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ruto's Letter - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 28)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Blue Fire.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Blue Fire - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 29)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Bug.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bug - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 30)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Big Poe.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Big Poe - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 31)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Milk (Half).png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Milk (Half) - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottle2Byte == 32)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Poe.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Poe - Bottle slot one." + " Address: " + firstFourHexDigits + bottle2ByteStr + " Value: " + bottle2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleOne.Image = Image.FromFile(workingPath + "Empty Bottle - Gray.png");
                                });
                            }

                            bottleOneTempValue = bottleOneValue;
                        }
                    }
                    //BOTTLE TWO
                    bottleTwo2Byte = MemLib.readByte(firstFourHexDigits + bottleTwo2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (bottleTwo2Byte != 255)
                        {
                            bool hasWritten = false;

                            bottleTwoValue = bottleTwo2Byte;

                            if (bottleTwoValue != bottleTwoTempValue)
                            {
                                hasWritten = false;
                            }
                            else if (bottleTwoValue == bottleTwoTempValue)
                            {
                                hasWritten = true;
                            }

                            string dateAndTime = DateTime.Now.ToString();
                            dateAndTime = dateAndTime.Replace("/", ".");
                            dateAndTime = dateAndTime.Replace(":", ".");

                            if (bottleTwo2Byte == 20)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Empty Bottle.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Empty Bottle - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 21)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Red Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Red Potion - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 22)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Green Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Green Potion - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 23)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Blue Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Blue Potion - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 24)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Bottled Fairy.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottled Fairy - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 25)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Fish.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fish - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 26)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Milk.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Milk - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 27)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Ruto's Letter.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ruto's Letter - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 28)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Blue Fire.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Blue Fire - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 29)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Bug.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bug - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 30)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Big Poe.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Big Poe - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 31)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Milk (Half).png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Milk (Half) - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleTwo2Byte == 32)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Poe.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Poe - Bottle slot two." + " Address: " + firstFourHexDigits + bottleTwo2ByteStr + " Value: " + bottleTwo2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleTwo.Image = Image.FromFile(workingPath + "Empty Bottle - Gray.png");
                                });
                            }

                            bottleTwoTempValue = bottleTwoValue;
                        }
                    }
                    //BOTTLE THREE
                    bottleThree2Byte = MemLib.readByte(firstFourHexDigits + bottleThree2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (bottleThree2Byte != 255)
                        {
                            bool hasWritten = false;

                            bottleThreeValue = bottleThree2Byte;

                            if (bottleThreeValue != bottleThreeTempValue)
                            {
                                hasWritten = false;
                            }
                            else if (bottleThreeValue == bottleThreeTempValue)
                            {
                                hasWritten = true;
                            }

                            string dateAndTime = DateTime.Now.ToString();
                            dateAndTime = dateAndTime.Replace("/", ".");
                            dateAndTime = dateAndTime.Replace(":", ".");

                            if (bottleThree2Byte == 20)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Empty Bottle.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Empty Bottle - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 21)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Red Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Red Potion - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 22)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Green Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Green Potion - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 23)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Blue Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Blue Potion - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 24)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Bottled Fairy.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottled Fairy - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 25)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Fish.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fish - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 26)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Milk.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Milk - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 27)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Ruto's Letter.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ruto's Letter - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 28)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Blue Fire.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Blue Fire - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 29)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Bug.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bug - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 30)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Big Poe.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Big Poe - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 31)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Milk (Half).png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Milk (Half) - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleThree2Byte == 32)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Poe.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Poe - Bottle slot three." + " Address: " + firstFourHexDigits + bottleThree2ByteStr + " Value: " + bottleThree2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleThree.Image = Image.FromFile(workingPath + "Empty Bottle - Gray.png");
                                });
                            }

                            bottleThreeTempValue = bottleThreeValue;
                        }
                    }
                    //BOTTLE FOUR
                    bottleFour2Byte = MemLib.readByte(firstFourHexDigits + bottleFour2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (bottleFour2Byte != 255)
                        {
                            bool hasWritten = false;

                            bottleFourValue = bottleFour2Byte;

                            if (bottleFourValue != bottleFourTempValue)
                            {
                                hasWritten = false;
                            }
                            else if (bottleFourValue == bottleFourTempValue)
                            {
                                hasWritten = true;
                            }

                            string dateAndTime = DateTime.Now.ToString();
                            dateAndTime = dateAndTime.Replace("/", ".");
                            dateAndTime = dateAndTime.Replace(":", ".");

                            if (bottleFour2Byte == 20)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Empty Bottle.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Empty Bottle - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 21)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Red Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Red Potion - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 22)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Green Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Green Potion - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 23)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Blue Potion.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Blue Potion - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 24)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Bottled Fairy.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottle Fairy - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 25)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Fish.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fish - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 26)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Milk.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Milk - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 27)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Ruto's Letter.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ruto's Letter - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 28)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Blue Fire.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Blue Fire - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 29)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Bug.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bug - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 30)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Big Poe.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Big Poe - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 31)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Milk (Half).png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Milk (Half) - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (bottleFour2Byte == 32)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Poe.png");
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Poe - Bottle slot four." + " Address: " + firstFourHexDigits + bottleFour2ByteStr + " Value: " + bottleFour2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BottleFour.Image = Image.FromFile(workingPath + "Empty Bottle - Gray.png");
                                });
                            }

                            bottleFourTempValue = bottleFourValue;
                        }
                    }
                    //DEKU STICK (FIRST PICKUP)
                    dekuStick2Byte = MemLib.readByte(firstFourHexDigits + dekuStick2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (dekuStick2Byte == 0)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DekuStick.Image = Image.FromFile(workingPath + "DekuStick.png");
                                    
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!dekuStick)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Stick." + " Address: " + firstFourHexDigits + dekuStick2ByteStr + " Value: " + dekuStick2Byte.ToString() + Environment.NewLine);
                                    dekuStick = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DekuStick.Image = Image.FromFile(workingPath + "DekuStick - Gray.png");
                            });
                        }
                    }
                    //BOOMERANG
                    boomerang2Byte = MemLib.readByte(firstFourHexDigits + boomerang2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (boomerang2Byte == 14)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Boomerang.Image = Image.FromFile(workingPath + "Boomerang.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!boomerang)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Boomerang." + " Address: " + firstFourHexDigits + boomerang2ByteStr + " Value: " + boomerang2Byte.ToString() + Environment.NewLine);
                                    boomerang = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Boomerang.Image = Image.FromFile(workingPath + "Boomerang - Gray.png");
                            });
                        }
                    }
                    //SLINGSHOT
                    slingshot2Byte = MemLib.readByte(firstFourHexDigits + slingshot2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (slingshot2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Slingshot.Image = Image.FromFile(workingPath + "Fairy Slingshot.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!slingshot)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Slingshot." + " Address: " + firstFourHexDigits + slingshot2ByteStr + " Value: " + slingshot2Byte.ToString() + Environment.NewLine);
                                    slingshot = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Slingshot.Image = Image.FromFile(workingPath + "Fairy Slingshot - Gray.png");
                            });
                        }
                    }
                    //LENS OF TRUTH
                    lensOfTruth2Byte = MemLib.readByte(firstFourHexDigits + lensOfTruth2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (lensOfTruth2Byte == 15)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                LensOfTruth.Image = Image.FromFile(workingPath + "Lens of Truth.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!lensOfTruth)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Lens of Truth." + " Address: " + firstFourHexDigits + lensOfTruth2ByteStr + " Value: " + lensOfTruth2Byte.ToString() + Environment.NewLine);
                                    lensOfTruth = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                LensOfTruth.Image = Image.FromFile(workingPath + "Lens of Truth - Gray.png");
                            });
                        }
                    }
                    //FAIRY OCARINA and OCARINA OF TIME
                    ocarina2Byte = MemLib.readByte(firstFourHexDigits + ocarina2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (ocarina2Byte == 7)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Ocarina.Image = Image.FromFile(workingPath + "Fairy Ocarina.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ocarinaOne)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fairy Ocarina." + " Address: " + firstFourHexDigits + ocarina2ByteStr + " Value: " + ocarina2Byte.ToString() + Environment.NewLine);
                                    ocarinaOne = true;
                                }
                            });
                        }
                        else if (ocarina2Byte == 8)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Ocarina.Image = Image.FromFile(workingPath + "Ocarina of Time.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ocarinaTwo)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Ocarina of Time." + " Address: " + firstFourHexDigits + ocarina2ByteStr + " Value: " + ocarina2Byte.ToString() + Environment.NewLine);
                                    ocarinaTwo = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Ocarina.Image = Image.FromFile(workingPath + "Fairy Ocarina - Gray.png");
                            });
                        }
                    }
                    //DEKU NUTS (FIRST PICKUP)
                    dekuNuts2Byte = MemLib.readByte(firstFourHexDigits + dekuNuts2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (dekuNuts2Byte == 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DekuNuts.Image = Image.FromFile(workingPath + "Deku Nut.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!dekuNuts)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Nuts." + " Address: " + firstFourHexDigits + dekuNuts2ByteStr + " Value: " + dekuNuts2Byte.ToString() + Environment.NewLine);
                                    dekuNuts = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DekuNuts.Image = Image.FromFile(workingPath + "Deku Nut - Gray.png");
                            });
                        }
                    }
                    //MAGIC BEANS
                    magicBeans2Byte = MemLib.readByte(firstFourHexDigits + magicBeans2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (magicBeans2Byte == 16)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                MagicBean.Image = Image.FromFile(workingPath + "Magic Beans.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!magicBeans)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Magic Beans." + " Address: " + firstFourHexDigits + magicBeans2ByteStr + " Value: " + magicBeans2Byte.ToString() + Environment.NewLine);
                                    magicBeans = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                MagicBean.Image = Image.FromFile(workingPath + "Magic Beans - Gray.png");
                            });
                        }
                    }
                    //BOMBCHUS
                    bombchu2Byte = MemLib.readByte(firstFourHexDigits + bombchu2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (bombchu2Byte == 9)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Bombchu.Image = Image.FromFile(workingPath + "Bombchu.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bombchus)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bombchus." + " Address: " + firstFourHexDigits + bombchu2ByteStr + " Value: " + bombchu2Byte.ToString() + Environment.NewLine);
                                    bombchus = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Bombchu.Image = Image.FromFile(workingPath + "Bombchu - Gray.png");
                            });
                        }
                    }
                    //BOMBS (FIRST PICKUP WITH SMALLEST BOMB BAG)
                    bombs2Byte = MemLib.readByte(firstFourHexDigits + bombs2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (bombs2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Bombs.Image = Image.FromFile(workingPath + "Bomb.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bombs)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bombs." + " Address: " + firstFourHexDigits + bombs2ByteStr + " Value: " + bombs2Byte.ToString() + Environment.NewLine);
                                    bombs = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Bombs.Image = Image.FromFile(workingPath + "Bomb - Gray.png");
                            });
                        }
                    }
                    //MEGATON HAMMER
                    megatonHammer2Byte = MemLib.readByte(firstFourHexDigits + megatonHammer2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (megatonHammer2Byte == 17)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                MegatonHammer.Image = Image.FromFile(workingPath + "Megaton Hammer.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!megatonHammer)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Megaton Hammer." + " Address: " + firstFourHexDigits + megatonHammer2ByteStr + " Value: " + megatonHammer2Byte.ToString() + Environment.NewLine);
                                    megatonHammer = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                MegatonHammer.Image = Image.FromFile(workingPath + "Megaton Hammer - Gray.png");
                            });
                        }
                    }
                    //HOOKSHOT and LONGSHOT
                    hookshot2Byte = MemLib.readByte(firstFourHexDigits + hookshot2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (hookshot2Byte == 10)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Hookshot.Image = Image.FromFile(workingPath + "Hookshot.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!hookShotOne)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Hookshot." + " Address: " + firstFourHexDigits + hookshot2ByteStr + " Value: " + hookshot2Byte.ToString() + Environment.NewLine);
                                    hookShotOne = true;
                                }
                            });
                        }
                        else if (hookshot2Byte == 11)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Hookshot.Image = Image.FromFile(workingPath + "Longshot.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!hookShotTwo)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Longshot." + " Address: " + firstFourHexDigits + hookshot2ByteStr + " Value: " + hookshot2Byte.ToString() + Environment.NewLine);
                                    hookShotTwo = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Hookshot.Image = Image.FromFile(workingPath + "Hookshot - Gray.png");
                            });
                        }
                    }
                    //BOW
                    fairyBow2Byte = MemLib.readByte(firstFourHexDigits + fairyBow2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (fairyBow2Byte == 3)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Bow.Image = Image.FromFile(workingPath + "Fairy Bow.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bow)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bow." + " Address: " + firstFourHexDigits + fairyBow2ByteStr + " Value: " + fairyBow2Byte.ToString() + Environment.NewLine);
                                    bow = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Bow.Image = Image.FromFile(workingPath + "Fairy Bow - Gray.png");
                            });
                        }
                    }
                    //LIGHT ARROW
                    lightArrow2Byte = MemLib.readByte(firstFourHexDigits + lightArrow2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (lightArrow2Byte == 18)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                LightArrow.Image = Image.FromFile(workingPath + "Light Arrow.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!lightArrow)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Light Arrows." + " Address: " + firstFourHexDigits + lightArrow2ByteStr + " Value: " + lightArrow2Byte.ToString() + Environment.NewLine);
                                    lightArrow = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                LightArrow.Image = Image.FromFile(workingPath + "Light Arrow - Gray.png");
                            });
                        }
                    }
                    //ICE ARROW
                    iceArrow2Byte = MemLib.readByte(firstFourHexDigits + iceArrow2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (iceArrow2Byte == 12)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                IceArrow.Image = Image.FromFile(workingPath + "Ice Arrow.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!iceArrow)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Ice Arrows." + " Address: " + firstFourHexDigits + iceArrow2ByteStr + " Value: " + iceArrow2Byte.ToString() + Environment.NewLine);
                                    iceArrow = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                IceArrow.Image = Image.FromFile(workingPath + "Ice Arrow - Gray.png");
                            });
                        }
                    }
                    //FIRE ARROW
                    fireArrow2Byte = MemLib.readByte(firstFourHexDigits + fireArrow2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (fireArrow2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireArrow.Image = Image.FromFile(workingPath + "Fire Arrow.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!fireArrow)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Arrows." + " Address: " + firstFourHexDigits + fireArrow2ByteStr + " Value: " + fireArrow2Byte.ToString() + Environment.NewLine);
                                    fireArrow = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireArrow.Image = Image.FromFile(workingPath + "Fire Arrow - Gray.png");
                            });
                        }
                    }
                    //NAYRUS LOVE
                    nayru2Byte = MemLib.readByte(firstFourHexDigits + nayru2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (nayru2Byte == 19)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Nayru.Image = Image.FromFile(workingPath + "Nayru's Love.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!nayrusLove)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Nayru's Love." + " Address: " + firstFourHexDigits + nayru2ByteStr + " Value: " + nayru2Byte.ToString() + Environment.NewLine);
                                    nayrusLove = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Nayru.Image = Image.FromFile(workingPath + "Nayru's Love - Gray.png");
                            });
                        }
                    }
                    //FARORES WIND
                    farore2Byte = MemLib.readByte(firstFourHexDigits + farore2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (farore2Byte == 13)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Farore.Image = Image.FromFile(workingPath + "Farore's Wind.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!faroresWind)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Farore's Wind." + " Address: " + firstFourHexDigits + farore2ByteStr + " Value: " + farore2Byte.ToString() + Environment.NewLine);
                                    faroresWind = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Farore.Image = Image.FromFile(workingPath + "Farore's Wind - Gray.png");
                            });
                        }
                    }
                    //DINS FIRE
                    din2Byte = MemLib.readByte(firstFourHexDigits + din2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (din2Byte == 5)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Din.Image = Image.FromFile(workingPath + "Din's Fire.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!dinsFire)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Din's Fire." + " Address: " + firstFourHexDigits + din2ByteStr + " Value: " + din2Byte.ToString() + Environment.NewLine);
                                    dinsFire = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Din.Image = Image.FromFile(workingPath + "Din's Fire - Gray.png");
                            });
                        }
                    }
                    //ADULT TRADE
                    adult2Byte = MemLib.readByte(firstFourHexDigits + adult2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        adultTradeValue = adult2Byte;

                        if (adultTradeValue != adultTradeTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (adultTradeValue == adultTradeTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (adult2Byte == 45)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Weird Egg.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Pocket Egg." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (adult2Byte == 46)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Cucco.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Pocket Cucco." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (adult2Byte == 47)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Cojiro.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Cojiro." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (adult2Byte == 48)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Odd Mushroom.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Odd Mushroom." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (adult2Byte == 49)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Odd Potion.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Odd Potion." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (adult2Byte == 50)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Poacher's Saw.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Poacher's Saw." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (adult2Byte == 51)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Goron's Sword (Broken).png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Goron's Sword (Broken)." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (adult2Byte == 52)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Prescription.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Prescription." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (adult2Byte == 53)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Eyeball Frog.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Eyeball Frog." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (adult2Byte == 54)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Eyedrops.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Eyedrops." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (adult2Byte == 55)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Claim Check.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Claim Check." + " Address: " + firstFourHexDigits + adult2ByteStr + " Value: " + adult2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                AdultTrade.Image = Image.FromFile(workingPath + "Weird Egg - Gray.png");
                            });
                        }

                        adultTradeTempValue = adultTradeValue;
                    }
                    //CHILD TRADE
                    child2Byte = MemLib.readByte(firstFourHexDigits + child2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        childTradeValue = child2Byte;

                        if (childTradeValue != childTradeTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (childTradeValue == childTradeTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (child2Byte == 33)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Weird Egg - Two.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Weird Egg." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 34)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Cucco - Two.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Cucco." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 35)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Zelda's Letter.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Zelda's Letter." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 36)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Keaton Mask.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Keaton Mask." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 37)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Skull Mask.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Skull Mask." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 38)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Spooky Mask.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spooky Mask." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 39)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Bunny Hood.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bunny Hood." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 40)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Goron Mask.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Goron Mask." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 41)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Zora Mask.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Zora Mask." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 42)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Gerudo Mask.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Mask." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 43)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Mask of Truth.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Mask of Truth." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else if (child2Byte == 44)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Sold Out.png");
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Sold Out." + " Address: " + firstFourHexDigits + child2ByteStr + " Value: " + child2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ChildTrade.Image = Image.FromFile(workingPath + "Weird Egg - Gray.png");
                            });
                        }

                        childTradeTempValue = childTradeValue;
                    }
                    ////////////MAPS, COMPASSES, BIG KEYS, and SMALL KEYS//////////////
                    //DEKU TREE MAP AND COMPASS
                    //big key = 1, compass = 2, map = 4
                    deku2Byte = MemLib.readByte(firstFourHexDigits + deku2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (deku2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DekuMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!dekuCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Tree Compass." + " Address: " + firstFourHexDigits + deku2ByteStr + " Value: " + deku2Byte.ToString() + Environment.NewLine);
                                    dekuCompass = true;
                                }
                            });
                        }
                        else if (deku2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DekuMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!dekuMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Tree Map." + " Address: " + firstFourHexDigits + deku2ByteStr + " Value: " + deku2Byte.ToString() + Environment.NewLine);
                                    dekuMap = true;
                                }
                            });
                        }
                        else if (deku2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DekuMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!dekuMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Tree Map." + " Address: " + firstFourHexDigits + deku2ByteStr + " Value: " + deku2Byte.ToString() + Environment.NewLine);
                                    dekuMap = true;
                                }
                                if (!dekuCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Tree Compass." + " Address: " + firstFourHexDigits + deku2ByteStr + " Value: " + deku2Byte.ToString() + Environment.NewLine);
                                    dekuCompass = true;
                                }
                            });
                        }
                    }
                    //DODONGOS CAVERN MAP AND COMPASS
                    //big key = 1, compass = 2, map = 4
                    dodongo2Byte = MemLib.readByte(firstFourHexDigits + dodongo2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (dodongo2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DodongoMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!dcCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Dodongo's Cavern Compass." + " Address: " + firstFourHexDigits + dodongo2ByteStr + " Value: " + dodongo2Byte.ToString() + Environment.NewLine);
                                    dcCompass = true;
                                }
                            });
                        }
                        else if (dodongo2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DodongoMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!dcMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Dodongo's Cavern Map." + " Address: " + firstFourHexDigits + dodongo2ByteStr + " Value: " + dodongo2Byte.ToString() + Environment.NewLine);
                                    dcMap = true;
                                }
                            });
                        }
                        else if (dodongo2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DodongoMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!dcCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Dodongo's Cavern Compass." + " Address: " + firstFourHexDigits + dodongo2ByteStr + " Value: " + dodongo2Byte.ToString() + Environment.NewLine);
                                    dcCompass = true;
                                }
                                if (!dcMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Dodongo's Cavern Map." + " Address: " + firstFourHexDigits + dodongo2ByteStr + " Value: " + dodongo2Byte.ToString() + Environment.NewLine);
                                    dcMap = true;
                                }
                            });
                        }
                    }
                    //JABU JABU MAP AND COMPASS
                    //big key = 1, compass = 2, map = 4
                    jabu2Byte = MemLib.readByte(firstFourHexDigits + jabu2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (jabu2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                JabuMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!jabuCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + "Jabu Jabu's' Compass." + " Address: " + firstFourHexDigits + jabu2ByteStr + " Value: " + jabu2Byte.ToString() + Environment.NewLine);
                                    jabuCompass = true;
                                }
                            });
                        }
                        else if (jabu2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                JabuMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!jabuMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Jabu Jabu's Map." + " Address: " + firstFourHexDigits + jabu2ByteStr + " Value: " + jabu2Byte.ToString() + Environment.NewLine);
                                    jabuMap = true;
                                }
                            });
                        }
                        else if (jabu2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                JabuMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!jabuCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + "Jabu Jabu's' Compass." + " Address: " + firstFourHexDigits + jabu2ByteStr + " Value: " + jabu2Byte.ToString() + Environment.NewLine);
                                    jabuCompass = true;
                                }
                                if (!jabuMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Jabu Jabu's Map." + " Address: " + firstFourHexDigits + jabu2ByteStr + " Value: " + jabu2Byte.ToString() + Environment.NewLine);
                                    jabuMap = true;
                                }
                            });
                        }
                    }
                    //FOREST TEMPLE BIG KEY MAP AND COMPASS and SMALL KEYS
                    //big key = 1, compass = 2, map = 4
                    forest2Byte = MemLib.readByte(firstFourHexDigits + forest2ByteStr);
                    forestKey2Byte = MemLib.readByte(firstFourHexDigits + forestKey2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        forestKeyValue = forestKey2Byte;

                        if (forestKeyValue != forestKeyTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (forestKeyValue == forestKeyTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (forest2Byte == 0)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ForestMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
                            });
                            if (forestKey2Byte >= 1 && forestKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        if (forest2Byte == 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ForestMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
                            });
                            if (forestKey2Byte >= 1 && forestKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!forestBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Boss Key." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                        forestBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!forestBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Boss Key." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                        forestBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (forest2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ForestMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!forestCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Compass." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                    forestCompass = true;
                                }
                            });
                            if (forestKey2Byte >= 1 && forestKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (forest2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ForestMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!forestMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Map." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                    forestMap = true;
                                }
                            });
                            if (forestKey2Byte >= 1 && forestKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (forest2Byte == 3)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ForestMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!forestCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Compass." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                    forestCompass = true;
                                }
                            });
                            if (forestKey2Byte >= 1 && forestKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!forestBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Boss Key." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                        forestBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!forestBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Boss Key." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                        forestBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (forest2Byte == 5)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ForestMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!forestMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Map." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                    forestMap = true;
                                }
                            });
                            if (forestKey2Byte >= 1 && forestKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!forestBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Boss Key." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                        forestBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!forestBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Boss Key." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                        forestBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (forest2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ForestMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!forestCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Compass." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                    forestCompass = true;
                                }
                                if (!forestMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Map." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                    forestMap = true;
                                }
                            });
                            if (forestKey2Byte >= 1 && forestKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (forest2Byte == 7)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ForestMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!forestCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Compass." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                    forestCompass = true;
                                }
                                if (!forestMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Map." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                    forestMap = true;
                                }
                            });
                            if (forestKey2Byte >= 1 && forestKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!forestBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Boss Key." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                        forestBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!forestBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Boss Key." + " Address: " + firstFourHexDigits + forest2ByteStr + " Value: " + forest2Byte.ToString() + Environment.NewLine);
                                        forestBigKey = true;
                                    }
                                });
                            }
                        }
                        //SMALL KEY COUNT
                        if (forestKey2Byte >= 1 && forestKey2Byte != 255)
                        {
                            if (forestKey2Byte == 1)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestTempleKeyCount.Image = Image.FromFile(workingPath + "1block.png");
                                    ForestTempleKeyCount.Size = new Size(7, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Key - 1." + " Address: " + firstFourHexDigits + forestKey2ByteStr + " Value: " + forestKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (forestKey2Byte == 2)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestTempleKeyCount.Image = Image.FromFile(workingPath + "2block.png");
                                    ForestTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Key - 2." + " Address: " + firstFourHexDigits + forestKey2ByteStr + " Value: " + forestKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (forestKey2Byte == 3)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestTempleKeyCount.Image = Image.FromFile(workingPath + "3block.png");
                                    ForestTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Key - 3." + " Address: " + firstFourHexDigits + forestKey2ByteStr + " Value: " + forestKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (forestKey2Byte == 4)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestTempleKeyCount.Image = Image.FromFile(workingPath + "4block.png");
                                    ForestTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Key - 4." + " Address: " + firstFourHexDigits + forestKey2ByteStr + " Value: " + forestKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (forestKey2Byte == 5)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestTempleKeyCount.Image = Image.FromFile(workingPath + "5block.png");
                                    ForestTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Key - 5." + " Address: " + firstFourHexDigits + forestKey2ByteStr + " Value: " + forestKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (forestKey2Byte == 6)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestTempleKeyCount.Image = Image.FromFile(workingPath + "6block.png");
                                    ForestTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Key - 6." + " Address: " + firstFourHexDigits + forestKey2ByteStr + " Value: " + forestKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (forestKey2Byte == 7)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestTempleKeyCount.Image = Image.FromFile(workingPath + "7block.png");
                                    ForestTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Key - 7." + " Address: " + firstFourHexDigits + forestKey2ByteStr + " Value: " + forestKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (forestKey2Byte == 8)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestTempleKeyCount.Image = Image.FromFile(workingPath + "8block.png");
                                    ForestTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Key - 8." + " Address: " + firstFourHexDigits + forestKey2ByteStr + " Value: " + forestKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (forestKey2Byte == 9)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ForestTempleKeyCount.Image = Image.FromFile(workingPath + "9block.png");
                                    ForestTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Key - 9." + " Address: " + firstFourHexDigits + forestKey2ByteStr + " Value: " + forestKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ForestTempleKeyCount.Image = Image.FromFile(workingPath + "0block.png");
                                ForestTempleKeyCount.Size = new Size(12, 15);
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Forest Temple Key - 0." + " Address: " + firstFourHexDigits + forestKey2ByteStr + " Value: " + forestKey2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }

                        forestKeyTempValue = forestKeyValue;
                    }
                    //FIRE TEMPLE BIG KEY MAP AND COMPASS
                    //big key = 1, compass = 2, map = 4
                    fire2Byte = MemLib.readByte(firstFourHexDigits + fire2ByteStr);
                    fireKey2Byte = MemLib.readByte(firstFourHexDigits + fireKey2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        fireKeysValue = fireKey2Byte;

                        if (fireKeysValue != fireKeysTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (fireKeysValue == fireKeysTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (fire2Byte == 0)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
                            });
                            if (fireKey2Byte >= 1 && fireKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        if (fire2Byte == 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
                            });
                            if (fireKey2Byte >= 1 && fireKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!fireBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Boss Key." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                        fireBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!fireBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Boss Key." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                        fireBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (fire2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!fireCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Compass." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                    fireCompass = true;
                                }
                            });
                            if (fireKey2Byte >= 1 && fireKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (fire2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!fireMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Map." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                    fireMap = true;
                                }
                            });
                            if (fireKey2Byte >= 1 && fireKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (fire2Byte == 3)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!fireCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Compass." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                    fireCompass = true;
                                }
                            });
                            if (fireKey2Byte >= 1 && fireKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!fireBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Boss Key." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                        fireBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!fireBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Boss Key." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                        fireBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (fire2Byte == 5)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!fireMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Map." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                    fireMap = true;
                                }
                            });
                            if (fireKey2Byte >= 1 && fireKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!fireBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Boss Key." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                        fireBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!fireBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Boss Key." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                        fireBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (fire2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!fireCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Compass." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                    fireCompass = true;
                                }
                                if (!fireMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Map." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                    fireMap = true;
                                }
                            });
                            if (fireKey2Byte >= 1 && fireKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (fire2Byte == 7)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!fireCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Compass." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                    fireCompass = true;
                                }
                                if (!fireMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Map." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                    fireMap = true;
                                }
                            });
                            if (fireKey2Byte >= 1 && fireKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!fireBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Boss Key." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                        fireBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!fireBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Boss Key." + " Address: " + firstFourHexDigits + fire2ByteStr + " Value: " + fire2Byte.ToString() + Environment.NewLine);
                                        fireBigKey = true;
                                    }
                                });
                            }
                        }
                        if (fireKey2Byte >= 1 && fireKey2Byte != 255)
                        {
                            if (fireKey2Byte == 1)
                            {
                                Invoke((MethodInvoker)delegate
                                    {
                                        FireTempleKeyCount.Image = Image.FromFile(workingPath + "1block.png");
                                        FireTempleKeyCount.Size = new Size(7, 15);
                                        if (!hasWritten)
                                        {
                                            File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Key - 1." + " Address: " + firstFourHexDigits + fireKey2ByteStr + " Value: " + fireKey2Byte.ToString() + Environment.NewLine);
                                            hasWritten = true;
                                        }
                                    });
                            }
                            else if (fireKey2Byte == 2)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireTempleKeyCount.Image = Image.FromFile(workingPath + "2block.png");
                                    FireTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Key - 2." + " Address: " + firstFourHexDigits + fireKey2ByteStr + " Value: " + fireKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (fireKey2Byte == 3)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireTempleKeyCount.Image = Image.FromFile(workingPath + "3block.png");
                                    FireTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Key - 3." + " Address: " + firstFourHexDigits + fireKey2ByteStr + " Value: " + fireKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (fireKey2Byte == 4)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireTempleKeyCount.Image = Image.FromFile(workingPath + "4block.png");
                                    FireTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Key - 4." + " Address: " + firstFourHexDigits + fireKey2ByteStr + " Value: " + fireKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (fireKey2Byte == 5)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireTempleKeyCount.Image = Image.FromFile(workingPath + "5block.png");
                                    FireTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Key - 5." + " Address: " + firstFourHexDigits + fireKey2ByteStr + " Value: " + fireKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (fireKey2Byte == 6)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireTempleKeyCount.Image = Image.FromFile(workingPath + "6block.png");
                                    FireTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Key - 6." + " Address: " + firstFourHexDigits + fireKey2ByteStr + " Value: " + fireKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (fireKey2Byte == 7)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireTempleKeyCount.Image = Image.FromFile(workingPath + "7block.png");
                                    FireTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Key - 7." + " Address: " + firstFourHexDigits + fireKey2ByteStr + " Value: " + fireKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (fireKey2Byte == 8)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireTempleKeyCount.Image = Image.FromFile(workingPath + "8block.png");
                                    FireTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Key - 8." + " Address: " + firstFourHexDigits + fireKey2ByteStr + " Value: " + fireKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (fireKey2Byte == 9)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    FireTempleKeyCount.Image = Image.FromFile(workingPath + "9block.png");
                                    FireTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Key - 9." + " Address: " + firstFourHexDigits + fireKey2ByteStr + " Value: " + fireKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireTempleKeyCount.Image = Image.FromFile(workingPath + "0block.png");
                                FireTempleKeyCount.Size = new Size(12, 15);
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Temple Key - 0." + " Address: " + firstFourHexDigits + fireKey2ByteStr + " Value: " + fireKey2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }

                        fireKeysTempValue = fireKeysValue;
                    }
                    //WATER TEMPLE BIG KEY MAP AND COMPASS
                    //big key = 1, compass = 2, map = 4
                    water2Byte = MemLib.readByte(firstFourHexDigits + water2ByteStr);
                    waterKey2Byte = MemLib.readByte(firstFourHexDigits + waterKey2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        waterKeysValue = waterKey2Byte;

                        if (waterKeysValue != waterKeysTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (waterKeysValue == waterKeysTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (water2Byte == 0)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                WaterMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
                            });
                            if (waterKey2Byte >= 1 && waterKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        if (water2Byte == 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                WaterMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
                            });
                            if (waterKey2Byte >= 1 && waterKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!waterBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Boss Key." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                        waterBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!waterBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Boss Key." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                        waterBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (water2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                WaterMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!waterCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Compass." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                    waterCompass = true;
                                }
                            });
                            if (waterKey2Byte >= 1 && waterKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (water2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                WaterMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!waterMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Map." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                    waterMap = true;
                                }
                            });
                            if (waterKey2Byte >= 1 && waterKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (water2Byte == 3)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                WaterMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!waterCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Compass." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                    waterCompass = true;
                                }
                            });
                            if (waterKey2Byte >= 1 && waterKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!waterBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Boss Key." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                        waterBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!waterBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Boss Key." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                        waterBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (water2Byte == 5)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                WaterMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!waterMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Map." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                    waterMap = true;
                                }
                            });
                            if (waterKey2Byte >= 1 && waterKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!waterBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Boss Key." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                        waterBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!waterBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Boss Key." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                        waterBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (water2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                WaterMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!waterCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Compass." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                    waterCompass = true;
                                }
                                if (!waterMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Map." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                    waterMap = true;
                                }
                            });
                            if (waterKey2Byte >= 1 && waterKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (water2Byte == 7)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                WaterMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!waterCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Compass." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                    waterCompass = true;
                                }
                                if (!waterMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Map." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                    waterMap = true;
                                }
                            });
                            if (waterKey2Byte >= 1 && waterKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!waterBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Boss Key." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                        waterBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!waterBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Boss Key." + " Address: " + firstFourHexDigits + water2ByteStr + " Value: " + water2Byte.ToString() + Environment.NewLine);
                                        waterBigKey = true;
                                    }
                                });
                            }
                        }
                        if (waterKey2Byte >= 1 && waterKey2Byte != 255)
                        {
                            if (waterKey2Byte == 1)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterTempleKeyCount.Image = Image.FromFile(workingPath + "1block.png");
                                    WaterTempleKeyCount.Size = new Size(7, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Key - 1." + " Address: " + firstFourHexDigits + waterKey2ByteStr + " Value: " + waterKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }

                                });
                            }
                            else if (waterKey2Byte == 2)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterTempleKeyCount.Image = Image.FromFile(workingPath + "2block.png");
                                    WaterTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Key - 2." + " Address: " + firstFourHexDigits + waterKey2ByteStr + " Value: " + waterKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (waterKey2Byte == 3)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterTempleKeyCount.Image = Image.FromFile(workingPath + "3block.png");
                                    WaterTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Key - 3." + " Address: " + firstFourHexDigits + waterKey2ByteStr + " Value: " + waterKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (waterKey2Byte == 4)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterTempleKeyCount.Image = Image.FromFile(workingPath + "4block.png");
                                    WaterTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Key - 4." + " Address: " + firstFourHexDigits + waterKey2ByteStr + " Value: " + waterKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (waterKey2Byte == 5)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterTempleKeyCount.Image = Image.FromFile(workingPath + "5block.png");
                                    WaterTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Key - 5." + " Address: " + firstFourHexDigits + waterKey2ByteStr + " Value: " + waterKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (waterKey2Byte == 6)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterTempleKeyCount.Image = Image.FromFile(workingPath + "6block.png");
                                    WaterTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Key - 6." + " Address: " + firstFourHexDigits + waterKey2ByteStr + " Value: " + waterKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (waterKey2Byte == 7)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterTempleKeyCount.Image = Image.FromFile(workingPath + "7block.png");
                                    WaterTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Key - 7." + " Address: " + firstFourHexDigits + waterKey2ByteStr + " Value: " + waterKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (waterKey2Byte == 8)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterTempleKeyCount.Image = Image.FromFile(workingPath + "8block.png");
                                    WaterTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Key - 8." + " Address: " + firstFourHexDigits + waterKey2ByteStr + " Value: " + waterKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (waterKey2Byte == 9)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    WaterTempleKeyCount.Image = Image.FromFile(workingPath + "9block.png");
                                    WaterTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Key - 9." + " Address: " + firstFourHexDigits + waterKey2ByteStr + " Value: " + waterKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                WaterTempleKeyCount.Image = Image.FromFile(workingPath + "0block.png");
                                WaterTempleKeyCount.Size = new Size(12, 15);
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Water Temple Key - 0." + " Address: " + firstFourHexDigits + waterKey2ByteStr + " Value: " + waterKey2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }

                        waterKeysTempValue = waterKeysValue;
                    }
                    //SPIRIT TEMPLE BIG KEY MAP AND COMPASS
                    //big key = 1, compass = 2, map = 4
                    spirit2Byte = MemLib.readByte(firstFourHexDigits + spirit2ByteStr);
                    spiritKey2Byte = MemLib.readByte(firstFourHexDigits + spiritKey2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        spiritKeysValue = spiritKey2Byte;

                        if (spiritKeysValue != spiritKeysTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (spiritKeysValue == spiritKeysTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (spirit2Byte == 0)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SpiritMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
                            });
                            if (spiritKey2Byte >= 1 && spiritKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        if (spirit2Byte == 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SpiritMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
                            });
                            if (spiritKey2Byte >= 1 && spiritKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!spiritBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Boss Key." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                        spiritBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!spiritBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Boss Key." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                        spiritBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (spirit2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SpiritMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!spiritCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Compass." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                    spiritCompass = true;
                                }
                            });
                            if (spiritKey2Byte >= 1 && spiritKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (spirit2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SpiritMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!spiritMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Map." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                    spiritMap = true;
                                }
                            });
                            if (spiritKey2Byte >= 1 && spiritKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (spirit2Byte == 3)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SpiritMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!spiritCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Compass." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                    spiritCompass = true;
                                }
                            });
                            if (spiritKey2Byte >= 1 && spiritKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!spiritBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Boss Key." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                        spiritBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!spiritBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Boss Key." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                        spiritBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (spirit2Byte == 5)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SpiritMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!spiritMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Map." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                    spiritMap = true;
                                }
                            });
                            if (spiritKey2Byte >= 1 && spiritKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!spiritBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Boss Key." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                        spiritBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!spiritBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Boss Key." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                        spiritBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (spirit2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SpiritMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!spiritCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Compass." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                    spiritCompass = true;
                                }
                                if (!spiritMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Map." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                    spiritMap = true;
                                }
                            });
                            if (spiritKey2Byte >= 1 && spiritKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (spirit2Byte == 7)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SpiritMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!spiritCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Compass." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                    spiritCompass = true;
                                }
                                if (!spiritMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Map." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                    spiritMap = true;
                                }
                            });
                            if (spiritKey2Byte >= 1 && spiritKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!spiritBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Boss Key." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                        spiritBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!spiritBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Boss Key." + " Address: " + firstFourHexDigits + spirit2ByteStr + " Value: " + spirit2Byte.ToString() + Environment.NewLine);
                                        spiritBigKey = true;
                                    }
                                });
                            }
                        }
                        if (spiritKey2Byte >= 1 && spiritKey2Byte != 255)
                        {
                            if (spiritKey2Byte == 1)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "1block.png");
                                    SpiritTempleKeyCount.Size = new Size(7, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Key - 1." + " Address: " + firstFourHexDigits + spiritKey2ByteStr + " Value: " + spiritKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (spiritKey2Byte == 2)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "2block.png");
                                    SpiritTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Key - 2." + " Address: " + firstFourHexDigits + spiritKey2ByteStr + " Value: " + spiritKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (spiritKey2Byte == 3)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "3block.png");
                                    SpiritTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Key - 3." + " Address: " + firstFourHexDigits + spiritKey2ByteStr + " Value: " + spiritKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (spiritKey2Byte == 4)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "4block.png");
                                    SpiritTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Key - 4." + " Address: " + firstFourHexDigits + spiritKey2ByteStr + " Value: " + spiritKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (spiritKey2Byte == 5)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "5block.png");
                                    SpiritTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Key - 5." + " Address: " + firstFourHexDigits + spiritKey2ByteStr + " Value: " + spiritKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (spiritKey2Byte == 6)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "6block.png");
                                    SpiritTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Key - 6." + " Address: " + firstFourHexDigits + spiritKey2ByteStr + " Value: " + spiritKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (spiritKey2Byte == 7)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "7block.png");
                                    SpiritTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Key - 7." + " Address: " + firstFourHexDigits + spiritKey2ByteStr + " Value: " + spiritKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (spiritKey2Byte == 8)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "8block.png");
                                    SpiritTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Key - 8." + " Address: " + firstFourHexDigits + spiritKey2ByteStr + " Value: " + spiritKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (spiritKey2Byte == 9)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "9block.png");
                                    SpiritTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Key - 9." + " Address: " + firstFourHexDigits + spiritKey2ByteStr + " Value: " + spiritKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "0block.png");
                                SpiritTempleKeyCount.Size = new Size(12, 15);
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spirit Temple Key - 0." + " Address: " + firstFourHexDigits + spiritKey2ByteStr + " Value: " + spiritKey2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }

                        spiritKeysTempValue = spiritKeysValue;
                    }
                    //SHADOW TEMPLE BIG KEY MAP AND COMPASS
                    //big key = 1, compass = 2, map = 4
                    shadow2Byte = MemLib.readByte(firstFourHexDigits + shadow2ByteStr);
                    shadowKey2Byte = MemLib.readByte(firstFourHexDigits + shadowKey2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);


                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        shadowKeysValue = shadowKey2Byte;

                        if (shadowKeysValue != shadowKeysTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (shadowKeysValue == shadowKeysTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (shadow2Byte == 0)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShadowMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
                            });
                            if (shadowKey2Byte >= 1 && shadowKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        if (shadow2Byte == 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShadowMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
                            });
                            if (shadowKey2Byte >= 1 && shadowKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!shadowBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Boss Key." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                        shadowBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!shadowBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Boss Key." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                        shadowBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (shadow2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShadowMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!shadowCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Compass." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                    shadowCompass = true;
                                }
                            });
                            if (shadowKey2Byte >= 1 && shadowKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (shadow2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShadowMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!shadowMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Map." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                    shadowMap = true;
                                }
                            });
                            if (shadowKey2Byte >= 1 && shadowKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (shadow2Byte == 3)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShadowMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!shadowCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Compass." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                    shadowCompass = true;
                                }
                            });
                            if (shadowKey2Byte >= 1 && shadowKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!shadowBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Boss Key." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                        shadowBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!shadowBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Boss Key." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                        shadowBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (shadow2Byte == 5)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShadowMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!shadowMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Map." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                    shadowMap = true;
                                }
                            });
                            if (shadowKey2Byte >= 1 && shadowKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!shadowBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Boss Key." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                        shadowBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!shadowBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Boss Key." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                        shadowBigKey = true;
                                    }
                                });
                            }
                        }
                        else if (shadow2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShadowMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!shadowCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Compass." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                    shadowCompass = true;
                                }
                                if (!shadowMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Map." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                    shadowMap = true;
                                }
                            });
                            if (shadowKey2Byte >= 1 && shadowKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                        }
                        else if (shadow2Byte == 7)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShadowMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!shadowCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Compass." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                    shadowCompass = true;
                                }
                                if (!shadowMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Map." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                    shadowMap = true;
                                }
                            });
                            if (shadowKey2Byte >= 1 && shadowKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!shadowBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Boss Key." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                        shadowBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!shadowBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Boss Key." + " Address: " + firstFourHexDigits + shadow2ByteStr + " Value: " + shadow2Byte.ToString() + Environment.NewLine);
                                        shadowBigKey = true;
                                    }
                                });
                            }
                        }
                        if (shadowKey2Byte >= 1 && shadowKey2Byte != 255)
                        {
                            if (shadowKey2Byte == 1)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "1block.png");
                                    ShadowTempleKeyCount.Size = new Size(7, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Key - 1." + " Address: " + firstFourHexDigits + shadowKey2ByteStr + " Value: " + shadowKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (shadowKey2Byte == 2)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "2block.png");
                                    ShadowTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Key - 2." + " Address: " + firstFourHexDigits + shadowKey2ByteStr + " Value: " + shadowKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (shadowKey2Byte == 3)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "3block.png");
                                    ShadowTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Key - 3." + " Address: " + firstFourHexDigits + shadowKey2ByteStr + " Value: " + shadowKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (shadowKey2Byte == 4)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "4block.png");
                                    ShadowTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Key - 4." + " Address: " + firstFourHexDigits + shadowKey2ByteStr + " Value: " + shadowKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (shadowKey2Byte == 5)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "5block.png");
                                    ShadowTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Key - 5." + " Address: " + firstFourHexDigits + shadowKey2ByteStr + " Value: " + shadowKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (shadowKey2Byte == 6)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "6block.png");
                                    ShadowTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Key - 6." + " Address: " + firstFourHexDigits + shadowKey2ByteStr + " Value: " + shadowKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (shadowKey2Byte == 7)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "7block.png");
                                    ShadowTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Key - 7." + " Address: " + firstFourHexDigits + shadowKey2ByteStr + " Value: " + shadowKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (shadowKey2Byte == 8)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "8block.png");
                                    ShadowTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Key - 8." + " Address: " + firstFourHexDigits + shadowKey2ByteStr + " Value: " + shadowKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (shadowKey2Byte == 9)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "9block.png");
                                    ShadowTempleKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Key - 9." + " Address: " + firstFourHexDigits + shadowKey2ByteStr + " Value: " + shadowKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "0block.png");
                                ShadowTempleKeyCount.Size = new Size(12, 15);
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Shadow Temple Key - 0." + " Address: " + firstFourHexDigits + shadowKey2ByteStr + " Value: " + shadowKey2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }

                        shadowKeysTempValue = shadowKeysValue;
                    }
                    //ICE CAVERN MAP AND COMPASS
                    //big key = 1, compass = 2, map = 4
                    iceCavern2Byte = MemLib.readByte(firstFourHexDigits + iceCavern2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (iceCavern2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                IceMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!iceCavernCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Ice Cavern Compass." + " Address: " + firstFourHexDigits + iceCavern2ByteStr + " Value: " + iceCavern2Byte.ToString() + Environment.NewLine);
                                    iceCavernCompass = true;
                                }
                            });
                        }
                        else if (iceCavern2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                IceMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!iceCavernMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Ice Cavern Map." + " Address: " + firstFourHexDigits + iceCavern2ByteStr + " Value: " + iceCavern2Byte.ToString() + Environment.NewLine);
                                    iceCavernMap = true;
                                }
                            });
                        }
                        else if (iceCavern2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                IceMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!iceCavernCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Ice Cavern Compass." + " Address: " + firstFourHexDigits + iceCavern2ByteStr + " Value: " + iceCavern2Byte.ToString() + Environment.NewLine);
                                    iceCavernCompass = true;
                                }
                                if (!iceCavernMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Ice Cavern Map." + " Address: " + firstFourHexDigits + iceCavern2ByteStr + " Value: " + iceCavern2Byte.ToString() + Environment.NewLine);
                                    iceCavernMap = true;
                                }
                            });
                        }
                    }
                    //BOTTOM OF THE WELL MAP AND COMPASS
                    //big key = 1, compass = 2, map = 4
                    BOTW2Byte = MemLib.readByte(firstFourHexDigits + BOTW2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (BOTW2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BOTWMapCompass.Image = Image.FromFile(workingPath + "camd.png");
                                if (!botwCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Compass." + " Address: " + firstFourHexDigits + BOTW2ByteStr + " Value: " + BOTW2Byte.ToString() + Environment.NewLine);
                                    botwCompass = true;
                                }
                            });
                        }
                        else if (BOTW2Byte == 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BOTWMapCompass.Image = Image.FromFile(workingPath + "cdma.png");
                                if (!botwMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Map." + " Address: " + firstFourHexDigits + BOTW2ByteStr + " Value: " + BOTW2Byte.ToString() + Environment.NewLine);
                                    botwMap = true;
                                }
                            });
                        }
                        else if (BOTW2Byte == 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BOTWMapCompass.Image = Image.FromFile(workingPath + "cama.png");
                                if (!botwCompass)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Compass." + " Address: " + firstFourHexDigits + BOTW2ByteStr + " Value: " + BOTW2Byte.ToString() + Environment.NewLine);
                                    botwCompass = true;
                                }
                                if (!botwMap)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Map." + " Address: " + firstFourHexDigits + BOTW2ByteStr + " Value: " + BOTW2Byte.ToString() + Environment.NewLine);
                                    botwMap = true;
                                }
                            });
                        }
                    }
                    //BOTTOM OF THE WELL SMALL KEYS
                    BOTWKey2Byte = MemLib.readByte(firstFourHexDigits + BOTWKey2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        botwKeysValue = BOTWKey2Byte;

                        if (botwKeysValue != botwKeysTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (botwKeysValue == botwKeysTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (BOTWKey2Byte >= 1 && BOTWKey2Byte != 255)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BOTWSmallKey.Image = Image.FromFile(workingPath + "Small Key.png");
                            });
                            if (BOTWKey2Byte == 1)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BOTWKeyCount.Image = Image.FromFile(workingPath + "1block.png");
                                    BOTWKeyCount.Size = new Size(7, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Key - 1." + " Address: " + firstFourHexDigits + BOTWKey2ByteStr + " Value: " + BOTWKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (BOTWKey2Byte == 2)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BOTWKeyCount.Image = Image.FromFile(workingPath + "2block.png");
                                    BOTWKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Key - 2." + " Address: " + firstFourHexDigits + BOTWKey2ByteStr + " Value: " + BOTWKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (BOTWKey2Byte == 3)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BOTWKeyCount.Image = Image.FromFile(workingPath + "3block.png");
                                    BOTWKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Key - 3." + " Address: " + firstFourHexDigits + BOTWKey2ByteStr + " Value: " + BOTWKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (BOTWKey2Byte == 4)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BOTWKeyCount.Image = Image.FromFile(workingPath + "4block.png");
                                    BOTWKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Key - 4." + " Address: " + firstFourHexDigits + BOTWKey2ByteStr + " Value: " + BOTWKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (BOTWKey2Byte == 5)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BOTWKeyCount.Image = Image.FromFile(workingPath + "5block.png");
                                    BOTWKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Key - 5." + " Address: " + firstFourHexDigits + BOTWKey2ByteStr + " Value: " + BOTWKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (BOTWKey2Byte == 6)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BOTWKeyCount.Image = Image.FromFile(workingPath + "6block.png");
                                    BOTWKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Key - 6." + " Address: " + firstFourHexDigits + BOTWKey2ByteStr + " Value: " + BOTWKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (BOTWKey2Byte == 7)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BOTWKeyCount.Image = Image.FromFile(workingPath + "7block.png");
                                    BOTWKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Key - 7." + " Address: " + firstFourHexDigits + BOTWKey2ByteStr + " Value: " + BOTWKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (BOTWKey2Byte == 8)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BOTWKeyCount.Image = Image.FromFile(workingPath + "8block.png");
                                    BOTWKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Key - 8." + " Address: " + firstFourHexDigits + BOTWKey2ByteStr + " Value: " + BOTWKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (BOTWKey2Byte == 9)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    BOTWKeyCount.Image = Image.FromFile(workingPath + "9block.png");
                                    BOTWKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Key - 9." + " Address: " + firstFourHexDigits + BOTWKey2ByteStr + " Value: " + BOTWKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BOTWSmallKey.Image = Image.FromFile(workingPath + "Small Key - Gray.png");
                            });
                            Invoke((MethodInvoker)delegate
                            {
                                BOTWKeyCount.Image = Image.FromFile(workingPath + "0block.png");
                                BOTWKeyCount.Size = new Size(12, 15);
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bottom of the Well Key - 0." + " Address: " + firstFourHexDigits + BOTWKey2ByteStr + " Value: " + BOTWKey2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }

                        botwKeysTempValue = botwKeysValue;
                    }
                    //GERUDO TRAINING GROUND SMALL KEYS
                    gerudoTrainingGround2Byte = MemLib.readByte(firstFourHexDigits + gerudoTrainingGround2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        gtgKeysValue = gerudoTrainingGround2Byte;

                        if (gtgKeysValue != gtgKeysTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (gtgKeysValue == gtgKeysTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (gerudoTrainingGround2Byte >= 1 && gerudoTrainingGround2Byte != 255)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                GerudoTrainingGround.Image = Image.FromFile(workingPath + "Small Key.png");
                            });
                            if (gerudoTrainingGround2Byte == 1)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "1block.png");
                                    GerudoTrainingGroundKeyCount.Size = new Size(7, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Training Ground Key - 1." + " Address: " + firstFourHexDigits + gerudoTrainingGround2ByteStr + " Value: " + gerudoTrainingGround2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoTrainingGround2Byte == 2)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "2block.png");
                                    GerudoTrainingGroundKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Training Ground Key - 2." + " Address: " + firstFourHexDigits + gerudoTrainingGround2ByteStr + " Value: " + gerudoTrainingGround2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoTrainingGround2Byte == 3)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "3block.png");
                                    GerudoTrainingGroundKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Training Ground Key - 3." + " Address: " + firstFourHexDigits + gerudoTrainingGround2ByteStr + " Value: " + gerudoTrainingGround2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoTrainingGround2Byte == 4)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "4block.png");
                                    GerudoTrainingGroundKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Training Ground Key - 4." + " Address: " + firstFourHexDigits + gerudoTrainingGround2ByteStr + " Value: " + gerudoTrainingGround2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoTrainingGround2Byte == 5)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "5block.png");
                                    GerudoTrainingGroundKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Training Ground Key - 5." + " Address: " + firstFourHexDigits + gerudoTrainingGround2ByteStr + " Value: " + gerudoTrainingGround2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoTrainingGround2Byte == 6)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "6block.png");
                                    GerudoTrainingGroundKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Training Ground Key - 6." + " Address: " + firstFourHexDigits + gerudoTrainingGround2ByteStr + " Value: " + gerudoTrainingGround2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoTrainingGround2Byte == 7)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "7block.png");
                                    GerudoTrainingGroundKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Training Ground Key - 7." + " Address: " + firstFourHexDigits + gerudoTrainingGround2ByteStr + " Value: " + gerudoTrainingGround2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoTrainingGround2Byte == 8)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "8block.png");
                                    GerudoTrainingGroundKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Training Ground Key - 8." + " Address: " + firstFourHexDigits + gerudoTrainingGround2ByteStr + " Value: " + gerudoTrainingGround2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoTrainingGround2Byte == 9)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "9block.png");
                                    GerudoTrainingGroundKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Training Ground Key - 9." + " Address: " + firstFourHexDigits + gerudoTrainingGround2ByteStr + " Value: " + gerudoTrainingGround2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                GerudoTrainingGround.Image = Image.FromFile(workingPath + "Small Key - Gray.png");
                            });
                            Invoke((MethodInvoker)delegate
                            {
                                GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "0block.png");
                                GerudoTrainingGroundKeyCount.Size = new Size(12, 15);
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Training Ground Key - 0." + " Address: " + firstFourHexDigits + gerudoTrainingGround2ByteStr + " Value: " + gerudoTrainingGround2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }

                        gtgKeysTempValue = gtgKeysValue;
                    }
                    //GERUDO TRAINING GROUND SMALL KEYS
                    gerudoFortress2Byte = MemLib.readByte(firstFourHexDigits + gerudoFortress2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        fortressKeysValue = gerudoFortress2Byte;

                        if (fortressKeysValue != fortressKeysTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (fortressKeysValue == fortressKeysTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (gerudoFortress2Byte >= 1 && gerudoFortress2Byte != 255)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                GerudoFortress.Image = Image.FromFile(workingPath + "Small Key.png");
                            });
                            if (gerudoFortress2Byte == 1)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "1block.png");
                                    GerudoFortressKeyCount.Size = new Size(7, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Fortress Key - 1." + " Address: " + firstFourHexDigits + gerudoFortress2ByteStr + " Value: " + gerudoFortress2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoFortress2Byte == 2)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "2block.png");
                                    GerudoFortressKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Fortress Key - 2." + " Address: " + firstFourHexDigits + gerudoFortress2ByteStr + " Value: " + gerudoFortress2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoFortress2Byte == 3)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "3block.png");
                                    GerudoFortressKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Fortress Key - 3." + " Address: " + firstFourHexDigits + gerudoFortress2ByteStr + " Value: " + gerudoFortress2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoFortress2Byte == 4)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "4block.png");
                                    GerudoFortressKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Fortress Key - 4." + " Address: " + firstFourHexDigits + gerudoFortress2ByteStr + " Value: " + gerudoFortress2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoFortress2Byte == 5)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "5block.png");
                                    GerudoFortressKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Fortress Key - 5." + " Address: " + firstFourHexDigits + gerudoFortress2ByteStr + " Value: " + gerudoFortress2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoFortress2Byte == 6)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "6block.png");
                                    GerudoFortressKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Fortress Key - 6." + " Address: " + firstFourHexDigits + gerudoFortress2ByteStr + " Value: " + gerudoFortress2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoFortress2Byte == 7)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "7block.png");
                                    GerudoFortressKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Fortress Key - 7." + " Address: " + firstFourHexDigits + gerudoFortress2ByteStr + " Value: " + gerudoFortress2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoFortress2Byte == 8)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "8block.png");
                                    GerudoFortressKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Fortress Key - 8." + " Address: " + firstFourHexDigits + gerudoFortress2ByteStr + " Value: " + gerudoFortress2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (gerudoFortress2Byte == 9)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "9block.png");
                                    GerudoFortressKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Fortress Key - 9." + " Address: " + firstFourHexDigits + gerudoFortress2ByteStr + " Value: " + gerudoFortress2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                GerudoFortress.Image = Image.FromFile(workingPath + "Small Key - Gray.png");
                            });
                            Invoke((MethodInvoker)delegate
                            {
                                GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "0block.png");
                                GerudoFortressKeyCount.Size = new Size(12, 15);
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Fortress Key - 0." + " Address: " + firstFourHexDigits + gerudoFortress2ByteStr + " Value: " + gerudoFortress2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }

                        fortressKeysTempValue = fortressKeysValue;
                    }
                    //GANONS CASTLE BIG KEY
                    //big key = 1, compass = 2, map = 4
                    ganonsCastleBig2Byte = MemLib.readByte(firstFourHexDigits + ganonsCastleBig2ByteStr);
                    ganonsCastleKey2Byte = MemLib.readByte(firstFourHexDigits + ganonsCastleKey2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        ganonKeysValue = ganonsCastleKey2Byte;

                        if (ganonKeysValue != ganonKeysTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (ganonKeysValue == ganonKeysTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (ganonsCastleBig2Byte == 0)
                        {
                            if (ganonsCastleKey2Byte < 1 && ganonsCastleKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonBigSmallKey.Image = Image.FromFile(workingPath + "bdsa.png");
                                });
                            }
                        }
                        else if (ganonsCastleBig2Byte == 1)
                        {
                            if (ganonsCastleKey2Byte < 1 && ganonsCastleKey2Byte != 255)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonBigSmallKey.Image = Image.FromFile(workingPath + "basd.png");
                                    if (!ganonBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Boss Key." + " Address: " + firstFourHexDigits + ganonsCastleBig2ByteStr + " Value: " + ganonsCastleBig2Byte.ToString() + Environment.NewLine);
                                        ganonBigKey = true;
                                    }
                                });
                            }
                            else
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonBigSmallKey.Image = Image.FromFile(workingPath + "basa.png");
                                    if (!ganonBigKey)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Boss Key." + " Address: " + firstFourHexDigits + ganonsCastleBig2ByteStr + " Value: " + ganonsCastleBig2Byte.ToString() + Environment.NewLine);
                                        ganonBigKey = true;
                                    }
                                });
                            }
                        }
                        if (ganonsCastleKey2Byte >= 1 && ganonsCastleKey2Byte != 255)
                        {
                            if (ganonsCastleKey2Byte == 1)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "1block.png");
                                    GanonsCastleSmallKeyCount.Size = new Size(7, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Key - 1." + " Address: " + firstFourHexDigits + ganonsCastleKey2ByteStr + " Value: " + ganonsCastleKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (ganonsCastleKey2Byte == 2)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "2block.png");
                                    GanonsCastleSmallKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Key - 2." + " Address: " + firstFourHexDigits + ganonsCastleKey2ByteStr + " Value: " + ganonsCastleKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (ganonsCastleKey2Byte == 3)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "3block.png");
                                    GanonsCastleSmallKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Key - 3." + " Address: " + firstFourHexDigits + ganonsCastleKey2ByteStr + " Value: " + ganonsCastleKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (ganonsCastleKey2Byte == 4)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "4block.png");
                                    GanonsCastleSmallKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Key - 4." + " Address: " + firstFourHexDigits + ganonsCastleKey2ByteStr + " Value: " + ganonsCastleKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (ganonsCastleKey2Byte == 5)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "5block.png");
                                    GanonsCastleSmallKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Key - 5." + " Address: " + firstFourHexDigits + ganonsCastleKey2ByteStr + " Value: " + ganonsCastleKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (ganonsCastleKey2Byte == 6)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "6block.png");
                                    GanonsCastleSmallKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Key - 6." + " Address: " + firstFourHexDigits + ganonsCastleKey2ByteStr + " Value: " + ganonsCastleKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (ganonsCastleKey2Byte == 7)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "7block.png");
                                    GanonsCastleSmallKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Key - 7." + " Address: " + firstFourHexDigits + ganonsCastleKey2ByteStr + " Value: " + ganonsCastleKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (ganonsCastleKey2Byte == 8)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "8block.png");
                                    GanonsCastleSmallKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Key - 8." + " Address: " + firstFourHexDigits + ganonsCastleKey2ByteStr + " Value: " + ganonsCastleKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                            else if (ganonsCastleKey2Byte == 9)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "9block.png");
                                    GanonsCastleSmallKeyCount.Size = new Size(12, 15);
                                    if (!hasWritten)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Key - 9." + " Address: " + firstFourHexDigits + ganonsCastleKey2ByteStr + " Value: " + ganonsCastleKey2Byte.ToString() + Environment.NewLine);
                                        hasWritten = true;
                                    }
                                });
                            }
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "0block.png");
                                GanonsCastleSmallKeyCount.Size = new Size(12, 15);
                                if (!hasWritten)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Ganon's Castle Key - 0." + " Address: " + firstFourHexDigits + ganonsCastleKey2ByteStr + " Value: " + ganonsCastleKey2Byte.ToString() + Environment.NewLine);
                                    hasWritten = true;
                                }
                            });
                        }

                        ganonKeysTempValue = ganonKeysValue;
                    }
                    //DOUBLE DEFENSE
                    doubleDefense2Byte = MemLib.readByte(firstFourHexDigits + doubleDefense2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (doubleDefense2Byte == 20)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DoubleDefense.Image = Image.FromFile(workingPath + "Heart Container.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!doubleDefense)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Double Defense." + " Address: " + firstFourHexDigits + doubleDefense2ByteStr + " Value: " + doubleDefense2Byte.ToString() + Environment.NewLine);
                                    doubleDefense = true;
                                }
                            });
                        }
                    }
                    //MAGIC
                    magic2Byte = MemLib.readByte(firstFourHexDigits + magic2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (magic2Byte == 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Magic.Image = Image.FromFile(workingPath + "Small Magic Jar.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!magicOne)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Small Magic." + " Address: " + firstFourHexDigits + magic2ByteStr + " Value: " + magic2Byte.ToString() + Environment.NewLine);
                                    magicOne = true;
                                }

                            });
                        }
                        else if (magic2Byte == 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Magic.Image = Image.FromFile(workingPath + "Large Magic Jar.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!magicTwo)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Large Magic." + " Address: " + firstFourHexDigits + magic2ByteStr + " Value: " + magic2Byte.ToString() + Environment.NewLine);
                                    magicTwo = true;
                                }
                            });
                        }
                    }
                    //SKULLTULA
                    skulltula2Byte = MemLib.readByte(firstFourHexDigits + skulltula2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        bool hasWritten = false;

                        skullValue = skulltula2Byte;

                        if (skullValue != skullTempValue)
                        {
                            hasWritten = false;
                        }
                        else if (skullValue == skullTempValue)
                        {
                            hasWritten = true;
                        }

                        string dateAndTime = DateTime.Now.ToString();
                        dateAndTime = dateAndTime.Replace("/", ".");
                        dateAndTime = dateAndTime.Replace(":", ".");

                        if (skulltula2Byte >= 1 && skulltula2Byte != 255)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Skulltula.Image = Image.FromFile(workingPath + "Gold Skulltula.png");
                            });
                            switch (skulltula2Byte)
                            {
                                case 1:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "1block - Copy.png");
                                        SkulltulaCount.Size = new Size(7, 15);
                                    });
                                    break;
                                case 2:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "2block - Copy.png");
                                        SkulltulaCount.Size = new Size(12, 15);
                                    });
                                    break;
                                case 3:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "3block - Copy.png");
                                        SkulltulaCount.Size = new Size(12, 15);
                                    });
                                    break;
                                case 4:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "4block - Copy.png");
                                        SkulltulaCount.Size = new Size(12, 15);
                                    });
                                    break;
                                case 5:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "5block - Copy.png");
                                        SkulltulaCount.Size = new Size(12, 15);
                                    });
                                    break;
                                case 6:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "6block - Copy.png");
                                        SkulltulaCount.Size = new Size(12, 15);
                                    });
                                    break;
                                case 7:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "7block - Copy.png");
                                        SkulltulaCount.Size = new Size(12, 15);
                                    });
                                    break;
                                case 8:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "8block - Copy.png");
                                        SkulltulaCount.Size = new Size(12, 15);
                                    });
                                    break;
                                case 9:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "9block - Copy.png");
                                        SkulltulaCount.Size = new Size(12, 15);
                                    });
                                    break;
                                case 10:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "10block - Copy.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 11:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "11block.png");
                                        SkulltulaCount.Size = new Size(17, 15);
                                    });
                                    break;
                                case 12:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "12block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 13:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "13block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 14:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "14block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 15:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "15block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 16:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "16block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 17:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "17block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 18:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "18block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 19:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "19block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 20:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "20block - Copy.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 21:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "21block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 22:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "22block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 23:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "23block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 24:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "24block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 25:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "25block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 26:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "26block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 27:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "27block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 28:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "28block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 29:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "29block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 30:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "30block - Copy.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 31:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "31block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 32:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "32block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 33:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "33block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 34:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "34block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 35:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "35block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 36:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "36block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 37:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "37block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 38:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "38block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 39:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "39block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 40:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "40block - Copy.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 41:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "41block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 42:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "42block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 43:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "43block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 44:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "44block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 45:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "45block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 46:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "46block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 47:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "47block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 48:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "48block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 49:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "49block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 50:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "50block - Copy.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 51:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "51block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 52:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "52block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 53:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "53block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 54:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "54block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 55:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "55block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 56:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "56block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 57:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "57block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 58:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "58block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 59:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "59block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 60:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "60block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 61:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "61block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 62:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "62block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 63:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "63block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 64:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "64block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 65:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "65block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 66:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "66block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 67:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "67block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 68:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "68block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 69:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "69block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 70:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "70block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 71:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "71block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 72:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "72block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 73:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "73block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 74:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "74block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 75:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "75block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 76:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "76block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 77:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "77block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 78:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "78block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 79:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "79block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 80:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "80block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 81:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "81block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 82:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "82block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 83:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "83block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 84:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "84block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 85:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "85block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 86:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "86block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 87:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "87block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 88:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "88block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 89:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "89block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 90:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "90block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 91:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "91block.png");
                                        SkulltulaCount.Size = new Size(21, 15);
                                    });
                                    break;
                                case 92:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "92block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 93:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "93block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 94:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "94block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 95:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "95block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 96:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "96block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 97:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "97block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 98:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "98block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 99:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "99block.png");
                                        SkulltulaCount.Size = new Size(24, 15);
                                    });
                                    break;
                                case 100:
                                    Invoke((MethodInvoker)delegate
                                    {
                                        SkulltulaCount.Image = Image.FromFile(workingPath + "100block.png");
                                        SkulltulaCount.Size = new Size(36, 15);
                                    });
                                    break;
                            }
                        }

                        if(!hasWritten)
                        {
                            File.AppendAllText(currentLogFile, dateAndTime + " Skulltula Count " + skulltula2Byte.ToString() + "." + " Address: " + firstFourHexDigits + skulltula2ByteStr + " Value: " + skulltula2Byte.ToString() + Environment.NewLine);
                            hasWritten = true;
                        }

                        skullTempValue = skullValue;
                    }
                    //SWORDS AND SHIELDS
                    //kokiri sword = 1, master sword = 2, giants knife = 4
                    //giants knife (broken) = 8, deku shield = 16, hylian shield = 32
                    //mirror shield = 64, all = 127
                    sNs2Byte = MemLib.readByte(firstFourHexDigits + sNs2ByteStr);
                    tempWeapon = sNs2Byte;
                    bgs2Byte = MemLib.readByte(firstFourHexDigits + bgs2ByteStr);
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        //checked from highest value to lowest and subtract after activating necessary images
                        if (tempWeapon >= 64)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                MirrorShield.Image = Image.FromFile(workingPath + "Mirror Shield.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!sAndH1)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Mirror Shield." + " Address: " + firstFourHexDigits + sNs2ByteStr + " Value: " + sNs2Byte.ToString() + Environment.NewLine);
                                    sAndH1 = true;
                                }
                            });
                            tempWeapon -= 64;
                        }
                        if (tempWeapon >= 32)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                HylianShield.Image = Image.FromFile(workingPath + "Hylian Shield.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!sAndH2)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Hylian Shield." + " Address: " + firstFourHexDigits + sNs2ByteStr + " Value: " + sNs2Byte.ToString() + Environment.NewLine);
                                    sAndH2 = true;
                                }
                            });
                            tempWeapon -= 32;
                        }
                        if (tempWeapon >= 16)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                DekuShield.Image = Image.FromFile(workingPath + "Deku Shield.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!sAndH3)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Shield." + " Address: " + firstFourHexDigits + sNs2ByteStr + " Value: " + sNs2Byte.ToString() + Environment.NewLine);
                                    sAndH3 = true;
                                }
                            });
                            tempWeapon -= 16;
                        }
                        if (tempWeapon >= 8)
                        {
                            if (bgs2Byte == 0)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GoronSword.Image = Image.FromFile(workingPath + "Goron's Sword (Broken).png");
                                });
                            }
                            tempWeapon -= 8;
                        }
                        if (tempWeapon >= 4)
                        {
                            if (bgs2Byte != 0)
                            {
                                Invoke((MethodInvoker)delegate
                                {
                                    GoronSword.Image = Image.FromFile(workingPath + "Biggoron's Sword.png");
                                    string dateAndTime = DateTime.Now.ToString();
                                    dateAndTime = dateAndTime.Replace("/", ".");
                                    dateAndTime = dateAndTime.Replace(":", ".");

                                    if (!sAndH4)
                                    {
                                        File.AppendAllText(currentLogFile, dateAndTime + " Biggoron's Sword." + " Address: " + firstFourHexDigits + sNs2ByteStr + " Value: " + sNs2Byte.ToString() + Environment.NewLine);
                                        sAndH4 = true;
                                    }
                                });
                            }
                            tempWeapon -= 4;
                        }
                        if (tempWeapon >= 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                MasterSword.Image = Image.FromFile(workingPath + "Master Sword.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!sAndH5)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Master Sword." + " Address: " + firstFourHexDigits + sNs2ByteStr + " Value: " + sNs2Byte.ToString() + Environment.NewLine);
                                    sAndH5 = true;
                                }
                            });
                            tempWeapon -= 2;
                        }
                        if (tempWeapon >= 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                KokiriSword.Image = Image.FromFile(workingPath + "Kokiri Sword.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!sAndH6)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Kokiri Sword." + " Address: " + firstFourHexDigits + sNs2ByteStr + " Value: " + sNs2Byte.ToString() + Environment.NewLine);
                                    sAndH6 = true;
                                }
                            });
                            tempWeapon -= 1;
                        }
                    }
                    //CLOTHING
                    //kokiri tunic = 1, goron tunic = 2, zora tunic = 4
                    //kokiri boots = 16, iron boots = 32
                    //hover boots = 64, all = 119
                    c2Byte = MemLib.readByte(firstFourHexDigits + c2ByteStr);
                    tempClothing = c2Byte;
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        //checked from highest value to lowest and subtract after activating necessary images
                        if (tempClothing >= 64)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                HoverBoots.Image = Image.FromFile(workingPath + "Hover Boots.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!c1)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Hover Boots." + " Address: " + firstFourHexDigits + c2ByteStr + " Value: " + c2Byte.ToString() + Environment.NewLine);
                                    c1 = true;
                                }
                            });
                            tempClothing -= 64;
                        }
                        if (tempClothing >= 32)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                IronBoots.Image = Image.FromFile(workingPath + "Iron Boots.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!c2)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Iron Boots." + " Address: " + firstFourHexDigits + c2ByteStr + " Value: " + c2Byte.ToString() + Environment.NewLine);
                                    c2 = true;
                                }
                            });
                            tempClothing -= 32;
                        }
                        if (tempClothing >= 16)
                        {
                            tempClothing -= 16;
                        }
                        if (tempClothing >= 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ZoraTunic.Image = Image.FromFile(workingPath + "Zora Tunic.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!c3)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Zora Tunic." + " Address: " + firstFourHexDigits + c2ByteStr + " Value: " + c2Byte.ToString() + Environment.NewLine);
                                    c3 = true;
                                }
                            });
                            tempClothing -= 4;
                        }
                        if (tempClothing >= 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                GoronTunic.Image = Image.FromFile(workingPath + "Goron Tunic.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!c4)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Goron Tunic." + " Address: " + firstFourHexDigits + c2ByteStr + " Value: " + c2Byte.ToString() + Environment.NewLine);
                                    c4 = true;
                                }
                            });
                            tempClothing -= 2;
                        }
                        if (tempClothing >= 1)
                        {
                            tempClothing -= 1;
                        }
                    }
                    //MEDALLIONS/SONGS 1
                    // forest medallion = 1, fire medallion = 2, water medallion = 4,
                    // spirit medallion = 8, shadow medallion = 16, light medallion = 32,
                    // minuet of forest = 64, bolero of fire = 128
                    MO2Byte = MemLib.readByte(firstFourHexDigits + MO2ByteStr);
                    tempMO = MO2Byte;
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (tempMO >= 128)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BoleroOfFire.Image = Image.FromFile(workingPath + "Bolero of Fire.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ms1)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bolero of Fire." + " Address: " + firstFourHexDigits + MO2ByteStr + " Value: " + MO2Byte.ToString() + Environment.NewLine);
                                    ms1 = true;
                                }
                            });
                            tempMO -= 128;
                        }
                        if (tempMO >= 64)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                MinuetOfForest.Image = Image.FromFile(workingPath + "Minuet of Forest.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ms2)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Minuet of Forest." + " Address: " + firstFourHexDigits + MO2ByteStr + " Value: " + MO2Byte.ToString() + Environment.NewLine);
                                    ms2 = true;
                                }
                            });
                            tempMO -= 64;
                        }
                        if (tempMO >= 32)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                LightMedallion.Image = Image.FromFile(workingPath + "Light Medallion.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ms3)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Light Medallion." + " Address: " + firstFourHexDigits + MO2ByteStr + " Value: " + MO2Byte.ToString() + Environment.NewLine);
                                    ms3 = true;
                                }
                            });
                            tempMO -= 32;
                        }
                        if (tempMO >= 16)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ShadowMedallion.Image = Image.FromFile(workingPath + "Shadow Medallion.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ms4)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Shadow Medallion." + " Address: " + firstFourHexDigits + MO2ByteStr + " Value: " + MO2Byte.ToString() + Environment.NewLine);
                                    ms4 = true;
                                }
                            });
                            tempMO -= 16;
                        }
                        if (tempMO >= 8)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SpiritMedallion.Image = Image.FromFile(workingPath + "Spirit Medallion.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ms5)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Spirit Medallion." + " Address: " + firstFourHexDigits + MO2ByteStr + " Value: " + MO2Byte.ToString() + Environment.NewLine);
                                    ms5 = true;
                                }
                            });
                            tempMO -= 8;
                        }
                        if (tempMO >= 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                WaterMedallion.Image = Image.FromFile(workingPath + "Water Medallion.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ms6)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Water Medallion." + " Address: " + firstFourHexDigits + MO2ByteStr + " Value: " + MO2Byte.ToString() + Environment.NewLine);
                                    ms6 = true;
                                }
                            });
                            tempMO -= 4;
                        }
                        if (tempMO >= 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                FireMedallion.Image = Image.FromFile(workingPath + "Fire Medallion.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ms7)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Fire Medallion." + " Address: " + firstFourHexDigits + MO2ByteStr + " Value: " + MO2Byte.ToString() + Environment.NewLine);
                                    ms7 = true;
                                }
                            });
                            tempMO -= 2;
                        }
                        if (tempMO >= 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ForestMedallion.Image = Image.FromFile(workingPath + "Forest Medallion.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ms8)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Forest Medallion." + " Address: " + firstFourHexDigits + MO2ByteStr + " Value: " + MO2Byte.ToString() + Environment.NewLine);
                                    ms8 = true;
                                }
                            });
                            tempMO -= 1;
                        }
                    }
                    //MEDALLIONS/SONGS 2
                    // song of time = 1, song of storms = 2, kokiri emerald = 4,
                    // gorons ruby = 8, zoras sapphire = 16, stone of agony = 32,
                    // gerudos card = 64
                    MT2Byte = MemLib.readByte(firstFourHexDigits + MT2ByteStr);
                    tempMT = MT2Byte;
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        //checked from highest value to lowest and subtract after activating necessary images
                        if (tempMT >= 128)
                        {
                            tempMT -= 128;
                        }
                        if (tempMT >= 64)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                GerudoCard.Image = Image.FromFile(workingPath + "Gerudo Card.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ss1)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Gerudo Card." + " Address: " + firstFourHexDigits + MT2ByteStr + " Value: " + MT2Byte.ToString() + Environment.NewLine);
                                    ss1 = true;
                                }
                            });
                            tempMT -= 64;
                        }
                        if (tempMT >= 32)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                StoneOfAgony.Image = Image.FromFile(workingPath + "Stone of Agony.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ss2)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Stone of Agony." + " Address: " + firstFourHexDigits + MT2ByteStr + " Value: " + MT2Byte.ToString() + Environment.NewLine);
                                    ss2 = true;
                                }
                            });
                            tempMT -= 32;
                        }
                        if (tempMT >= 16)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ZoraSapphire.Image = Image.FromFile(workingPath + "Zora's Sapphire.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ss3)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Zora's Sapphire." + " Address: " + firstFourHexDigits + MT2ByteStr + " Value: " + MT2Byte.ToString() + Environment.NewLine);
                                    ss3 = true;
                                }
                            });
                            tempMT -= 16;
                        }
                        if (tempMT >= 8)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                GoronRuby.Image = Image.FromFile(workingPath + "Goron's Ruby.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ss4)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Goron's Ruby." + " Address: " + firstFourHexDigits + MT2ByteStr + " Value: " + MT2Byte.ToString() + Environment.NewLine);
                                    ss4 = true;
                                }
                            });
                            tempMT -= 8;
                        }
                        if (tempMT >= 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                KokiriEmerald.Image = Image.FromFile(workingPath + "Kokiri Emerald.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ss5)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Kokiri Emerald." + " Address: " + firstFourHexDigits + MT2ByteStr + " Value: " + MT2Byte.ToString() + Environment.NewLine);
                                    ss5 = true;
                                }
                            });
                            tempMT -= 4;
                        }
                        if (tempMT >= 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SongOfStorms.Image = Image.FromFile(workingPath + "Song of Storms (Edit).png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ss6)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Song of Storms." + " Address: " + firstFourHexDigits + MT2ByteStr + " Value: " + MT2Byte.ToString() + Environment.NewLine);
                                    ss6 = true;
                                }
                            });
                            tempMT -= 2;
                        }
                        if (tempMT >= 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SongOfTime.Image = Image.FromFile(workingPath + "Song of Time (Edit).png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ss7)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Song of Time." + " Address: " + firstFourHexDigits + MT2ByteStr + " Value: " + MT2Byte.ToString() + Environment.NewLine);
                                    ss7 = true;
                                }
                            });
                            tempMT -= 1;
                        }
                    }
                    //SONGS
                    // serenade of water = 1, requiem of spirit = 2, nocturne of shadow = 4,
                    // prelude of light = 8, zeldas lullaby = 16, eponas song = 32,
                    // sarias song = 64, suns song = 128
                    s2Byte = MemLib.readByte(firstFourHexDigits + s2ByteStr);
                    tempS = s2Byte;
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (tempS >= 128)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SunSong.Image = Image.FromFile(workingPath + "Sun's Song (Edit).png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!s1)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Sun's Song." + " Address: " + firstFourHexDigits + s2ByteStr + " Value: " + s2Byte.ToString() + Environment.NewLine);
                                    s1 = true;
                                }
                            });
                            tempS -= 128;
                        }
                        if (tempS >= 64)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SariasSong.Image = Image.FromFile(workingPath + "Saria's Song (Edit).png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!s2)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Saria's Song." + " Address: " + firstFourHexDigits + s2ByteStr + " Value: " + s2Byte.ToString() + Environment.NewLine);
                                    s2 = true;
                                }
                            });
                            tempS -= 64;
                        }
                        if (tempS >= 32)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                EponasSong.Image = Image.FromFile(workingPath + "Epona's Song (Edit).png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!s3)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Epona's Song." + " Address: " + firstFourHexDigits + s2ByteStr + " Value: " + s2Byte.ToString() + Environment.NewLine);
                                    s3 = true;
                                }
                            });
                            tempS -= 32;
                        }
                        if (tempS >= 16)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ZeldasLullaby.Image = Image.FromFile(workingPath + "Zelda's Lullaby (Edit).png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!s4)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Zelda's Lullaby." + " Address: " + firstFourHexDigits + s2ByteStr + " Value: " + s2Byte.ToString() + Environment.NewLine);
                                    s4 = true;
                                }
                            });
                            tempS -= 16;
                        }
                        if (tempS >= 8)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                PreludeOfLight.Image = Image.FromFile(workingPath + "Prelude of Light.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!s5)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Prelude of Light." + " Address: " + firstFourHexDigits + s2ByteStr + " Value: " + s2Byte.ToString() + Environment.NewLine);
                                    s5 = true;
                                }
                            });
                            tempS -= 8;
                        }
                        if (tempS >= 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                NocturneOfShadow.Image = Image.FromFile(workingPath + "Nocturne of Shadow.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!s6)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Nocturne of Shadow." + " Address: " + firstFourHexDigits + s2ByteStr + " Value: " + s2Byte.ToString() + Environment.NewLine);
                                    s6 = true;
                                }
                            });
                            tempS -= 4;
                        }
                        if (tempS >= 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                RequiemOfSpirit.Image = Image.FromFile(workingPath + "Requiem of Spirit.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!s7)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Requiem of Spirit." + " Address: " + firstFourHexDigits + s2ByteStr + " Value: " + s2Byte.ToString() + Environment.NewLine);
                                    s7 = true;
                                }
                            });
                            tempS -= 2;
                        }
                        if (tempS >= 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                SerenadeOfWater.Image = Image.FromFile(workingPath + "Serenade of Water.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!s8)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Serenade of Water." + " Address: " + firstFourHexDigits + s2ByteStr + " Value: " + s2Byte.ToString() + Environment.NewLine);
                                    s8 = true;
                                }
                            });
                            tempS -= 1;
                        }
                    }
                    //BULLETS/SCALES
                    // silver scale = 2, gold scale = 4, bullet bag (30) = 64,
                    // bullet bag (40) = 128, bullet bag (50) = 192
                    bs2Byte = MemLib.readByte(firstFourHexDigits + bs2ByteStr);
                    tempBS = bs2Byte;
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (tempBS >= 192)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BulletBagCount.Image = Image.FromFile(workingPath + "50block.png");
                                BulletBagCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bs1)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bullet Bag - 50." + " Address: " + firstFourHexDigits + bs2ByteStr + " Value: " + bs2Byte.ToString() + Environment.NewLine);
                                    bs1 = true;
                                }
                            });
                            tempBS -= 192;
                        }
                        if (tempBS >= 128)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BulletBagCount.Image = Image.FromFile(workingPath + "40block.png");
                                BulletBagCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bs2)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bullet Bag - 40." + " Address: " + firstFourHexDigits + bs2ByteStr + " Value: " + bs2Byte.ToString() + Environment.NewLine);
                                    bs2 = true;
                                }
                            });
                            tempBS -= 128;
                        }
                        if (tempBS >= 64)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BulletBagCount.Image = Image.FromFile(workingPath + "30block.png");
                                BulletBagCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bs3)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bullet Bag 30." + " Address: " + firstFourHexDigits + bs2ByteStr + " Value: " + bs2Byte.ToString() + Environment.NewLine);
                                    bs3 = true;
                                }
                            });
                            tempBS -= 64;
                        }
                        if (tempBS >= 48)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Wallet.Image = Image.FromFile(workingPath + "Tycoon's Wallet.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bs4)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Tycoon's Wallet." + " Address: " + firstFourHexDigits + bs2ByteStr + " Value: " + bs2Byte.ToString() + Environment.NewLine);
                                    bs4 = true;
                                }
                            });
                            tempBS -= 48;
                        }
                        if (tempBS >= 32)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Wallet.Image = Image.FromFile(workingPath + "Giant's Wallet.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bs5)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Giant's Wallet." + " Address: " + firstFourHexDigits + bs2ByteStr + " Value: " + bs2Byte.ToString() + Environment.NewLine);
                                    bs5 = true;
                                }
                            });
                            tempBS -= 32;
                        }
                        if (tempBS >= 16)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Wallet.Image = Image.FromFile(workingPath + "Adult's Wallet.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bs6)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Adult's Wallet." + " Address: " + firstFourHexDigits + bs2ByteStr + " Value: " + bs2Byte.ToString() + Environment.NewLine);
                                    bs6 = true;
                                }
                            });
                            tempBS -= 16;
                        }
                        if (tempBS >= 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Scale.Image = Image.FromFile(workingPath + "Gold Scale.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bs7)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Gold Scale." + " Address: " + firstFourHexDigits + bs2ByteStr + " Value: " + bs2Byte.ToString() + Environment.NewLine);
                                    bs7 = true;
                                }
                            });
                            tempBS -= 4;
                        }
                        if (tempBS >= 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Scale.Image = Image.FromFile(workingPath + "Silver Scale.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bs8)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Silver Scale." + " Address: " + firstFourHexDigits + bs2ByteStr + " Value: " + bs2Byte.ToString() + Environment.NewLine);
                                    bs8 = true;
                                }
                            });
                            tempBS -= 2;
                        }
                    }
                    //BOMB BAGS / QUIVERS / GAUNTLETS
                    // quiver (30) = 1
                    // quiver (40) = 2, quiver (50) = 3, bomb bag (20) = 8,
                    // bomb bag (30) = 16, bomb bag (40) = 24, goron bracelet = 64
                    // silver gauntlets = 128, golden gauntlets = 192
                    bqg2Byte = MemLib.readByte(firstFourHexDigits + bqg2ByteStr);
                    tempBQG = bqg2Byte;
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (tempBQG >= 192)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Strength.Image = Image.FromFile(workingPath + "Golden Gauntlets.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bg1)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Golden Gauntlets." + " Address: " + firstFourHexDigits + bqg2ByteStr + " Value: " + bqg2Byte.ToString() + Environment.NewLine);
                                    bg1 = true;
                                }
                            });
                            tempBQG -= 192;
                        }
                        if (tempBQG >= 128)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Strength.Image = Image.FromFile(workingPath + "Silver Gauntlets.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bg2)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Silver Gauntlets." + " Address: " + firstFourHexDigits + bqg2ByteStr + " Value: " + bqg2Byte.ToString() + Environment.NewLine);
                                    bg2 = true;
                                }
                            });
                            tempBQG -= 128;
                        }
                        if (tempBQG >= 64)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                Strength.Image = Image.FromFile(workingPath + "Goron Bracelet.png");
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bg3)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Goron Bracelet." + " Address: " + firstFourHexDigits + bqg2ByteStr + " Value: " + bqg2Byte.ToString() + Environment.NewLine);
                                    bg3 = true;
                                }
                            });
                            tempBQG -= 64;
                        }
                        if (tempBQG >= 24)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BombCount.Image = Image.FromFile(workingPath + "40block.png");
                                BombCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bg4)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bomb Bag - 40." + " Address: " + firstFourHexDigits + bqg2ByteStr + " Value: " + bqg2Byte.ToString() + Environment.NewLine);
                                    bg4 = true;
                                }
                            });
                            tempBQG -= 24;
                        }
                        if (tempBQG >= 16)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BombCount.Image = Image.FromFile(workingPath + "30block.png");
                                BombCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bg5)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bomb Bag - 30." + " Address: " + firstFourHexDigits + bqg2ByteStr + " Value: " + bqg2Byte.ToString() + Environment.NewLine);
                                    bg5 = true;
                                }
                            });
                            tempBQG -= 16;
                        }
                        if (tempBQG >= 8)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                BombCount.Image = Image.FromFile(workingPath + "20block.png");
                                BombCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bg6)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Bomb Bag - 20." + " Address: " + firstFourHexDigits + bqg2ByteStr + " Value: " + bqg2Byte.ToString() + Environment.NewLine);
                                    bg6 = true;
                                }
                            });
                            tempBQG -= 8;
                        }
                        if (tempBQG >= 3)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ArrowCount.Image = Image.FromFile(workingPath + "50block.png");
                                ArrowCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bg7)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Quiver - 50." + " Address: " + firstFourHexDigits + bqg2ByteStr + " Value: " + bqg2Byte.ToString() + Environment.NewLine);
                                    bg7 = true;
                                }
                            });
                            tempBQG -= 3;
                        }
                        if (tempBQG >= 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ArrowCount.Image = Image.FromFile(workingPath + "40block.png");
                                ArrowCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bg8)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Quiver - 40." + " Address: " + firstFourHexDigits + bqg2ByteStr + " Value: " + bqg2Byte.ToString() + Environment.NewLine);
                                    bg8 = true;
                                }
                            });
                            tempBQG -= 2;
                        }
                        if (tempBQG >= 1)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                ArrowCount.Image = Image.FromFile(workingPath + "30block.png");
                                ArrowCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!bg9)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Quiver - 30." + " Address: " + firstFourHexDigits + bqg2ByteStr + " Value: " + bqg2Byte.ToString() + Environment.NewLine);
                                    bg9 = true;
                                }
                            });
                            tempBQG -= 1;
                        }
                    }
                    //DEKU STICK and NUT COUNT
                    // 10 sticks = 2, 20 sticks = 4, 30 sticks = 6
                    // 20 nuts = 16, 30 nuts = 32, 40 nuts = 48
                    ds2Byte = MemLib.readByte(firstFourHexDigits + ds2ByteStr);
                    tempDSN = ds2Byte;
                    inPlay2Byte = MemLib.readByte(firstFourHexDigits + inPlay2ByteStr);
                    if (inPlay2Byte != 0)
                    {
                        if (tempDSN >= 48)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                NutCount.Image = Image.FromFile(workingPath + "40block.png");
                                NutCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ds1)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Nuts Count - 40." + " Address: " + firstFourHexDigits + ds2ByteStr + " Value: " + ds2Byte.ToString() + Environment.NewLine);
                                    ds1 = true;
                                }
                            });
                            tempDSN -= 48;
                        }
                        if (tempDSN >= 32)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                NutCount.Image = Image.FromFile(workingPath + "30block.png");
                                NutCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ds2)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Nuts Count - 30." + " Address: " + firstFourHexDigits + ds2ByteStr + " Value: " + ds2Byte.ToString() + Environment.NewLine);
                                    ds2 = true;
                                }
                            });
                            tempDSN -= 32;
                        }
                        if (tempDSN >= 16)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                NutCount.Image = Image.FromFile(workingPath + "20block.png");
                                NutCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ds3)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Nuts Count - 20." + " Address: " + firstFourHexDigits + ds2ByteStr + " Value: " + ds2Byte.ToString() + Environment.NewLine);
                                    ds3 = true;
                                }
                            });
                            tempDSN -= 16;
                        }
                        if (tempDSN >= 6)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                StickCount.Image = Image.FromFile(workingPath + "30block.png");
                                StickCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ds4)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Sticks Count - 30." + " Address: " + firstFourHexDigits + ds2ByteStr + " Value: " + ds2Byte.ToString() + Environment.NewLine);
                                    ds4 = true;
                                }
                            });
                            tempDSN -= 6;
                        }
                        if (tempDSN >= 4)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                StickCount.Image = Image.FromFile(workingPath + "20block.png");
                                StickCount.Size = new Size(24, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ds5)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Sticks Count - 20." + " Address: " + firstFourHexDigits + ds2ByteStr + " Value: " + ds2Byte.ToString() + Environment.NewLine);
                                    ds5 = true;
                                }
                            });
                            tempDSN -= 4;
                        }
                        if (tempDSN >= 2)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                StickCount.Image = Image.FromFile(workingPath + "10block.png");
                                StickCount.Size = new Size(21, 15);
                                string dateAndTime = DateTime.Now.ToString();
                                dateAndTime = dateAndTime.Replace("/", ".");
                                dateAndTime = dateAndTime.Replace(":", ".");

                                if (!ds6)
                                {
                                    File.AppendAllText(currentLogFile, dateAndTime + " Deku Sticks Count - 10." + " Address: " + firstFourHexDigits + ds2ByteStr + " Value: " + ds2Byte.ToString() + Environment.NewLine);
                                    ds6 = true;
                                }
                            });
                            tempDSN -= 2;
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // First, handle the case where an exception was thrown.
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (e.Cancelled)
            {
                // Next, handle the case where the user canceled 
                // the operation.
                // Note that due to a race condition in 
                // the DoWork event handler, the Cancelled
                // flag may not have been set, even though
                // CancelAsync was called.
                MessageBox.Show("Cancelled");
            }
            else
            {
                // Finally, handle the case where the operation 
                // succeeded.
                MessageBox.Show(e.Result.ToString());
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void DekuStick_Click(object sender, EventArgs e)
        {
            
        }

        private void Boomerang_Click(object sender, EventArgs e)
        {

        }

        private void Slingshot_Click(object sender, EventArgs e)
        {

        }

        private void LensOfTruth_Click(object sender, EventArgs e)
        {

        }

        private void Ocarina_Click(object sender, EventArgs e)
        {

        }

        private void DekuNuts_Click(object sender, EventArgs e)
        {

        }

        private void MagicBean_Click(object sender, EventArgs e)
        {

        }

        private void Bombchu_Click(object sender, EventArgs e)
        {

        }

        private void Bombs_Click(object sender, EventArgs e)
        {

        }

        private void MegatonHammer_Click(object sender, EventArgs e)
        {

        }

        private void Hookshot_Click(object sender, EventArgs e)
        {

        }

        private void Bow_Click(object sender, EventArgs e)
        {

        }

        private void LightArrow_Click(object sender, EventArgs e)
        {

        }

        private void IceArrow_Click(object sender, EventArgs e)
        {

        }

        private void FireArrow_Click(object sender, EventArgs e)
        {

        }

        private void Nayru_Click(object sender, EventArgs e)
        {

        }

        private void Farore_Click(object sender, EventArgs e)
        {

        }

        private void Din_Click(object sender, EventArgs e)
        {

        }

        private void AdultTrade_Click(object sender, EventArgs e)
        {

        }

        private void ChildTrade_Click(object sender, EventArgs e)
        {

        }

        private void KokiriSword_Click(object sender, EventArgs e)
        {

        }

        private void MasterSword_Click(object sender, EventArgs e)
        {

        }

        private void GoronSword_Click(object sender, EventArgs e)
        {

        }

        private void DekuShield_Click(object sender, EventArgs e)
        {

        }

        private void HylianShield_Click(object sender, EventArgs e)
        {

        }

        private void MirrorShield_Click(object sender, EventArgs e)
        {

        }

        private void GoronTunic_Click(object sender, EventArgs e)
        {

        }

        private void StoneOfAgony_Click(object sender, EventArgs e)
        {

        }

        private void IronBoots_Click(object sender, EventArgs e)
        {

        }

        private void HoverBoots_Click(object sender, EventArgs e)
        {

        }

        private void KokiriEmerald_Click(object sender, EventArgs e)
        {

        }

        private void GoronRuby_Click(object sender, EventArgs e)
        {

        }

        private void ZoraSapphire_Click(object sender, EventArgs e)
        {

        }

        private void LightMedallion_Click(object sender, EventArgs e)
        {

        }

        private void ForestMedallion_Click(object sender, EventArgs e)
        {

        }

        private void FireMedallion_Click(object sender, EventArgs e)
        {

        }

        private void WaterMedallion_Click(object sender, EventArgs e)
        {

        }

        private void ShadowMedallion_Click(object sender, EventArgs e)
        {

        }

        private void SpiritMedallion_Click(object sender, EventArgs e)
        {

        }

        private void ZeldasLullaby_Click(object sender, EventArgs e)
        {

        }

        private void EponasSong_Click(object sender, EventArgs e)
        {

        }

        private void SariasSong_Click(object sender, EventArgs e)
        {

        }

        private void SunSong_Click(object sender, EventArgs e)
        {

        }

        private void SongOfTime_Click(object sender, EventArgs e)
        {

        }

        private void SongOfStorms_Click(object sender, EventArgs e)
        {

        }

        private void MinuetOfForest_Click(object sender, EventArgs e)
        {

        }

        private void BoleroOfFire_Click(object sender, EventArgs e)
        {

        }

        private void SerenadeOfWater_Click(object sender, EventArgs e)
        {

        }

        private void RequiemOfSpirit_Click(object sender, EventArgs e)
        {

        }

        private void NocturneOfShadow_Click(object sender, EventArgs e)
        {

        }

        private void PreludeOfLight_Click(object sender, EventArgs e)
        {

        }

        private void Strength_Click(object sender, EventArgs e)
        {

        }

        private void Scale_Click(object sender, EventArgs e)
        {

        }

        private void Magic_Click(object sender, EventArgs e)
        {

        }

        private void DoubleDefense_Click(object sender, EventArgs e)
        {

        }

        private void Wallet_Click(object sender, EventArgs e)
        {

        }

        private void Skulltula_Click(object sender, EventArgs e)
        {

        }

        private void ForestTempleBigKey_Click(object sender, EventArgs e)
        {

        }

        private void ForestTempleSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void FireTempleBigKey_Click(object sender, EventArgs e)
        {

        }

        private void FireTempleSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void WaterTempleBigKey_Click(object sender, EventArgs e)
        {

        }

        private void WaterTempleSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void SpiritTempleBigKey_Click(object sender, EventArgs e)
        {

        }

        private void SpiritTempleSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void ShadowTempleBigKey_Click(object sender, EventArgs e)
        {

        }

        private void ShadowTempleSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void GanonsCastleBigKey_Click(object sender, EventArgs e)
        {

        }

        private void GanonsCastleSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void BOTWSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void ForestTempleMap_Click(object sender, EventArgs e)
        {

        }

        private void FireTempleCompass_Click(object sender, EventArgs e)
        {

        }

        private void ForestTempleCompass_Click(object sender, EventArgs e)
        {

        }

        private void FireTempleMap_Click(object sender, EventArgs e)
        {

        }

        private void WaterTempleCompass_Click(object sender, EventArgs e)
        {

        }

        private void WaterTempleMap_Click(object sender, EventArgs e)
        {

        }

        private void SpiritTempleCompass_Click(object sender, EventArgs e)
        {

        }

        private void SpiritTempleMap_Click(object sender, EventArgs e)
        {

        }

        private void ShadowTempleCompass_Click(object sender, EventArgs e)
        {

        }

        private void ShadowTempleMap_Click(object sender, EventArgs e)
        {

        }

        private void BOTWCompass_Click(object sender, EventArgs e)
        {

        }

        private void BOTWMap_Click(object sender, EventArgs e)
        {

        }

        private void IceCavernCompass_Click(object sender, EventArgs e)
        {

        }

        private void IceCavernMap_Click(object sender, EventArgs e)
        {

        }

        private void JabuCompass_Click(object sender, EventArgs e)
        {

        }

        private void JabuMap_Click(object sender, EventArgs e)
        {

        }

        private void DodongoCompass_Click(object sender, EventArgs e)
        {

        }

        private void DodongoMap_Click(object sender, EventArgs e)
        {

        }

        private void DekuCompass_Click(object sender, EventArgs e)
        {

        }

        private void DekuMap_Click(object sender, EventArgs e)
        {

        }

        private void ForestTempleKeyCount_Click(object sender, EventArgs e)
        {

        }

        private void FireTempleKeyCount_Click(object sender, EventArgs e)
        {

        }

        private void WaterTempleKeyCount_Click(object sender, EventArgs e)
        {

        }

        private void SpiritTempleKeyCount_Click(object sender, EventArgs e)
        {

        }

        private void ShadowTempleKeyCount_Click(object sender, EventArgs e)
        {

        }

        private void BOTWKeyCount_Click(object sender, EventArgs e)
        {

        }

        private void GerudoTrainingGroundKeyCount_Click(object sender, EventArgs e)
        {

        }

        private void GerudoFortressKeyCount_Click(object sender, EventArgs e)
        {

        }

        private void GanonsCastleSmallKeyCount_Click(object sender, EventArgs e)
        {

        }

        private void SkulltulaCount_Click(object sender, EventArgs e)
        {

        }

        private void ZoraTunic_Click(object sender, EventArgs e)
        {

        }

        private void BulletBagCount_Click(object sender, EventArgs e)
        {

        }

        private void BombCount_Click(object sender, EventArgs e)
        {

        }

        private void ArrowCount_Click(object sender, EventArgs e)
        {

        }

        private void StickCount_Click(object sender, EventArgs e)
        {
            StickCount.Parent = DekuStick;
            StickCount.BackColor = Color.Transparent;
        }

        private void NutCount_Click(object sender, EventArgs e)
        {

        }

        private async void Button1_Click_1Async(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Project 64")//fucks
            {
                MemLib.OpenProcess("Project64");
                long myAoBScan = (await MemLib.AoBScan("0000000000000000", 0x7fffffffffffffff, "00 00 00 00 00 00 00 00 CD 00 00 00 00 00 00 00 F3 FF 00 00 00 00 ?? ?? 01 00 00 00 00 00 00 00 00 00 00 00 44 4C 45 5A 00 00 5A 41 DF 61 87 81 DF DF DF DF E0"));
                var id = myAoBScan;
                var hexid = $"0x{id:X}";
                firstFourHexDigits = hexid;
                fullAddress = hexid.ToString();
                baseAddress = fullAddress.Substring(2, fullAddress.Length - 2);
                baseAddress = baseAddress.Substring(baseAddress.Length - 4, 4);
                if (firstFourHexDigits.Length > 5)
                {
                    MessageBox.Show(hexid);
                    string firstFourHexDigitsSub = firstFourHexDigits.Substring(0, firstFourHexDigits.Length - 4);
                    firstFourHexDigits = firstFourHexDigitsSub;
                    MessageBox.Show("Successfully Scanned Game.");
                    button1.Enabled = false;
                    button2.Enabled = true;
                    comboBox1.Enabled = false;
                    currentEmulator = "Project64";
                }
                else
                {
                    MessageBox.Show(hexid);
                    MessageBox.Show("Failed to open game.");
                }
            }
            else if(comboBox1.Text == "RetroArch")
            {
                MemLib.OpenProcess("retroarch");
                Debug.WriteLine("openedProcess");
                long myAoBScan = (await MemLib.AoBScan("0000000000000000", 0x7fffffffffffffff, "00 00 00 00 00 00 00 00 CD 00 00 00 00 00 00 00 F3 FF 00 00 00 00 ?? ?? 01 00 00 00 00 00 00 00 00 00 00 00 44 4C 45 5A 00 00 5A 41 DF 61 87 81 DF DF DF DF E0"));
                var id = myAoBScan;
                var hexid = $"0x{id:X}";
                firstFourHexDigits = hexid;
                fullAddress = hexid.ToString();
                baseAddress = fullAddress.Substring(2, fullAddress.Length - 2);
                baseAddress = baseAddress.Substring(baseAddress.Length - 4, 4);
                if (firstFourHexDigits.Length > 5)
                {
                    MessageBox.Show(hexid);
                    string firstFourHexDigitsSub = firstFourHexDigits.Substring(0, firstFourHexDigits.Length - 4);
                    firstFourHexDigits = firstFourHexDigitsSub;
                    MessageBox.Show("Successfully Scanned Game.");
                    button1.Enabled = false;
                    button2.Enabled = true;
                    comboBox1.Enabled = false;
                    currentEmulator = "RetroArch";
                }
                else
                {
                    MessageBox.Show(hexid);
                    MessageBox.Show("Failed to open game.");
                }
            }
            else if(comboBox1.Text == "Bizhawk")
            {
                MemLib.OpenProcess("EmuHawk");
                Debug.WriteLine("openedProcess");
                long myAoBScan = (await MemLib.AoBScan("0000000000000000", 0x7fffffffffffffff, "00 00 00 00 00 00 00 00 CD 00 00 00 00 00 00 00 F3 FF 00 00 00 00 ?? ?? 01 00 00 00 00 00 00 00 00 00 00 00 44 4C 45 5A 00 00 5A 41 DF 61 87 81 DF DF DF DF E0"));
                var id = myAoBScan;
                var hexid = $"0x{id:X}";
                firstFourHexDigits = hexid;
                fullAddress = hexid.ToString();
                baseAddress = fullAddress.Substring(2, fullAddress.Length - 2);
                baseAddress = baseAddress.Substring(baseAddress.Length - 4, 4);
                if (firstFourHexDigits.Length > 5)
                {
                    MessageBox.Show(hexid);
                    string firstFourHexDigitsSub = firstFourHexDigits.Substring(0, firstFourHexDigits.Length - 4);
                    firstFourHexDigits = firstFourHexDigitsSub;
                    MessageBox.Show("Successfully Scanned Game.");
                    button1.Enabled = false;
                    button2.Enabled = true;
                    comboBox1.Enabled = false;
                    currentEmulator = "Bizhawk";
                }
                else
                {
                    MessageBox.Show(hexid);
                    MessageBox.Show("Failed to open game.");
                }
            }
            else if(comboBox1.Text == "")
            {
                MessageBox.Show("Please select an emulator from the dropdown box.");
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            BottleOne.Image = Image.FromFile(workingPath + "Empty Bottle - Gray.png");
            BottleTwo.Image = Image.FromFile(workingPath + "Empty Bottle - Gray.png");
            BottleThree.Image = Image.FromFile(workingPath + "Empty Bottle - Gray.png");
            BottleFour.Image = Image.FromFile(workingPath + "Empty Bottle - Gray.png");
            DekuStick.Image = Image.FromFile(workingPath + "DekuStick - Gray.png");
            Boomerang.Image = Image.FromFile(workingPath + "Boomerang - Gray.png");
            Slingshot.Image = Image.FromFile(workingPath + "Fairy Slingshot - Gray.png");
            LensOfTruth.Image = Image.FromFile(workingPath + "Lens of Truth - Gray.png");
            Ocarina.Image = Image.FromFile(workingPath + "Fairy Ocarina - Gray.png");
            DekuNuts.Image = Image.FromFile(workingPath + "Deku Nut - Gray.png");
            MagicBean.Image = Image.FromFile(workingPath + "Magic Beans - Gray.png");
            Bombchu.Image = Image.FromFile(workingPath + "Bombchu - Gray.png");
            Bombs.Image = Image.FromFile(workingPath + "Bomb - Gray.png");
            MegatonHammer.Image = Image.FromFile(workingPath + "Megaton Hammer - Gray.png");
            Hookshot.Image = Image.FromFile(workingPath + "Hookshot - Gray.png");
            Bow.Image = Image.FromFile(workingPath + "Fairy Bow - Gray.png");
            LightArrow.Image = Image.FromFile(workingPath + "Light Arrow - Gray.png");
            IceArrow.Image = Image.FromFile(workingPath + "Ice Arrow - Gray.png");
            FireArrow.Image = Image.FromFile(workingPath + "Fire Arrow - Gray.png");
            Nayru.Image = Image.FromFile(workingPath + "Nayru's Love - Gray.png");
            Farore.Image = Image.FromFile(workingPath + "Farore's Wind - Gray.png");
            Din.Image = Image.FromFile(workingPath + "Din's Fire - Gray.png");
            AdultTrade.Image = Image.FromFile(workingPath + "Weird Egg - Gray.png");
            ChildTrade.Image = Image.FromFile(workingPath + "Weird Egg - Gray.png");
            DoubleDefense.Image = Image.FromFile(workingPath + "Heart Container - Gray.png");
            Magic.Image = Image.FromFile(workingPath + "Small Magic Jar - Gray.png");
            Skulltula.Image = Image.FromFile(workingPath + "Gold Skulltula - Gray.png");
            SkulltulaCount.Size = new Size(12, 15);
            ArrowCount.Size = new Size(12, 15);
            BombCount.Size = new Size(12, 15);
            NutCount.Size = new Size(12, 15);
            StickCount.Size = new Size(12, 15);
            BulletBagCount.Size = new Size(12, 15);
            ShadowTempleKeyCount.Size = new Size(12, 15);
            SpiritTempleKeyCount.Size = new Size(12, 15);
            WaterTempleKeyCount.Size = new Size(12, 15);
            FireTempleKeyCount.Size = new Size(12, 15);
            ForestTempleKeyCount.Size = new Size(12, 15);
            BOTWKeyCount.Size = new Size(12, 15);
            GerudoTrainingGroundKeyCount.Size = new Size(12, 15);
            GerudoFortressKeyCount.Size = new Size(12, 15);
            GanonsCastleSmallKeyCount.Size = new Size(12, 15);
            MirrorShield.Image = Image.FromFile(workingPath + "Mirror Shield - Gray.png");
            HylianShield.Image = Image.FromFile(workingPath + "Hylian Shield - Gray.png");
            DekuShield.Image = Image.FromFile(workingPath + "Deku Shield - Gray.png");
            GoronSword.Image = Image.FromFile(workingPath + "Biggoron's Sword - Gray.png");
            MasterSword.Image = Image.FromFile(workingPath + "Master Sword - Gray.png");
            KokiriSword.Image = Image.FromFile(workingPath + "Kokiri Sword - Gray.png");
            HoverBoots.Image = Image.FromFile(workingPath + "Hover Boots - Gray.png");
            IronBoots.Image = Image.FromFile(workingPath + "Iron Boots - Gray.png");
            ZoraTunic.Image = Image.FromFile(workingPath + "Zora Tunic - Gray.png");
            GoronTunic.Image = Image.FromFile(workingPath + "Goron Tunic - Gray.png");
            BoleroOfFire.Image = Image.FromFile(workingPath + "Bolero of Fire - Gray.png");
            MinuetOfForest.Image = Image.FromFile(workingPath + "Minuet of Forest - Gray.png");
            LightMedallion.Image = Image.FromFile(workingPath + "Light Medallion - Gray.png");
            ShadowMedallion.Image = Image.FromFile(workingPath + "Shadow Medallion - Gray.png");
            SpiritMedallion.Image = Image.FromFile(workingPath + "Spirit Medallion - Gray.png");
            WaterMedallion.Image = Image.FromFile(workingPath + "Water Medallion - Gray.png");
            FireMedallion.Image = Image.FromFile(workingPath + "Fire Medallion - Gray.png");
            ForestMedallion.Image = Image.FromFile(workingPath + "Forest Medallion - Gray.png");
            GerudoCard.Image = Image.FromFile(workingPath + "Gerudo Card - Gray.png");
            StoneOfAgony.Image = Image.FromFile(workingPath + "Stone of Agony - Gray.png");
            ZoraSapphire.Image = Image.FromFile(workingPath + "Zora's Sapphire - Gray.png");
            GoronRuby.Image = Image.FromFile(workingPath + "Goron's Ruby - Gray.png");
            KokiriEmerald.Image = Image.FromFile(workingPath + "Kokiri Emerald - Gray.png");
            SongOfStorms.Image = Image.FromFile(workingPath + "Song of Storms (Edit) - Gray.png");
            SongOfTime.Image = Image.FromFile(workingPath + "Song of Time (Edit) - Gray.png");
            SunSong.Image = Image.FromFile(workingPath + "Sun's Song (Edit) - Gray.png");
            SariasSong.Image = Image.FromFile(workingPath + "Saria's Song (Edit) - Gray.png");
            EponasSong.Image = Image.FromFile(workingPath + "Epona's Song (Edit) - Gray.png");
            ZeldasLullaby.Image = Image.FromFile(workingPath + "Zelda's Lullaby (Edit) - Gray.png");
            PreludeOfLight.Image = Image.FromFile(workingPath + "Prelude of Light - Gray.png");
            NocturneOfShadow.Image = Image.FromFile(workingPath + "Nocturne of Shadow - Gray.png");
            RequiemOfSpirit.Image = Image.FromFile(workingPath + "Requiem of Spirit - Gray.png");
            SerenadeOfWater.Image = Image.FromFile(workingPath + "Serenade of Water - Gray.png");
            Wallet.Image = Image.FromFile(workingPath + "Adult's Wallet - Gray.png");
            Scale.Image = Image.FromFile(workingPath + "Silver Scale - Gray.png");
            Strength.Image = Image.FromFile(workingPath + "Goron Bracelet - Gray.png");
            DekuMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
            DodongoMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
            JabuMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
            ForestBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
            ForestMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
            ForestTempleKeyCount.Image = Image.FromFile(workingPath + "0block.png");
            FireMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
            FireBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
            FireTempleKeyCount.Image = Image.FromFile(workingPath + "0block.png");
            WaterMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
            WaterBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
            WaterTempleKeyCount.Image = Image.FromFile(workingPath + "0block.png");
            SpiritMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
            SpiritBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
            SpiritTempleKeyCount.Image = Image.FromFile(workingPath + "0block.png");
            ShadowMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
            ShadowBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
            ShadowTempleKeyCount.Image = Image.FromFile(workingPath + "0block.png");
            IceMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
            BOTWMapCompass.Image = Image.FromFile(workingPath + "Compassdeactivatedmapdeactivated.png");
            BOTWKeyCount.Image = Image.FromFile(workingPath + "0block.png");
            BOTWSmallKey.Image = Image.FromFile(workingPath + "Small Key - Gray.png");
            GerudoTrainingGround.Image = Image.FromFile(workingPath + "Small Key - Gray.png");
            GerudoTrainingGroundKeyCount.Image = Image.FromFile(workingPath + "0block.png");
            GerudoFortress.Image = Image.FromFile(workingPath + "Small Key - Gray.png");
            GerudoFortressKeyCount.Image = Image.FromFile(workingPath + "0block.png");
            GanonsCastleSmallKeyCount.Image = Image.FromFile(workingPath + "0block.png");
            GanonBigSmallKey.Image = Image.FromFile(workingPath + "bigsmalldeactivated.png");
            SkulltulaCount.Image = Image.FromFile(workingPath + "0block.png");
            BulletBagCount.Image = Image.FromFile(workingPath + "0block.png");
            BombCount.Image = Image.FromFile(workingPath + "0block.png");
            ArrowCount.Image = Image.FromFile(workingPath + "0block.png");
            NutCount.Image = Image.FromFile(workingPath + "0block.png");
            StickCount.Image = Image.FromFile(workingPath + "0block.png");
            
            
            /*
            OoT NewForm = new OoT();
            NewForm.Show();
            this.Dispose(false);
            */
        }

        private void ForestMapCompass_Click(object sender, EventArgs e)
        {

        }

        private void ForestBigSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void FireMapCompass_Click(object sender, EventArgs e)
        {

        }

        private void FireBigSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void WaterBigSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void WaterMapCompass_Click(object sender, EventArgs e)
        {

        }

        private void SpiritBigSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void SpiritMapCompass_Click(object sender, EventArgs e)
        {

        }

        private void ShadowBigSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void ShadowMapCompass_Click(object sender, EventArgs e)
        {

        }

        private void DekuMapCompass_Click(object sender, EventArgs e)
        {

        }

        private void DodongoMapCompass_Click(object sender, EventArgs e)
        {

        }

        private void JabuMapCompass_Click(object sender, EventArgs e)
        {

        }

        private void IceMapCompass_Click(object sender, EventArgs e)
        {

        }

        private void BOTWMapCompass_Click(object sender, EventArgs e)
        {

        }

        private void GanonBigSmallKey_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (currentLogFile != null)
            {
                attributes = File.GetAttributes(currentLogFile);

                if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
                {
                    // Show the file.
                    attributes = RemoveAttribute(attributes, FileAttributes.Hidden);
                    File.SetAttributes(currentLogFile, attributes);
                    Console.WriteLine("The {0} file is no longer hidden.", currentLogFile);
                }
                else
                {
                    // Hide the file.
                    File.SetAttributes(currentLogFile, File.GetAttributes(currentLogFile) | FileAttributes.Hidden);
                    Console.WriteLine("The {0} file is now hidden.", currentLogFile);
                }
            }
            Environment.Exit(0);
        }

        private void BackgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Pb1_Click(object sender, EventArgs e)
        {
            
        }

        private void Pb1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbutton1++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pbutton1--;
            }
            if(pbutton1 > 10)
            {
                pbutton1 = 0;
            }
            if (pbutton1 < 0)
            {
                pbutton1 = 10;
            }
            switch(pbutton1)
            {
                case 0:
                    pb1.Image = Image.FromFile(workingPath + "dots.png");
                    pb1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 1:
                    pb1.Image = Image.FromFile(workingPath + "deku.png");
                    pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pb1.Image = Image.FromFile(workingPath + "dodongo.png");
                    pb1.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pb1.Image = Image.FromFile(workingPath + "jabu.png");
                    pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pb1.Image = Image.FromFile(workingPath + "forest.png");
                    pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pb1.Image = Image.FromFile(workingPath + "fire.png");
                    pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pb1.Image = Image.FromFile(workingPath + "water.png");
                    pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    pb1.Image = Image.FromFile(workingPath + "shadow.png");
                    pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                    pb1.Image = Image.FromFile(workingPath + "spirit.png");
                    pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 9:
                    pb1.Image = Image.FromFile(workingPath + "free2.png");
                    pb1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Pb2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbutton2++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pbutton2--;
            }
            if (pbutton2 > 9)
            {
                pbutton2 = 0;
            }
            if (pbutton2 < 0)
            {
                pbutton2 = 9;
            }
            switch (pbutton2)
            {
                case 0:
                    pb2.Image = Image.FromFile(workingPath + "dots.png");
                    pb2.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 1:
                    pb2.Image = Image.FromFile(workingPath + "deku.png");
                    pb2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pb2.Image = Image.FromFile(workingPath + "dodongo.png");
                    pb2.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pb2.Image = Image.FromFile(workingPath + "jabu.png");
                    pb2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pb2.Image = Image.FromFile(workingPath + "forest.png");
                    pb2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pb2.Image = Image.FromFile(workingPath + "fire.png");
                    pb2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pb2.Image = Image.FromFile(workingPath + "water.png");
                    pb2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    pb2.Image = Image.FromFile(workingPath + "shadow.png");
                    pb2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                    pb2.Image = Image.FromFile(workingPath + "spirit.png");
                    pb2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 9:
                    pb2.Image = Image.FromFile(workingPath + "free2.png");
                    pb2.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Pb3_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbutton3++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pbutton3--;
            }
            if (pbutton3 > 9)
            {
                pbutton3 = 0;
            }
            if (pbutton3 < 0)
            {
                pbutton3 = 9;
            }
            switch (pbutton3)
            {
                case 0:
                    pb3.Image = Image.FromFile(workingPath + "dots.png");
                    pb3.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 1:
                    pb3.Image = Image.FromFile(workingPath + "deku.png");
                    pb3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pb3.Image = Image.FromFile(workingPath + "dodongo.png");
                    pb3.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pb3.Image = Image.FromFile(workingPath + "jabu.png");
                    pb3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pb3.Image = Image.FromFile(workingPath + "forest.png");
                    pb3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pb3.Image = Image.FromFile(workingPath + "fire.png");
                    pb3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pb3.Image = Image.FromFile(workingPath + "water.png");
                    pb3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    pb3.Image = Image.FromFile(workingPath + "shadow.png");
                    pb3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                    pb3.Image = Image.FromFile(workingPath + "spirit.png");
                    pb3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 9:
                    pb3.Image = Image.FromFile(workingPath + "free2.png");
                    pb3.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Pb4_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbutton4++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pbutton4--;
            }
            if (pbutton4 > 9)
            {
                pbutton4 = 0;
            }
            if (pbutton4 < 0)
            {
                pbutton4 = 9;
            }
            switch (pbutton4)
            {
                case 0:
                    pb4.Image = Image.FromFile(workingPath + "dots.png");
                    pb4.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 1:
                    pb4.Image = Image.FromFile(workingPath + "deku.png");
                    pb4.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 2:
                    pb4.Image = Image.FromFile(workingPath + "dodongo.png");
                    pb4.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pb4.Image = Image.FromFile(workingPath + "jabu.png");
                    pb4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pb4.Image = Image.FromFile(workingPath + "forest.png");
                    pb4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pb4.Image = Image.FromFile(workingPath + "fire.png");
                    pb4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pb4.Image = Image.FromFile(workingPath + "water.png");
                    pb4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    pb4.Image = Image.FromFile(workingPath + "shadow.png");
                    pb4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                    pb4.Image = Image.FromFile(workingPath + "spirit.png");
                    pb4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 9:
                    pb4.Image = Image.FromFile(workingPath + "free2.png");
                    pb4.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Pb5_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbutton5++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pbutton5--;
            }
            if (pbutton5 > 9)
            {
                pbutton5 = 0;
            }
            if (pbutton5 < 0)
            {
                pbutton5 = 9;
            }
            switch (pbutton5)
            {
                case 0:
                    pb5.Image = Image.FromFile(workingPath + "dots.png");
                    pb5.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 1:
                    pb5.Image = Image.FromFile(workingPath + "deku.png");
                    pb5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pb5.Image = Image.FromFile(workingPath + "dodongo.png");
                    pb5.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pb5.Image = Image.FromFile(workingPath + "jabu.png");
                    pb5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pb5.Image = Image.FromFile(workingPath + "forest.png");
                    pb5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pb5.Image = Image.FromFile(workingPath + "fire.png");
                    pb5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pb5.Image = Image.FromFile(workingPath + "water.png");
                    pb5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    pb5.Image = Image.FromFile(workingPath + "shadow.png");
                    pb5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                    pb5.Image = Image.FromFile(workingPath + "spirit.png");
                    pb5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 9:
                    pb5.Image = Image.FromFile(workingPath + "free2.png");
                    pb5.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Pb6_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbutton6++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pbutton6--;
            }
            if (pbutton6 > 9)
            {
                pbutton6 = 0;
            }
            if (pbutton6 < 0)
            {
                pbutton6 = 9;
            }
            switch (pbutton6)
            {
                case 0:
                    pb6.Image = Image.FromFile(workingPath + "dots.png");
                    pb6.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 1:
                    pb6.Image = Image.FromFile(workingPath + "deku.png");
                    pb6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pb6.Image = Image.FromFile(workingPath + "dodongo.png");
                    pb6.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pb6.Image = Image.FromFile(workingPath + "jabu.png");
                    pb6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pb6.Image = Image.FromFile(workingPath + "forest.png");
                    pb6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pb6.Image = Image.FromFile(workingPath + "fire.png");
                    pb6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pb6.Image = Image.FromFile(workingPath + "water.png");
                    pb6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    pb6.Image = Image.FromFile(workingPath + "shadow.png");
                    pb6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                    pb6.Image = Image.FromFile(workingPath + "spirit.png");
                    pb6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 9:
                    pb6.Image = Image.FromFile(workingPath + "free2.png");
                    pb6.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Pb7_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbutton7++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pbutton7--;
            }
            if (pbutton7 > 9)
            {
                pbutton7 = 0;
            }
            if (pbutton7 < 0)
            {
                pbutton7 = 9;
            }
            switch (pbutton7)
            {
                case 0:
                    pb7.Image = Image.FromFile(workingPath + "dots.png");
                    pb7.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 1:
                    pb7.Image = Image.FromFile(workingPath + "deku.png");
                    pb7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pb7.Image = Image.FromFile(workingPath + "dodongo.png");
                    pb7.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pb7.Image = Image.FromFile(workingPath + "jabu.png");
                    pb7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pb7.Image = Image.FromFile(workingPath + "forest.png");
                    pb7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pb7.Image = Image.FromFile(workingPath + "fire.png");
                    pb7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pb7.Image = Image.FromFile(workingPath + "water.png");
                    pb7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    pb7.Image = Image.FromFile(workingPath + "shadow.png");
                    pb7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                    pb7.Image = Image.FromFile(workingPath + "spirit.png");
                    pb7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 9:
                    pb7.Image = Image.FromFile(workingPath + "free2.png");
                    pb7.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Pb8_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbutton8++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pbutton8--;
            }
            if (pbutton8 > 9)
            {
                pbutton8 = 0;
            }
            if (pbutton8 < 0)
            {
                pbutton8 = 9;
            }
            switch (pbutton8)
            {
                case 0:
                    pb8.Image = Image.FromFile(workingPath + "dots.png");
                    pb8.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 1:
                    pb8.Image = Image.FromFile(workingPath + "deku.png");
                    pb8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pb8.Image = Image.FromFile(workingPath + "dodongo.png");
                    pb8.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pb8.Image = Image.FromFile(workingPath + "jabu.png");
                    pb8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pb8.Image = Image.FromFile(workingPath + "forest.png");
                    pb8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pb8.Image = Image.FromFile(workingPath + "fire.png");
                    pb8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pb8.Image = Image.FromFile(workingPath + "water.png");
                    pb8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    pb8.Image = Image.FromFile(workingPath + "shadow.png");
                    pb8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                    pb8.Image = Image.FromFile(workingPath + "spirit.png");
                    pb8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 9:
                    pb8.Image = Image.FromFile(workingPath + "free2.png");
                    pb8.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Pb9_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pbutton9++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                pbutton9--;
            }
            if (pbutton9 > 9)
            {
                pbutton9 = 0;
            }
            if (pbutton9 < 0)
            {
                pbutton9 = 9;
            }
            switch (pbutton9)
            {
                case 0:
                    pb9.Image = Image.FromFile(workingPath + "dots.png");
                    pb9.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 1:
                    pb9.Image = Image.FromFile(workingPath + "deku.png");
                    pb9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 2:
                    pb9.Image = Image.FromFile(workingPath + "dodongo.png");
                    pb9.SizeMode = PictureBoxSizeMode.CenterImage;
                    break;
                case 3:
                    pb9.Image = Image.FromFile(workingPath + "jabu.png");
                    pb9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 4:
                    pb9.Image = Image.FromFile(workingPath + "forest.png");
                    pb9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 5:
                    pb9.Image = Image.FromFile(workingPath + "fire.png");
                    pb9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 6:
                    pb9.Image = Image.FromFile(workingPath + "water.png");
                    pb9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 7:
                    pb9.Image = Image.FromFile(workingPath + "shadow.png");
                    pb9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 8:
                    pb9.Image = Image.FromFile(workingPath + "spirit.png");
                    pb9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 9:
                    pb9.Image = Image.FromFile(workingPath + "free2.png");
                    pb9.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void Pb9_Click(object sender, EventArgs e)
        {

        }

        private void GerudoTrainingGround_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void CurrentEmulatorText_Click(object sender, EventArgs e)
        {

        }

        private void CurrentEmulatorLogo_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
