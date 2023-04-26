﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team3MiddleSchool
{
    public partial class frmHelp : Form
    {
        public frmHelp(string url)
        {
            InitializeComponent();
            wbHelp.Url = new Uri(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, url));
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}