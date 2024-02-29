using System.ComponentModel;
using System.Windows.Input;

namespace MVVM_sin_libreria.ViewModels
{
    //INotifyPropertyChanged: Se utiliza en IU para notificar a XAML cuando las propiedades de un objeto han cambiado
    internal class MainPageViewModel : INotifyPropertyChanged
    {
        private int _count;

        public int Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Count"));

            }
        }

        // notificar el cambio de propiedad a la interfaz
        public event PropertyChangedEventHandler? PropertyChanged;

        //Nos permite ejecutar acciones
        public ICommand IncrementarCommand => new Command(Incrementar);

        public void Incrementar()
        {
            Count++;
        }
    }
}
