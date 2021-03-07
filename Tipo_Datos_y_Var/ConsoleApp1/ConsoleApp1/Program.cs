using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables de tipo numero su unica diferencia es su capacidad de almacenamiento
            byte numero = 255; //Permite guardar un numero hasta 255 sirve para optimizar espacio en memoria, no permite guardar numeros negativos
            sbyte numero1 = -128;//Byte quue permite guardar numeros negativos hasta el -128
            sbyte numero2 = 127;//Permite guardar numeros negativos hasta el 127
            int numero3 = 2147000;//Tipod e dato de 32 bits que permite guardar hasta 2147000
            uint numero4 = 128;//Solo permite valores positivos
            long numero5 = 2325345;//permite valores mas largos que el int permite trillones de largos
            ulong numero6 = 865378465;//solo permite valores positivos
            float numero7 = 4534.34543f;//Permite valores decimales poniendole la f al final del numero permite solo 4 bits 
            double numero8 = 234231.2134124d;//Permite valores decimales mas grandes permite 8 bits
            decimal numero9 = 143124.134234m;//Permite hasta 16 bits
            char Caracter = 'f';//permite almacenar 2 bits que seria 1 sola letra
            string texto = "hola";//permite almacenar cadenas de char
            DateTime dateime = DateTime.Now;//Almacena la fecha actual;
            bool SiONo = true;//Almacena valores logicos de verdadero falso 
            int? numero10 = null;//Se pone el ? despues del tipo de dato para poder inicializar una variable como nula
            var variablex = "Hola que tal?";// asigna automaticamente el tipo de dato y el tamaño adecuado del mismo una vez que esta definido funciona como la primera asignacion que tuvo para siempre, solo funciona en local, dentro de los metodos.
            object persona = new { nombre = "Diego", apellido = "Torres" };//Sirve para crear objetos anonimos que no se necesitaria una clae para crearlo
        }   
    }
}
