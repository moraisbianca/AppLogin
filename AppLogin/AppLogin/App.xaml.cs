using AppLogin.Model;
using AppLogin.View;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppLogin
{
    public partial class App : Application
    {   
        
        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "aluno@etec",
                Nome = "Aluno",
                Senha = "123"
            },

            new DadosUsuario()
            {
                Email = "professor@etec",
                Nome = "Professor",
                Senha = "456"
            }
        };

        public App()
        {
            InitializeComponent();

                MainPage = new Protegida();
          
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

    }
}
