﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using UltimateGarage.DAO;

namespace UltimateGarage
{
    public partial class MANHINHCHINH : Form
    {
        int flag;
        public string tendangnhap { get; set; }

        public MANHINHCHINH()
        {
            InitializeComponent();
        }

        private void MANHINHCHINH_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
