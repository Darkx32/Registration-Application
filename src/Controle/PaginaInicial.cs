﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System_Application
{
    public partial class PaginaInicial : UserControl
    {
        public PaginaInicial()
        {
            InitializeComponent();
            Version.Text =  Resource1.version + "v";
        }
    }
}