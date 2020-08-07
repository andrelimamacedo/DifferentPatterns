using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifferentPatterns
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int>  dic = getDiffOccurrencies("zf3kabxcde224lkzf3mabxc51+crsdtzf3nab=", 3);
        }

        public List<KeyValuePair<string, int>> getResult(Dictionary<string, int> dic)
        {
            List<KeyValuePair<string, int>> result = new List<KeyValuePair<string, int>>();
            foreach (KeyValuePair<string, int> entry in dic)
            {
                if (entry.Value > 1)
                {
                    result.Add(new KeyValuePair<string, int>(entry.Key,entry.Value));
                }
            }
            return result;

        }

        public Dictionary<string,int> getDiffOccurrencies(string s,int size)
        {
            if(size <= s.Length)
            {
                return null;
            }
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int index = 0;
            string subString = "";
            while (index <= (s.Length - size))
            {
                subString = s.Substring(index, size);
                if (!dic.ContainsKey(subString)){
                    dic.Add(subString, 1);
                }
                else
                {
                    dic[subString]++;
                }
                index++;
            }
            return dic;
        }
    }
}
