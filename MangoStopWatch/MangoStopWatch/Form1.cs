using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MangoStopWatch
{
    public partial class Form1 : Form
    {
        private Timer mTimer;
        private StopWatchManager mStopWatchManager;

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            mStopWatchManager = new StopWatchManager();
            mTimer = new Timer();
            mTimer.Interval = 50;
            mTimer.Tick += new EventHandler(updateHandler);

            btn_start.Text = CommonConstants.BUTTON_NAME_START;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(btn_start.Text == CommonConstants.BUTTON_NAME_START)
            {
                btn_start.Text = CommonConstants.BUTTON_NAME_STOP;
                mTimer.Start();
                mStopWatchManager.start();
            }
            else
            {
                btn_start.Text = CommonConstants.BUTTON_NAME_START;
                mTimer.Stop();
                mStopWatchManager.stop();
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            mTimer.Stop();
            mStopWatchManager.reset();
        }

        private void updateHandler(object sender, EventArgs e)
        {
            lbl_watch_display.Text = mStopWatchManager.getText();
        }
    }
}
