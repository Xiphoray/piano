using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace piano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox26.Parent = pictureBox1;

        }



        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\1.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox2.Show();

        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\2.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.Show();
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox4.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\3.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox4.Show();
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox5.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\4.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox5.Show();
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\5.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox6.Show();
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\6.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox7.Show();
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox8.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\7.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox8.Show();
        }

        private void pictureBox21_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox21.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\1#.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox21_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox21.Show();
        }

        private void pictureBox22_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox22.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\2#.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox22_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox22.Show();
        }

        private void pictureBox23_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox23.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\4#.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox23_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox23.Show();
        }

        private void pictureBox24_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox24.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\5#.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox24_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox24.Show();
        }

        private void pictureBox25_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox25.Hide();
            SoundPlayer s1 = new SoundPlayer();
            s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\6#.wav";
            s1.Load();
            s1.Play();
        }

        private void pictureBox25_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox25.Show();
        }

        private void pictureBox26_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                pictureBox2.Hide();
                SoundPlayer s1 = new SoundPlayer();
                s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\1.wav";
                s1.Load();
                s1.Play();
            }
            if (e.KeyCode == Keys.S)
            {
                pictureBox3.Hide();
                SoundPlayer s1 = new SoundPlayer();
                s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\2.wav";
                s1.Load();
                s1.Play();
            }
            if (e.KeyCode == Keys.D)
            {
                pictureBox4.Hide();
                SoundPlayer s1 = new SoundPlayer();
                s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\3.wav";
                s1.Load();
                s1.Play();
            }
            if (e.KeyCode == Keys.F)
            {
                pictureBox5.Hide();
                SoundPlayer s1 = new SoundPlayer();
                s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\4.wav";
                s1.Load();
                s1.Play();
            }
            if (e.KeyCode == Keys.G)
            {
                pictureBox6.Hide();
                SoundPlayer s1 = new SoundPlayer();
                s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\5.wav";
                s1.Load();
                s1.Play();
            }
            if (e.KeyCode == Keys.H)
            {
                pictureBox7.Hide();
                SoundPlayer s1 = new SoundPlayer();
                s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\6.wav";
                s1.Load();
                s1.Play();
            }
            if (e.KeyCode == Keys.J)
            {
                pictureBox8.Hide();
                SoundPlayer s1 = new SoundPlayer();
                s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\7.wav";
                s1.Load();
                s1.Play();
            }

            

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            pictureBox5.Show();
            pictureBox6.Show();
            pictureBox7.Show();
            pictureBox8.Show();
            pictureBox21.Show();
            pictureBox22.Show();
            pictureBox23.Show();
            pictureBox24.Show();
            pictureBox25.Show();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 'a')
            //{
            //    pictureBox2.Hide();
            //    SoundPlayer s1 = new SoundPlayer();
            //    s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\1.wav";
            //    s1.Load();
            //    s1.Play();
            //}
            //if (e.KeyChar == 's')
            //{
            //    pictureBox3.Hide();
            //    SoundPlayer s1 = new SoundPlayer();
            //    s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\2.wav";
            //    s1.Load();
            //    s1.Play();
            //}
            //if (e.KeyChar == 'd')
            //{
            //    pictureBox4.Hide();
            //    SoundPlayer s1 = new SoundPlayer();
            //    s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\3.wav";
            //    s1.Load();
            //    s1.Play();
            //}
            //if (e.KeyChar == 'f')
            //{
            //    pictureBox5.Hide();
            //    SoundPlayer s1 = new SoundPlayer();
            //    s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\4.wav";
            //    s1.Load();
            //    s1.Play();
            //}
            //if (e.KeyChar == 'g')
            //{
            //    pictureBox6.Hide();
            //    SoundPlayer s1 = new SoundPlayer();
            //    s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\5.wav";
            //    s1.Load();
            //    s1.Play();
            //}
            //if (e.KeyChar == 'h')
            //{
            //    pictureBox7.Hide();
            //    SoundPlayer s1 = new SoundPlayer();
            //    s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\6.wav";
            //    s1.Load();
            //    s1.Play();
            //}
            //if (e.KeyChar == 'j')
            //{
            //    pictureBox8.Hide();
            //    SoundPlayer s1 = new SoundPlayer();
            //    s1.SoundLocation = @"D:\project C#\piano\piano\var\sound\7.wav";
            //    s1.Load();
            //    s1.Play();
            //}
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
