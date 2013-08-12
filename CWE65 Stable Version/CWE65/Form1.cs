using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CWE65
{

    public partial class cweForm : Form
    {
        #region Variable Declerations
        /** All of these P's are for constant already defined anular space that is relevant to perfs */
        const double P958 = 105.15;
        const double P858 = 84.52;
        const double P700 = 54.59;
        const double P658 = 46.69;
        const double P512 = 32.62;
        const double P412 = 21.09;
        const double P312 = 12.06;
        const double P278 = 8.02;
        const double P238 = 5.35;
        const double FDB = 0.65;
        const double FRT = 4.07;
        const double P6 = 36.29;
        const double P7 = 53.83;
        const double anularMultiplier = 1.715;/** multiple if not a standard pipe to multiply by */       

        /** These arrays are mostly constants taht are loaded into a table, and then dont change, the first 6 arrays defined here are used
         * so that they can store additional old information that can be used in later functionality */
        double[] SIZ = new double[100];/** These are used as tracking statistics for each time the user enters a perf at that time*/
        double[] NBS = new double[100];
        double[] BPI = new double[100];
        double[] BPQ = new double[150];
        double[] BPF = new double[150];/**stores the default values of barrels for each perf*/
        double[] PL = new double[150]; /**stores the barrels for each perf*/
        double[] ARY = new double[131];/** Temporary array that is used when comparing */
        double[] X = new double[131];/**all used for the table X and Y*/
        double[] Y = new double[131];/** all used for the table 2 dimensional 130 element tables */
        string[] pipeSizes = new string[10];/**all used for comparing strings and checking pipe sizes */
        double[] pValues = new double[10];/** used for the comparisson between user pipesize */
        



        double anularspace = 0;
        /** This has to do with calculating anular space */
        string menuPipe ="";/** this is for the DropBox so that it can compare with the pre-defined labels */
        double XX = 0;/** pressure inputted*/
        double YY = 0;/** pressure index table that changes */
        int M = 0;
        int T = 0;
        int perfCounter = 1;/** The number of perf sets that have been entered */
        double pipeValueSize = 0;/** This value stores the anular space that is already calculated or getting calculated */
        double BPD=0;
        double R = 0; /** used for the diameter in perf size */
        double N = 0; /** used for user size of perf*/
        double SQ = 0; /** SQ is used in the function equation to (R/2)^2*/
        double TP = 0; /** TP is used as a storage intermediate for the function to claculate perf*/
        double Q = 0;/** Quality that the user specificed when entering the menu*/
        double velocity = 0;/** The velocity that the user enters*/
        double VG = 0;/** The value that is set equal to the pressure index table */
        double EQ = 0;/** The calculated quality based on the Quality * 100 then rounded */
        double QUL = 0;
        double QAL = 0;
        double BD = 0;/** This calculation is used to store the intermediate values of how many barrels of oils were produced by perfs at current size */
        double PO = 0;/** used with the PSI^.97 in the perf size calculations */
        double BDQ = 0;
        double PSI = 0;/** This is the pressure for another calculation in the CALQ calculation */
        /*double COEF = 0;
        double DIFF = 0;
        double RATE = 0;
        double STAT = 0;*/
        double RATE = 0;/** This is the Meter Rate at the current time */
        double BPD1 = 0;/** This would be the barrels per day at 100% quality steam */
        double BPD65 = 0;/** This would be the barrels per day at 65% quality steam */
        double BPD7 = 0;/** This would be the barrels per day at 70% quality steam */
        double PSIZ = 0;/** This is the pipesize that would be specified by the user alone in the drop menu */
        double BPDEQ = 0;
        double ToT = 0;/** This keeps track of the total number of barrels that have been produced in that well based on number of perfs */

        #endregion

        #region functionInitialization
        public cweForm()
        {
            InitializeComponent();
            initializeArrays();
            anularSpaceTextBox.Text = "0";
        }
        #endregion

        #region GUIFunctions
      
        
        private void pipeSizeChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == pipeSizeDropBox)
            {
                try
                {
                    menuPipe = pipeSizeDropBox.Text;
                  
                }
                catch (FormatException)
                {
                }
            }
        }
        private void velocityChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == velocityTextBox)
            {
                try
                {
                    velocity = Convert.ToDouble(velocityTextBox.Text);
                }
                catch (FormatException)
                {
                }
            }
        }
        private void calculate70FunctionClick(object sender, EventArgs e)
        {
            try
            {
                if((XX == 0) || (velocity == 0))
                 {
                    MessageBox.Show("Please Enter All factors");
                    return;
                }
                PSI = XX; /**setting the PSI = the pressure for later use*/
                PO = Math.Pow(PSI, .97);/** PO is needed for the theoretical calculations */
                anularspace = anularMultiplier * (Convert.ToDouble(anularSpaceTextBox.Text));
                CALC();/** Function that calls the calculate and changes the barrels per day */
            }
            catch (FormatException)
            {
                MessageBox.Show("Entered information is not valid");
                return;
            }
        }
        private void addPerfButton_Click(object sender, EventArgs e)
         {
             BD = 0;
             try 
             {
                 addPerfCalculate();/** Calls the function that calculates the perfds Barrels and updates them*/
             }     
             catch (FormatException)
             {
                 MessageBox.Show("Function Failed");
                 return;
             }      
         }
        private void calculatePerfTheoreticals(object sender, EventArgs e)
         {
             try
             {
                 R = Convert.ToDouble(perfDropBoxDiam.Text);
                 N = Convert.ToDouble(perfSizeTextBox.Text);
                 if (R > 0 || N > 0)
                 {
                     MessageBox.Show("Please clear the perf field to 0's,or add the last perf set to the list");
                 }

                 BPI[0] = perfCounter;
                 BD = 0;
                 M = perfCounter;
                 /*for (int i = 1; i <= perfCounter; i++)
                 {
                     BD += BPI[i]; already calculated earlier with the ToT keeping track of all of that
                 }*/
                 RATE = ToT;
                 CALQ();
                 totalTheoreticalTextBox.Text = Convert.ToString(Math.Round(ToT));
                 theoreticalQualityBox.Text = Convert.ToString(Math.Round(Q * 100));
             }
             catch(FormatException)
             {
                 MessageBox.Show("The Calculate Perfs Failed");
             }
         }

        private void pressureTextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == pressureTextBox)
            {
                try
                {
                    XX = Convert.ToDouble(pressureTextBox.Text);/*setting pressure(XX) to the textbox value*/
                }
                catch (FormatException)
                {
                }
            }
        }
        private void anularSpace_TextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == anularSpaceTextBox)
            {
                try
                {
                    
                }
                catch (FormatException)
                {
                }
            }
        }
        private void qualityTextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == qualityDropBox)
            {
                try
                {
                    Q = Convert.ToDouble(qualityDropBox.Text);
                    if (Q > 0.0)
                    {
                        EQ = (Q / 100); /** getting a percentage */
                    }
                }
                catch (FormatException)
                {
                }
            }
        }
        private void velocityTextChanged(object sender, EventArgs e)
        {
            if (this.ActiveControl == velocityTextBox)
            {
                try
                {
                    velocity = Convert.ToDouble(velocityTextBox.Text);
                }
                catch (FormatException)
                {
                }

            }
        }

        #region form/tab functionality
        private void cweForm_Load(object sender, EventArgs e)
        {

        }
        private void dataTab1_Click(object sender, EventArgs e)
        {

        }
        private void outputTab_Click(object sender, EventArgs e)
        {

        }
        #endregion


        #endregion

        #region functionsForFormulaes
        private void addPerfCalculate()
        {
            /** This grabs the radius of the perf, and the number of perfs in that textbox */
            R = Convert.ToDouble(perfDropBoxDiam.Text);
            N = Convert.ToDouble(perfSizeTextBox.Text);
            //** Setting the SIZ index of the array = the current radius of the perf */
            SIZ[perfCounter] = R;

            //** checking if the R value is a standardized default size*/
            if (R != .250 && R != .220 && R != .188)
            {
                SQ = Math.Pow((R / 2), 2);
                TP = (SQ * FRT * FDB * Math.PI * PO) / .8366;/**this is the equation to calculate barrels per day*/
                BPF[3 + perfCounter] = TP;
            }

            else
            {

                double temp = (R / 2);/**sets the temporary default parameter /2 for easier divison */

                SQ = temp * temp;
                // MessageBox.Show(Convert.ToString(SQ)); this is working properly
                /// MessageBox.Show(Convert.ToString(PO)); this is checking pressure^.97 to see if working
                TP = (SQ * FRT * FDB * Math.PI * PO) / .8366;
                /** Calculate the barrels per day that the perfs come out with, and then store it if it is a standard one*/
                if (R == .250)
                    BPF[1] = TP;
                if (R == .220)
                    BPF[2] = TP;
                if (R == .188)
                    BPF[3] = TP;
            }
            /** Here we are summing up all of the barrels per day that were calculated */
            PL[perfCounter] = TP;

            for (int i = 0; i < N; i++)
            {
                BD = BD + TP;/** this is the barrels per day sum for this specific perf*/
            }

            ToT = ToT + BD;/** This is the barrels that the entire well is creating */
            
            //MessageBox.Show(Convert.ToString(BD)); tested each perf to see barrels per day
            NBS[perfCounter] = N;/**stores the number of perfs that were within the well for that diameter */
            BPI[perfCounter] = BD;/**stores the barrels that that specific perf size and number produced */
            RATE = BD;/**The Rate for theoreticals is set equal to the barrels that were produced */
            CALQ();/** Calls the calculate function to see the quality of the oil is for the theoretical */
            BPQ[perfCounter] = Q;/**saves the quality at that specific position for the perf */
            perfCounter++;
            /** Reset the boxes for the user to continue entering new values */
            perfDropBoxDiam.Text = "0";
            perfSizeTextBox.Text = "0";
            /*Show the user the number of sets that the user has entered */
            numPerfsTextBox.Text = Convert.ToString(perfCounter - 1);
        }
        /* private void meterCalculate()
        {
            double tempR = 0;
           //used to be if rate < .01

                tempR = COEF * DIFF * STAT;
                RATE = tempR;
        }function no longer in use*/
        
        private void POINT()
        {
            /** this is the search algorithimn to read through the table and select the appropriate choice in the table
             * this selects the VG and sets it equal to the pressure index that is found */
            double TY = 0;
            double TX = 0;
            int I = 0,K = 0;
            /**Scans the entire array looking for a value matching the pressure that was given*/
            for (; I <= 130; I++)
            {
                if (XX >= X[I])
                {
                    K = I;
                }
            }
            if (XX == X[K])
            {
                YY = Y[K];
            }
                /** This else statement has to deal with interpolation of whether the number is between 2 indexes, what it should do with the value */
            else
            {
                K = K + 1;
                TX = (X[K] - X[K - 1]);
                TY = (Y[K - 1] - Y[K]);
                YY = Y[K] + ((TY / TX) * (X[K] - XX));
            }
        }
        private void pipeSize()
        {
            /** this function goes through the commonly used pipesize table and sets them = the specific pipeValue */
          
            if (anularspace > 0.0)/** here calculates the anular pipezie if the normal value was not specified */
            {
                pipeValueSize = anularspace;
                return;
            }
            /** Just a basic scan of the array to find the pipe size that the user specified and find the Pvalue that is relative to that size */
            for (int temp = 0; temp < 10; temp++)
            {
                if (menuPipe == pipeSizes[temp])
                {
                    pipeValueSize = pValues[temp];
                    break;
                }
            }
        }
        
        private void CALQ()
        {
            pipeSize();
            /** finds the proper pipesize that will be set */
            POINT();
            /** Finds the proper pressure index, so that it can be set equal to the YY value */
            VG = YY; /** VG = the pressure index output*/ 
            Q = ((velocity * pipeValueSize) / (RATE * VG));
        }

        private void CALC()
        {
            /**XX is used to get the VG which XX is pressure and VG is the index, P is = the pipesize and VG is from the table*/
            pipeSize();

            POINT();
            /* set values = the point function and reset variables*/
            VG = YY;

            //BPD1 = (XX * velocity) / VG;
            BPD65 = (pipeValueSize * velocity) / (VG * 0.65);//this is 65% quality steam
            BPD7 = (pipeValueSize * velocity) / (VG * 0.70);//this is 70% quality steam

            float chosenPercent = float.Parse(qualityDropBox.Text) / 100f;
            BPD1 = (pipeValueSize * velocity) / (VG * chosenPercent);//this is chosen quality steam//chris
            /*if (Q > 0.01)
            {
                BPD = (XX * velocity) / (VG * Q);
            }
            if (EQ > .01)
            {
                BPDEQ = (XX * velocity) / (VG * EQ);
            }*/
            /** changes a textbox that is always set at 70% quality and non-theoretical */

            firstDefaultQualityTextBox.Text = Convert.ToString(Math.Round(BPD65));
            secondDefaultQualityTextBox.Text = Convert.ToString(Math.Round(BPD7));

            defaultChosenRate.Text = "B/D @ " + qualityDropBox.Text + "% Quality";
            thirdDefaultQualityTextBox.Text = Convert.ToString(Math.Round(BPD1));
        }
        
        #region Initialize Position Arrays
        private void initializeArrays()
        {
            pValues[0] = P238;
            pValues[1] = P278;
            pValues[2] = P312;
            pValues[3] = P412;
            pValues[4] = P512;
            pValues[5] = P658;
            pValues[6] = P700;
            pValues[7] = P858;
            pValues[8] = P958;
            pValues[9] = PSIZ;

            pipeSizes[0] = "2-3/8\"";
            pipeSizes[1] = "2-7/8\"";
            pipeSizes[2] = "3-1/2\"";
            pipeSizes[3] = "4-1/2\"";
            pipeSizes[4] = "5-1/2\"";
            pipeSizes[5] = "6-5/8\"";
            pipeSizes[6] = "7\"";
            pipeSizes[7] = "8-5/8\"";
            pipeSizes[8] = "9-5/8\"";
            pipeSizes[9] = "OTHER";



        X[1] = 07.51; Y[1] = 50.33;
        X[2] = 10.61; Y[2] = 36.36;
        X[3] = 14.99; Y[3] = 26.31;
        X[4] = 20.00; Y[4] = 20.07;
		X[5] = 24.08; Y[5] = 16.886;
		X[6] = 24.97; Y[6] = 16.323;
		X[7] = 25.88; Y[7] = 15.782;
		X[8] = 26.83; Y[8] = 15.262;
		X[9] = 27.80; Y[9] = 14.762;
		X[10] = 28.30; Y[10] = 14.265;
		X[11] = 29.83; Y[11] = 13.821;
		X[12] = 30.88; Y[12] = 13.360;
		X[13] = 31.97; Y[13] = 12.950;
		X[14] = 33.09; Y[14] = 12.522;
		X[15] = 34.24; Y[15] = 12.144;
		X[16] = 35.43; Y[16] = 11.763;
		X[17] = 36.65; Y[17] = 11.396;
		X[18] = 37.90; Y[18] = 11.043;
		X[19] = 39.18; Y[19] = 10.704;
		X[20] = 40.50; Y[20] = 10.376;
		X[21] = 41.86; Y[21] = 10.061;
		X[22] = 43.25; Y[22] =  9.756;
		X[23] = 44.68; Y[23] =  9.463;
		X[24] = 46.15; Y[24] =  9.181;
		X[25] = 47.66; Y[25] =  8.908;
		X[26] = 49.20; Y[26] =  8.645;
		X[27] = 50.79; Y[27] =  8.391;
		X[28] = 52.42; Y[28] =  8.146;
		X[29] = 54.09; Y[29] =  7.910;
		X[30] = 55.80; Y[30] =  7.682;
		X[31] = 57.56; Y[31] =  7.461;
		X[32] = 59.36; Y[32] =  7.248;
		X[33] = 61.20; Y[33] =  7.043;
		X[34] = 63.09; Y[34] =  6.844;
		X[35] = 65.03; Y[35] =  6.652;
		X[36] = 67.01; Y[36] =  6.466;
		X[37] = 69.05; Y[37] =  6.287;
		X[38] = 71.13; Y[38] =  6.114;
		X[39] = 73.26; Y[39] =  5.946;
		X[40] = 75.44; Y[40] =  5.783;
		X[41] = 77.68; Y[41] =  5.626;
		X[42] = 79.96; Y[42] =  5.457;
		X[43] = 82.30; Y[43] =  5.327;
		X[44] = 84.70; Y[44] =  5.185;
		X[45] = 87.15; Y[45] =  5.047;
		X[46] = 89.66; Y[46] =  4.914;
		X[47] = 92.22; Y[47] =  4.785;
		X[48] = 94.84; Y[48] =  4.660;
		X[49] = 97.52; Y[49] =  4.538;
		X[50] = 100.26; Y[50] = 4.421;
		X[51] = 103.06; Y[51] = 4.289;
		X[52] = 105.92; Y[52] = 4.197;
		X[53] = 108.85; Y[53] = 4.072;
		X[54] = 111.84; Y[54] = 3.986;
		X[55] = 114.89; Y[55] = 3.886;
		X[56] = 118.01; Y[56] = 3.788;
		X[57] = 121.20; Y[57] = 3.693;
		X[58] = 124.45; Y[58] = 3.602;
		X[59] = 127.77; Y[59] = 3.495;
		X[60] = 131.17; Y[60] = 3.426;
		X[61] = 134.63; Y[61] = 3.342;
		X[62] = 138.16; Y[62] = 3.261;
		X[63] = 141.77; Y[63] = 3.182;
		X[64] = 145.45; Y[64] = 3.105;
		X[65] = 149.21; Y[65] = 3.030;
		X[66] = 153.04; Y[66] = 2.957;
		X[67] = 156.95; Y[67] = 2.887;
		X[68] = 160.93; Y[68] = 2.819;
		X[69] = 165.00; Y[69] = 2.752;
		X[70] = 169.15; Y[70] = 2.669;
		X[71] = 173.37; Y[71] = 2.625;
		X[72] = 177.68; Y[72] = 2.564;
		X[73] = 182.07; Y[73] = 2.504;
		X[74] = 186.55; Y[74] = 2.446;
		X[75] = 191.12; Y[75] = 2.390;
		X[76] = 195.77; Y[76] = 2.335;
		X[77] = 200.50; Y[77] = 2.282;
		X[78] = 205.33; Y[78] = 2.231;
		X[79] = 210.25; Y[79] = 2.180;
		X[80] = 215.26; Y[80] = 2.131;
		X[81] = 220.37; Y[81] = 2.084;
		X[82] = 225.56; Y[82] = 2.037;
		X[83] = 230.85; Y[83] = 1.992;
		X[84] = 236.24; Y[84] = 1.948;
		X[85] = 241.73; Y[85] = 1.905;
		X[86] = 247.31; Y[86] = 1.863;
		X[87] = 261.71; Y[87] = 1.763;
		X[88] = 276.75; Y[88] = 1.670;
		X[89] = 292.45; Y[89] = 1.582;
		X[90] = 308.83; Y[90] = 1.500;
		X[91] = 325.93; Y[91] = 1.423;
		X[92] = 343.72; Y[92] = 1.350;
		X[93] = 362.27; Y[93] = 1.281;
		X[94] = 381.59; Y[94] = 1.217;
		X[95] = 401.68; Y[95] = 1.156;
		X[96] = 422.60; Y[96] = 1.099;
		X[97] = 444.30; Y[97] = 1.045;
		X[98] = 466.90; Y[98] = 0.994;
		X[99] = 490.30; Y[99] = 0.946;
		X[100] = 514.70; Y[100] = 0.901;
		X[101] = 539.90; Y[101] = 0.858;
		X[102] = 566.10; Y[102] = 0.817;
		X[103] = 593.30; Y[103] = 0.779;
		X[104] = 621.40; Y[104] = 0.742;
		X[105] = 650.60; Y[105] = 0.708;
		X[106] = 680.80; Y[106] = 0.675;
		X[107] = 712.00; Y[107] = 0.644;
		X[108] = 744.30; Y[108] = 0.614;
		X[109] = 777.80; Y[109] = 0.586;
		X[110] = 812.40; Y[110] = 0.559;
		X[111] = 848.10; Y[111] = 0.534;
		X[112] = 885.00; Y[112] = 0.510;
		X[113] = 923.20; Y[113] = 0.487;
		X[114] = 962.50; Y[114] = 0.465;
		X[115] = 1003.20; Y[115] = 0.444;
		X[116] = 1045.20; Y[116] = 0.424;
		X[117] = 1088.50; Y[117] = 0.405;
		X[118] = 1133.10; Y[118] = 0.387;
		X[119] = 1179.10; Y[119] = 0.369;
		X[120] = 1226.50; Y[120] = 0.353;
		X[121] = 1275.40; Y[121] = 0.337;
		X[122] = 1325.80; Y[122] = 0.322;
		X[123] = 1377.70; Y[123] = 0.307;
		X[124] = 1431.20; Y[124] = 0.293;
        X[125] = 1453.30; Y[125] = 0.2882;
        X[126] = 1475.40; Y[126] = 0.2829;
        X[127] = 1497.80; Y[127] = 0.2777;
        X[128] = 1520.40; Y[128] = 0.2725;
        X[129] = 1543.20; Y[129] = 0.2675;
        X[130] = 1566.30; Y[130] = 0.2625;
        }
        #endregion

        #endregion
    }
}