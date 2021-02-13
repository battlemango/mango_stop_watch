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
        public Form1()
        {
            InitializeComponent();
            initViews();
        }

        private void initViews()
        {
            btn_start.Text = CommonConstants.BUTTON_NAME_START;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(btn_start.Text == CommonConstants.BUTTON_NAME_START)
            {
                btn_start.Text = CommonConstants.BUTTON_NAME_STOP;
                lbl_watch_display.Text = CommonConstants.BUTTON_NAME_STOP;
            }
            else
            {
                btn_start.Text = CommonConstants.BUTTON_NAME_START;
                lbl_watch_display.Text = CommonConstants.BUTTON_NAME_START;
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

        }
    }
}
