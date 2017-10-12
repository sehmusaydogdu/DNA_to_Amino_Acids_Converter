using DNA_to_aa_Converter.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNA_to_aa_Converter
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            Data = fileReader.DataSource();
        }

        List<Information> Data;
        bool IsFind = true;
     
 

       
        private void dna_to_amino_Click(object sender, EventArgs e)
        {
            txtProtein.Clear();

            if (string.IsNullOrEmpty(txtDNA.Text))
                MessageBox.Show("Please,choose a file or you fill in the field");
            else
            {
                txtDNA.Text=txtDNA.Text.ToUpper();
                string txtDNAvalue = txtDNA.Text;
                string newtxt = string.Empty;

                if (txtDNAvalue.Count() % 3 == 0)
                {
                    for (int i = 0; i < txtDNAvalue.Count();)
                    {
                        for (int j = 0; j < 3; j++) //3 er 3 er olarak seçeceğim.
                            newtxt += txtDNAvalue[i++];

                        foreach (Information item in Data)
                        {
                            if (item.Values.Contains(newtxt))
                            {
                                txtProtein.Text += item.Key;
                                IsFind = false;
                            }
                                
                        }
                        newtxt = string.Empty;
                    }
                    if (IsFind)
                        MessageBox.Show("Sequence Not Found");

                    else
                        IsFind = true;
                }
                else
                    MessageBox.Show("Check the DNA sequence , Can not leave 3");
            }

        }

        private void amino_to_dna_Click(object sender, EventArgs e)
        {
            txtDNA.Clear();

            if (string.IsNullOrEmpty(txtProtein.Text))
                MessageBox.Show("Please,choose a file or you fill in the field");
            else
            {
                    txtProtein.Text=txtProtein.Text.ToUpper();
                    string txtproteinValue = txtProtein.Text;
                    foreach (char value in txtproteinValue)
                    {
                        foreach (Information item in Data)
                        {
                            if (value.ToString().Equals(item.Key))
                            {
                                txtDNA.Text += item.Values[0];
                                IsFind = false;
                                break;
                            }
                        }
                    }
                if (IsFind)
                    MessageBox.Show("Sequence Not Found");
                else
                    IsFind = true;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDNA.Clear();
            txtProtein.Clear();
        }

        private void btnfileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            DialogResult result = open.ShowDialog();

            if (result == DialogResult.OK)
            {
                if (radioButton2.Checked || radioButton1.Checked)
                {

                    if (radioButton1.Checked)
                        txtProtein.Text = File.ReadAllText(open.FileName);
                    if (radioButton2.Checked)
                        txtDNA.Text = File.ReadAllText(open.FileName);
                }
                else
                    MessageBox.Show("Make your choice");
            }
            else
                MessageBox.Show("Select a file");


        }
    }
}
