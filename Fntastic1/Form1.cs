using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fntastic1
{
    public partial class Form1 : Form
    {
        int textLength = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textStart = textBox1.Text.ToLower();
            textLength = textStart.Length;
            int[] freqAlphabet = new int[textLength];
            string[] strokeEnd = new string[textLength];
            char[] strokeStart = textStart.ToCharArray();
            for (int i = 0; i < textLength; i++)
            {
                freqAlphabet[i] = textStart.Count(strokeStart[i]);
            }
            for (int i = 0; i < textLength; i++)
            {
                if (freqAlphabet[i] == 1) strokeEnd[i] = "(";
                else if (freqAlphabet[i] > 1) strokeEnd[i] = ")";
            }
            textBox2.Text = string.Join("", strokeEnd);
        }
    }
}

public static class StringExtensions
{
    public static int Count(this string input, char chr) //we calculate the frequency of using letters in a string
    {
        int count = 0;
        char[] arrayTmp = input.ToCharArray();
        for (int i = 0; i < input.Length; i++)
        {
            if (chr == arrayTmp[i]) count++;
        }
        return count;
    }
}