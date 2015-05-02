using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Diagnostics;
using MessageBox = System.Windows.MessageBox;

namespace wpfTimer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer dispatcherTimerForTick = new System.Windows.Threading.DispatcherTimer();
        System.Windows.Threading.DispatcherTimer dispatcherTimerForShutdown = new System.Windows.Threading.DispatcherTimer();
        TimeSpan span = new TimeSpan();

        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Normal;
            System.Windows.Forms.NotifyIcon ni = new System.Windows.Forms.NotifyIcon();
            ni.Icon = new System.Drawing.Icon("sleep.ico"); 
            ni.Visible = true;
            ni.DoubleClick +=
                delegate(object sender, EventArgs args)
                {
                    this.Show();
                    this.WindowState = WindowState.Normal;
                }; 
        }

        protected override void OnStateChanged(EventArgs e)
        {
            if (WindowState == WindowState.Minimized)
                this.Hide();

            base.OnStateChanged(e);
        }

        private void btnStart_Click(object sender, RoutedEventArgs e)
        {

            dispatcherTimerForTick.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimerForTick.Interval = new TimeSpan(0, 0, 1);

            int hours = txtHours.Text.toIntegerFromStringValue();
            int mins = txtMins.Text.toIntegerFromStringValue();
            int seconds = txtSeconds.Text.toIntegerFromStringValue();
            if (hours == 0 && mins == 0 && seconds == 0)
            {
                MessageBox.Show("Lütfen en az bir tanesini doldurunuz");
                return;
            }

            dispatcherTimerForShutdown.Tick += new EventHandler(dispatcherTimer_Shutdown);
            dispatcherTimerForShutdown.Interval = new TimeSpan(hours, mins, seconds);
            span = new TimeSpan(hours, mins, seconds);

            dispatcherTimerForTick.Start();
            dispatcherTimerForShutdown.Start();
        }

        private void dispatcherTimer_Shutdown(object sender, EventArgs e)
        {
            dispatcherTimerForTick.Stop();
            dispatcherTimerForShutdown.Stop();
            Process.Start("shutdown", "/s /t 0");
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            span = span.Subtract(new TimeSpan(0,0,1));
            lblSeconds.Content = string.Format("Remaining Time =  {0} : {1} : {2}", span.Hours, span.Minutes, span.Seconds);
            CommandManager.InvalidateRequerySuggested();
        }

        private void isTextInputForHour(object sender, TextCompositionEventArgs e)
        {
            e.Handled = TimerHelper.isNumberControl(e.Text);
        }
        private void isTextInputForMin(object sender, TextCompositionEventArgs e)
        {
            e.Handled = TimerHelper.isNumberControl(e.Text);
        }
        private void isTextInputForSecond(object sender, TextCompositionEventArgs e)
        {
            e.Handled = TimerHelper.isNumberControl(e.Text);
        }

        private void btnStop_Click(object sender, RoutedEventArgs e)
        {
            clearAll();
        }

        private void clearAll()
        {
            txtHours.Text = "";
            txtMins.Text = "";
            txtSeconds.Text = "";
            lblSeconds.Content = "";
            dispatcherTimerForShutdown.Stop();
            dispatcherTimerForTick.Stop();
        }
    }
}
