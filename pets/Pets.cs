using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pets
{
    public partial class Pets : Form
    {
        public Pets()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDefault();
        }

        private void LoadDefault()
        {
          

           
           
        }

        private void bird_CheckedChanged(object sender, EventArgs e)
        {
            grp_bird.BackgroundImage = global::pets.Properties.Resources.bird;
        }

        private void ClearAll()
        {
            

           
        }

        private void cat_CheckedChanged(object sender, EventArgs e)
        {
            grp_bird.BackgroundImage = global::pets.Properties.Resources.cat;
        }

        private void dog_CheckedChanged(object sender, EventArgs e)
        {
            grp_bird.BackgroundImage = global::pets.Properties.Resources.dog;
        }

        private void rabbit_CheckedChanged(object sender, EventArgs e)
        {
            grp_bird.BackgroundImage = global::pets.Properties.Resources.rabbit;
        }

        private void pig_CheckedChanged(object sender, EventArgs e)
        {
            grp_bird.BackgroundImage = global::pets.Properties.Resources.pig;
        }
    }
}
