using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Interval.Logic.Project
{
    class Timer
    {
        private DispatcherTimer dispatcherTimer = new DispatcherTimer();
        public int seconds { get; set; } = 0;
        private TextBox timer_text;
        public Boolean running { get; set; } = false;


        public void DispatcherStart(TextBox timer_text)
        {
            this.timer_text = timer_text;
            dispatcherTimer.Tick += dispatcherTimer_Tick;
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
            running = true;
        }

        public void DispatcherStop()
        {
            dispatcherTimer.Stop();
            running = false;
        }

        void dispatcherTimer_Tick(object sender, object e)
        {
            seconds += 1;
            timer_text.Text = StringTimeFormatter();
        }

        private String StringTimeFormatter()
        {
            String hourZero = "";
            String minZero = "";
            String secZero = "";
            if (getHours() <= 9) hourZero = "0";
            if (getMinutes() <= 9) minZero = "0";
            if (seconds <= 9) secZero = "0";

            String strTime = hourZero + getHours() + ":" + minZero + getMinutes().ToString() + ":" + secZero + seconds.ToString();

            return strTime;
        }

        private int getHours()
        {
            return seconds / 3600;
        }

        private int getMinutes()
        {
            return seconds / 60;
        }

    }
    }
