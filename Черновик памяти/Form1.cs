using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Черновик_памяти
{
    public partial class Form1_roditel : Form
    {
        public Form1_roditel()

        {
            
            InitializeComponent();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            this.UpdateStyles();
            //  Создаем экземпляр новой формы
            Form2 f2 = new Form2();

            // Делаем её дочерней
            f2.MdiParent = this;
            //  Убираем границы, чтобы она выглядела как часть панели
            f2.FormBorderStyle = FormBorderStyle.None;
            f2.Dock = DockStyle.Fill; // Занимает всё пространство
                                      
                                      //  Показываем новую форму
            f2.Show();

            // Закрываем текущую активную форму (если она есть)
            if (this.ActiveMdiChild != null && this.ActiveMdiChild != f2)
            {
                this.ActiveMdiChild.Close(); // Или .Hide(), если форму надо оставить в памяти
            }
        }
    }
}
