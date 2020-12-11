using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REPTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Split();
        }

        private void Split()
        {
            string line;
            int counter = 0;
            int id = 0;
            System.IO.StreamReader file = new System.IO.StreamReader("..\\DadesClient.edi");
            while ((line = file.ReadLine())!=null)
            {
                counter++;
            }

            string[] array = new string[counter];

            int arrayCounter = 0;

            file = new System.IO.StreamReader("..\\DadesClients.edi");
            while ((line = file.ReadLine()) != null)
            {
                array[arrayCounter] = line;
                arrayCounter++;
            }
            for (int i=0;i< array.Length;i++)
            {
                string[] linea = array[i].Split('|');
                if (linea[0] == "CON")
                {
                    id++;
                    NewContact c = new NewContact
                    {
                        Name = linea[1],
                        BirthDate = linea[2]
                    };
                    dataGridView1.
                }
                else
                {
                    ContactSystem s = new ContactSystem
                    {

                    }
                }
            }
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
