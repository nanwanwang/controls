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
    public partial class FormClock : FormContent
    {
        public FormClock( )
        {
            InitializeComponent( );
        }

        private void HslClock1_Click( object sender, EventArgs e )
        {
            Control_Click( sender, e );
        }
    }
}
