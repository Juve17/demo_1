using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace demo_1.Views.Components
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CBoton : ContentView
	{
		public CBoton ()
		{
			InitializeComponent ();
		}
		//personalizamos el widget 
		public static readonly BindableProperty TextProperty =BindableProperty.Create(nameof(Text), typeof(string), typeof(CBoton), default(string), propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (CBoton)bindable;
            control.button.Text = (string)newValue;
        });
        public string Text
		{
			get=>(string)GetValue(TextProperty); set => SetValue(TextProperty, value);
        }
        
    }
}