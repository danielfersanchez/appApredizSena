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
    public partial class DetalleAprendiz : ContentPage
    {
     public DetalleAprendiz(DetalleAprendiz aprendizseleccionado)
        {
            InitializeComponent();
            this.BindingContext = aprendizseleccionado;
        }
    
        
        
            
    }
}
