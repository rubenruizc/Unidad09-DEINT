using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Models
{
    public class clsPersona : INotifyPropertyChanged
    {

        #region Atributos
        private string nombre = "Rubén";
        private string apellido;
        #endregion

        #region Propiedades Públicas
        public String Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                NotifyPropertyChanged("Nombre");
            }
        }

        public String Apellido
        {
            get { return apellido; }
            set
            {
                apellido = value;
                NotifyPropertyChanged("Apellido");
            }
        }

        #endregion

        #region Notify
        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
