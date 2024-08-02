using System;

namespace Aulas_POO
{
    public class Motocicleta
    {
        // Atributos
        private string _marca;
        private string _modelo;

        // Propriedades
        public string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }
        public string Modelo
        {
            get { return _modelo; }
            set { _modelo = value; }
        }

        // Métodos
        public void Acelerar()
        {
            Console.WriteLine($"{_marca} {_modelo} está acelerando...");
        }

        // Sobrecarga de métodos
        public void Frenar()
        {
            Console.WriteLine($"{_marca} {_modelo} está frenando...");
        }
        public bool Frenar(string tipo)
        {
            Console.WriteLine($"{_marca} {_modelo} está frenando com {tipo}...");
            return true;
        }

        // Método sobrecarga
        public virtual void EmitirSom()
        {
            Console.WriteLine($"{_marca} {_modelo} está emitindo som do motor...");
        }

        // Método sobrescrita
        public virtual void Abastecer()
        {
            Console.WriteLine($"{_marca} {_modelo} está sendo abastecida...");
        }

        // Construtor
        public Motocicleta(string marca, string modelo)
        {
            _marca = marca;
            _modelo = modelo;
        }

        // Classe filha (subclasse)
        public class Esportiva : Motocicleta
        {
            private int _cilindradas;
            private string _cor;

            public int Cilindradas
            {
                get { return _cilindradas; }
                set { _cilindradas = value; }
            }

            public string Cor
            {
                get { return _cor; }
                set { _cor = value; }
            }

            public void Empinar()
            {
                Console.WriteLine($"{Marca} {Modelo} está empinando...");
            }

            // Construtor da subclasse
            public Esportiva(string marca, string modelo, int cilindradas, string cor)
                : base(marca, modelo)
            {
                _cilindradas = cilindradas;
                _cor = cor;
            }

            // Sobrescrita de método
            public override void EmitirSom()
            {
                Console.WriteLine($"{Marca} {Modelo} está emitindo um som esportivo...");
            }
            public override void Abastecer()
            {
                Console.WriteLine($"{Marca} {Modelo} está sendo abastecida com combustível premium...");
            }
        }
    }
}
