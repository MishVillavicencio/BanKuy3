﻿using BanKuy.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BanKuy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Perfil : ContentPage
    {
       
        public Perfil()
        {
            InitializeComponent();
        }
       
        private void btnFingerprint_Clicked(object sender, EventArgs e)
        {

        }
    }
}