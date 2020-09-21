using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ToolbarDemo
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolbarDemoPage : ContentPage
    {
        public ToolbarDemoPage()
        {
            InitializeComponent();
        }

        void OnToolbarItemClicked(object sender, EventArgs args)
        {
            ToolbarItem toolbarItem = (ToolbarItem)sender;
            label.Text = "ToolbarItem '" + toolbarItem.Text + "' clicked";
        }
    }
}