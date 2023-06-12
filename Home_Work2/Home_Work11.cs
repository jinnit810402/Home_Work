using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Work2
{
    public partial class Home_Work11 : Form
    {
        private PictureBox pictureBox;
        private Timer timer;
        
        private int xVelocity = 5 ;
        private int yVelocity = 5 ;
        public Home_Work11()
        {
            InitializeComponent();

            pictureBox = new PictureBox();
            
            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

            Controls.Add(pictureBox);
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timer1_Tick;
            timer.Start();



        }
        
       
        

        private void MoveImage()
        {
            pictureBox.Location = new Point(pictureBox.Left + xVelocity, pictureBox.Top + yVelocity);

            if (pictureBox.Left < 0 || pictureBox.Right >= this.ClientSize.Width)
            {
                xVelocity = -xVelocity;
            }

            if (pictureBox.Top < 0 || pictureBox.Bottom >=this.ClientSize.Height)
            {
                yVelocity = -yVelocity;
            }
           
        }
        private void Home_Work11_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            MoveImage();
        }

        

        private void Home_Work11_MouseMove(object sender, MouseEventArgs e)
        {
           
             this.Close();
        }

        private void Home_Work11_KeyDown(object sender, KeyEventArgs e)
        {
            Application.Exit();//按下任意鍵結束程序
        }
    }
    }
    

