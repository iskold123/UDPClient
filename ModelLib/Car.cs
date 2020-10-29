using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib
{
    class Car
    {
        private string _model;
        private string _color;
        private string _registationNumber;

        public Car()
        {
        }

        public Car(string model, string color, string registationNumber)
        {
            _model = model;
            _color = color;
            _registationNumber = registationNumber;
        }

        public string Model
        {
            get => _model;
            set => _model = value;
        }

        public string Color
        {
            get => _color;
            set => _color = value;
        }

        public string RegistationNumber
        {
            get => _registationNumber;
            set => _registationNumber = value;
        }

        public override string ToString()
        {
            return $"{nameof(Model)}: {Model}, {nameof(Color)}: {Color}, {nameof(RegistationNumber)}: {RegistationNumber}";
        }
    }
}
