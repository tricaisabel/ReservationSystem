using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace RezervariHotel
{
    public partial class Form5 : Form
    {
        Bitmap bm;
        Graphics g;
        const int marg = 10;
        Font font1 = new Font(FontFamily.GenericSansSerif, 8, FontStyle.Regular);
        Font font2 = new Font(FontFamily.GenericSansSerif, 4, FontStyle.Regular);
        ColectieRezervari colectie = new ColectieRezervari();
        int procPlatite=0;
        int procNeplatite=0;
        public Form5(ColectieRezervari c)
        {
            InitializeComponent();
            colectie = c;
            int platite = 0;
            int total=0;
            foreach(RezervareOnline r in colectie.Rezervari)
            {
                if (r.Plata) platite++;
                total++;
            }
            procPlatite = platite * 360 / total;
            procNeplatite = 360 - procPlatite;
        }

        private void Form5_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr=e.Graphics;
            Rectangle rec = new Rectangle(new Point(60,80),new Size(300,300));
            gr.DrawPie(new Pen(Color.Red, 3), rec,0,procPlatite);
            gr.FillPie(new SolidBrush(Color.Red), rec, 0, procPlatite);
            gr.DrawPie(new Pen(Color.Blue,3), rec, procPlatite, procNeplatite);
            gr.FillPie(new SolidBrush(Color.Blue), rec, procPlatite, procNeplatite);
            //Legenda
            gr.DrawString("Rezervari platite", font1, new SolidBrush(Color.Black), new Point(20, 20));
            Pen pen = new Pen(Color.Red, 3);
            Rectangle rec2 = new Rectangle(140,20, 10,10);
            gr.DrawRectangle(pen, rec2);
            gr.FillRectangle(new SolidBrush(Color.Red), rec2);

            gr.DrawString("Rezervari neplatite", font1, new SolidBrush(Color.Black), new Point(20, 40));
            Pen pen2 = new Pen(Color.Blue, 3);
            Rectangle rec3 = new Rectangle(140, 40, 10, 10);
            gr.DrawRectangle(pen2, rec3);
            gr.FillRectangle(new SolidBrush(Color.Blue), rec3);

        }
    }
}
