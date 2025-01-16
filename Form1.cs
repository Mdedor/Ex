using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex
{
    public partial class Form1 : Form
    {
        
        int pbWidth;
        int pbHeight;
       
        PictureBox pb = new PictureBox();
        Label labelPods = new Label();
        Random Random = new Random();
        string capcha;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbHeight = pictureBox2.Height;
            pbWidth = pictureBox2.Width;
            edit();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "user" && textBox2.Text == "user")
            {
                main main = new main();
                main.Show();
                this.Hide();
            }
        }
        void edit()
        {
            string alfEng = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz1234567890";
            char[] masAlf = alfEng.ToCharArray();
            using (Bitmap bitmap = new Bitmap(((Point)textBox1.Size).X, 200))
            {

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {

                    graphics.Clear(Color.BlueViolet);


                    using (Brush brush = new SolidBrush(Color.Red))
                    {
                        graphics.FillRectangle(brush, pbWidth, pbHeight, pbWidth, pbHeight);
                    }

                    using (Font font = new Font("Comic Sans MS", 24))
                    {
                        using (Brush brush = new SolidBrush(Color.Black))
                        {
                            int x = 10;
                            int y = 10;
                            int xx;
                            int yy;
                            Pen pen = new Pen(Color.Black, 1);
                            Pen pena = new Pen(Color.Black, 4);
                            for (int i = 0; i < Random.Next(4, 6); i++)
                            {
                                char mas = masAlf[Random.Next(0, masAlf.Length - 1)];
                                graphics.DrawString($"{mas}", font, brush, new PointF(x, y));

                                xx = x + 5;
                                yy = y + 25;
                                x += Random.Next(24, 60);
                                y = Random.Next(0, pbHeight - 40);
                                graphics.DrawLine(pena, new PointF(xx, yy), new PointF(x + 5, y + 25));


                                capcha += mas.ToString();
                            }
                            


                        }
                    }
                }


                pictureBox2.Image = (Bitmap)bitmap.Clone();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
