using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Laba1
{
    public partial class CollectionBuilderForm : Form
    {
        public CollectionBuilderForm()
        {
            InitializeComponent();
        }
        
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            listBoxCollection.Text = "";
            int count;
            if (int.TryParse(textBoxCount.Text, out count) == true)
            {
                listBoxCollection.Items.Clear();
                
                var randomizer = new Random();
                for (int i = 0; i < count; i++)
                {
                    listBoxCollection.Items.Add(randomizer.Next(0,1000));
                }
                
            }
        }

        private void ButtonAscending_Click(object sender, EventArgs e)
        {
            var list = listBoxCollection.Items.Cast<int>().ToList();
            list.Sort((a,b)=> a-b);
            listBoxCollection.Items.Clear();
            foreach (int item in list)
            {
                listBoxCollection.Items.Add(item);
            }
            
        }
        private void buttonDescending_Click(object sender, EventArgs e)
        {
            var list = listBoxCollection.Items.Cast<int>().ToList();
            list.Sort((a,b)=> b-a);
            listBoxCollection.Items.Clear();
            foreach (int item in list)
            {
                listBoxCollection.Items.Add(item);
            }
        }
        
        private void buttonFirstQuery_Click(object sender, EventArgs e)
        {
            var listMax = listBoxCollection.Items.Cast<int>().ToList().Max();
            
            listBoxQuery.Items.Clear();
            listBoxQuery.Items.Add(listMax);
        }
        
        private void buttonSecondQuery_Click(object sender, EventArgs e)
        {
            var listMin = listBoxCollection.Items.Cast<int>().ToList().Min();
            
            listBoxQuery.Items.Clear();
            listBoxQuery.Items.Add(listMin);
        }
        
        private void buttonThirdQuery_Click(object sender, EventArgs e)
        {
            var queryList = listBoxCollection.Items.Cast<int>().ToList().Where(x=>x>500);
            
            listBoxQuery.Items.Clear();
            foreach (var item in queryList)
            {
                listBoxQuery.Items.Add(item);
            }
           
        }
    }
}