using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EdadViewModel.ViewModels
{
    internal class EdadVM : INotifyPropertyChanged
    {
        #region Atributos
        private DateTime fechaNac;
        private int edad;
        #endregion

        #region Propiedades Públicas
        public DateTime FechaNac
        {
            get { return fechaNac; } 
            set { 
                fechaNac = value;
                NotifyPropertyChanged("Edad");
            }
        }

        public int Edad
        {
            get
            {
                int dia = DateTime.Now.Day;
                int mes = DateTime.Now.Month;
                int anio = DateTime.Now.Year;

                 edad = anio - fechaNac.Year;

                if (mes == fechaNac.Month)
                {
                    if (dia < fechaNac.Day)
                    {
                        edad -= 1;
                    }
                }else if (mes < fechaNac.Month)
                {
                    edad -= 1;
                }
                    return edad;
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
