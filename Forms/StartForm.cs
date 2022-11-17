using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WoodPainting2
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            
        }

        private void StartWindowsMediaPlayerOnPlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                this.startWindowsMediaPlayer.close();
                this.Controls.Remove(startWindowsMediaPlayer);
                MapForm mapForm = new MapForm();
                mapForm.Show(); 
            }
        }

        private void StartFormOnLoad(object sender, EventArgs e)
        {
            RegistryKey myKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Active Setup\\Installed Components\\{22d6f312-b0f6-11d0-94ab-0080c74c7e95}");
            if (myKey.GetValue("IsInstalled").ToString() == "1")
            {
                startWindowsMediaPlayer.URL = Application.StartupPath + "\\" + "Заставка.mp4";
            }
            else
            {
                startWindowsMediaPlayer.Visible = false;
                this.BackgroundImage = new Bitmap(Properties.Resources.Заставка);
                this.BackgroundImageLayout = ImageLayout.Stretch;
                //интервал(1000 = 1 сек).Спустя 8 секунд запустется таймер
                loadTimer.Interval = 8000;
                //запускаем таймер
                loadTimer.Enabled = true;
            }
        }

        private void LoadTimerOnTick(object sender, EventArgs e)
        {
            //останавливаем таймер, иначе появление второй формы будет происходить каждую секундй (или каждые 10 сек, тоесть в зависимости от указаного интервала)
            loadTimer.Enabled = false;
            //вызываем другую форму
            MapForm mapForm = new MapForm();
            mapForm.Show();
        }
    }
}
