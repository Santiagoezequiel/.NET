using System;

namespace GetAnsSet
{


    // TARES: Investigar los PARTIALS de las clases

    class Program
    {
        
        public static void Main(string[] args)
        {

            Personajes personaje1 = new Personajes();
            personaje1.setInfo("Claud",20,"Hombre", 1.78, 75,"Mago", "Baculo");
            Console.WriteLine(personaje1.info());


            Personajes personaje2 = new Personajes();
            personaje2.setInfo("Stefin", 23, "Mujer", 1.54, 45, "Elfo", "Baston magico");
            Console.WriteLine(personaje2.info());

            Personajes personaje3 = new Personajes();
            Console.WriteLine(personaje3.info());

        }
    }
                    // Los setters no tienen return, y hay que identificarlo con VOID.
    class Personajes
    {
        string nombre;
        int edad;
        string sexo;
        double altura;
        double peso;
        string tipo;
        string arma;


        public Personajes()
        {
            nombre = "Sin especificar";
            edad = 0;
            sexo = "Sin especificar";
            altura = 0;
            peso = 0;
            tipo = "Desconocido";
            arma = "No tiene";
        }

        public void setInfo(string setNombre,int setEdad,string setSexo,double setAltura,double setPeso,string setTipo, string setArma)
        {
            this.nombre = setNombre;
            this.edad = setEdad;
            this.sexo = setSexo;
            this.altura = setAltura;
            this.peso = setPeso;
            this.tipo = setTipo;
            this.arma = setArma;
        }


        public string info()
        {
            return  $"PERSONAJES\n" +
                    $"Nombre: {nombre}\n" +
                    $"Edad: {edad} años\n" +
                    $"Sexo: {sexo}\n" +
                    $"Peso: {peso}kg\n" +
                    $"Altura: {altura}m\n" +
                    $"Tipo: {tipo}\n" +
                    $"Armas: {arma}\n\n";
        }
        
    }







}
