﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HslControlsDemo
{
    public partial class FormMotor : FormContent
    {
        public FormMotor( )
        {
            InitializeComponent( );
        }

        private void HslMotor9_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
