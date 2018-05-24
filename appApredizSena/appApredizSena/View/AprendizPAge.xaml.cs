using appApredizSena.ViewModel;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appApredizSena.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AprendizPAge : ContentPage
    {
        private object lstName;

        public AprendizPAge()
        {
            InitializeComponent();
            this.BindingContext = new AprendizViewModel();
            lstName.ItemSelected += LstName_ItemSelected;
			
        }


    }
}
