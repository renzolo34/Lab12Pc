using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Lab11.ViewModels
{
    public class ViewModelOperaciones : ViewModelBase
    {
        private double baseRectangulo;
        public double BaseRectangulo
        {
            get { return baseRectangulo; }
            set
            {
                if (baseRectangulo != value)
                {
                    baseRectangulo = value;
                    OnPropertyChanged();
                }
            }
        }

        private double alturaRectangulo;
        public double AlturaRectangulo
        {
            get { return alturaRectangulo; }
            set
            {
                if (alturaRectangulo != value)
                {
                    alturaRectangulo = value;
                    OnPropertyChanged();
                }
            }
        }

        private double area;
        public double Area
        {
            get { return area; }
            set
            {
                if (area != value)
                {
                    area = value;
                    OnPropertyChanged();
                }
            }
        }

        private double perimetro;
        public double Perimetro
        {
            get { return perimetro; }
            set
            {
                if (perimetro != value)
                {
                    perimetro = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand CalcularAreaCommand { protected set; get; }
        public ICommand CalcularPerimetroCommand { protected set; get; }

        public ViewModelOperaciones()
        {
            CalcularAreaCommand = new Command(CalcularArea);
            CalcularPerimetroCommand = new Command(CalcularPerimetro);
        }

        private void CalcularArea()
        {
            Area = BaseRectangulo * AlturaRectangulo;
        }

        private void CalcularPerimetro()
        {
            Perimetro = 2 * (BaseRectangulo + AlturaRectangulo);
        }
    }

}
