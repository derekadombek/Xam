using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JustNotes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JustNotesPage : ContentPage
    {
        public JustNotesPage()
        {
            InitializeComponent();

            IDictionary<string, object> properties = Application.Current.Properties;

            if (properties.ContainsKey("text"))
            {
                editor.Text = (string)properties["text"];
            }
        }
        void OnEditorFocused(object sender, FocusEventArgs args)
        {
            if (Device.OS == TargetPlatform.iOS)
            {
                AbsoluteLayout.SetLayoutBounds(editor, new Rectangle(0, 0, 1, 0.5));
            }
        }

        void OnEditorUnfocused(object sender, FocusEventArgs args)
        {
            if (Device.OS == TargetPlatform.iOS)
            {
                AbsoluteLayout.SetLayoutBounds(editor, new Rectangle(0, 0, 1, 1));
            }
        }

        public void OnSleep()
        {
            Application.Current.Properties["text"] = editor.Text;
        }
    }
}