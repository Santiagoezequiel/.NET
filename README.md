# C#

## METODOS (FUNCIONES)

Primero ingresamos el TIPO DE VALOR QUE DEVOLVERA el metodo, luego el nombre del metodo seguido
de un parentesis con los (PARAMETRO) que recibirá el metodo, luego tendremos el cuerpo del Metodo.

    int  sumaNumeros() {
    	int num1 = 7;
    	int num2= 3;
    	int resultado = num1 + num2;
    	return resultado;
    }

El metodo:

- No se ejecutará hasta que se llame.
- Todos los metodos irán dentro de una clase.
- Se debe especificar el tipo devuelto y los parametros.
- No hay distinción entre metodos y funciones. En c# son lo mismo.

**Este metodo dará un error, ya que double + int = double, pero en el metodo estamos especificando que debe devolver un tipo de dato INT, asi que dará error por contradiccion, deberiamos especificar (static double sumaDoubleEInt)**
static int sumaDoubleEInt(double num1, int num2)
{
return num1 + num 2
}

Si un metodo te ocupa mas que el espacio en tu pantalla, seguramente esté mal hecho, deberiamos aplicar la Modularizacion

Este codigo no está mal pero para el simple uso que se le dará es mejor optimizarlo mas.

    static double sumaNumeros(double a, double b)
    {
    	resultado= a + b;
    	return resultado;
    }

Esta seria la solucion mas sencilla, y resume varias lineas de codigo en una

    static double sumarNumeros(double a, double b) => a + b;

### Variables definidas en la clase

Se pueden utilizar variables y valores en todos los metodos de una clase, si estos son definidos en la clase.

    class Clase
    {
    	int Variable = 10;
    	string Variable2 = "Vida";


    	static void Metodo1(){}
    	static void Metodo2(){}
    	static void Metodo3(){}
    	static void Metodo4(){}


    }

### SOBRECARGA DE METODOS

Comunmente no puedo tener dos objetos, metodos, variables, constantes o etc, en el mismo arcgivo con el mismo nombre.
Pero con los metodos se puede, puedo tener varios metodos dentro de una clase con el mismo nombre, pero estos deben cumplir con una condicion:

- No deben recibir los mismos parametros
- Deben diferenciarse en cantidad de parametros o tipos de parametros

  static int Metodo(int, int)................................ Esto dará
  static int Metodo(int, int)................................. un error

  static int Metodo(int, int)..................................Esto está
  static int Metodo(int, int, int)...............................bien!

  static string Metodo(string, string) ........................Esto está
  static void Metodo(int, int) ..................................bien!

### CONSEJOS

Siempre revizar el tipo que debe devolver el metodo, es la principal causa de errores.

