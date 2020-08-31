using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Hello
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class homepage : ContentPage
    {
        public homepage()
        {
            InitializeComponent();
        }
    }
}