
using Lab11.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab11.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operacions : ContentPage
    {
        public Operacions()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelOperaciones();
        }
    }
}