using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace SimpleGames
{
    public partial class Form1 : Form
    {
        int totalP1Wins = 0;
        int totalP2Wins = 0;
        string[] saveFile = new string[2] { "0", "0"};
        public Form1()
        {
            InitializeComponent();
            UpdateScoreFromFile();
        }

       
        public void GetScoreFromSaveFile()
        {
            //Deserealize here
            IFormatter formatter = new BinaryFormatter();
            if (File.Exists("data.db"))
            {
                using (Stream stream = new FileStream("data.db", FileMode.Open, FileAccess.Read))
                {
                    saveFile = (string[])formatter.Deserialize(stream);
                }
            }
           
            /*
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);
            string basePath = di.Parent.Parent.FullName;
            string path = Path.Combine(basePath, @"SaveFile.txt");
            string[] output = new string[2];
            if (File.Exists(path))
            {
                output = File.ReadAllLines(path);
            }
            return output;
            */
        }
        public void UpdateScoreFromFile()
        {
            label3.Text = "";
            GetScoreFromSaveFile();
            totalP1Wins = int.Parse(saveFile[0]);
            totalP2Wins = int.Parse(saveFile[1]);
            label1.Text = "Total P1 wins: " + totalP1Wins;
            label2.Text = "Total P2 wins: " + totalP2Wins;
        }
        public void SaveScore()
        {
            //Serialize here

            saveFile[0] = totalP1Wins.ToString();
            saveFile[1] = totalP2Wins.ToString();

            IFormatter formatter = new BinaryFormatter();
            using(Stream stream= new FileStream("data.db",FileMode.Create,FileAccess.Write))
            {
                formatter.Serialize(stream, saveFile);
            }

            /*
            saveFile[0] = totalP1Wins.ToString();
            saveFile[1] = totalP2Wins.ToString();
            
            DirectoryInfo di = new DirectoryInfo(Environment.CurrentDirectory);
            string basePath = di.Parent.Parent.FullName;
            string path = Path.Combine(basePath, @"SaveFile.txt");

            if (File.Exists(path))
            {
                File.WriteAllLines(path,saveFile);
            }
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fTicTacToe = new FormTicTacToe();
            fTicTacToe.ShowDialog();
            totalP1Wins += fTicTacToe.p1Wins;
            totalP2Wins += fTicTacToe.p2Wins;
            label1.Text = "Total P1 wins: " + totalP1Wins;
            label2.Text = "Total P2 wins: " + totalP2Wins;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fConnect = new FormConnectFour();
            fConnect.ShowDialog();
            totalP1Wins += fConnect.p1Wins;
            totalP2Wins += fConnect.p2Wins;
            label1.Text = "Total P1 wins: " + totalP1Wins;
            label2.Text = "Total P2 wins: " + totalP2Wins;
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveScore();
        }
    }
}
