using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Phone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveTable = new SaveFileDialog();
            saveTable.Filter = "Документ TXT (*.txt) |*.txt";
            if (saveTable.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileStream file = new FileStream(saveTable.FileName, FileMode.Create);
                    StreamWriter sw = new StreamWriter(file, Encoding.Default);
                    sw.Write(Base.Text);
                    sw.WriteLine();
                    sw.Close();
                }
                catch { }
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openTableAsTXT = new OpenFileDialog();
            openTableAsTXT.Filter = "Документ TXT (*.txt) |*.txt";
            if (openTableAsTXT.ShowDialog() == DialogResult.OK)
            {
                Base.Text = File.ReadAllText(openTableAsTXT.FileName, Encoding.Default);
            }
        }
    }
}
