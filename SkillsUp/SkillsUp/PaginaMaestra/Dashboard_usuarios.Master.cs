﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SkillsUp.PaginaMaestra
{
    public partial class Dashboard_usuarios : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //mandamos la fecha a el label
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}