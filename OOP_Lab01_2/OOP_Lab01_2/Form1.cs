using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOP_Lab01_2
{
    public partial class Form1 : Form
    {
        private static List<int> collection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                collection = new List<int>();
                int size = int.Parse(inputField.Text);

                Random rnd = new Random();
                if(listBox1.Items.Count != 0)
                    listBox1.Items.Clear();

                for (int i = 0; i < size; i++)
                    collection.Add(rnd.Next(1, 100));

                foreach(int item in collection)
                    listBox1.Items.Add(item); 
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }  
        }

        private void btnSortUp_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            collection.Sort();
            foreach (int item in collection)
                listBox1.Items.Add(item);
        }

        private void btnSortDown_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            collection.Sort();
            collection.Reverse();
            foreach (int item in collection)
                listBox1.Items.Add(item);
        }

        private void btnRequest1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(collection.Max(i => i).ToString());
        }

        private void btnRequest2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(collection.Min(i => i).ToString());
        }

        private void btnRequest3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(collection.Average(i => i).ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
