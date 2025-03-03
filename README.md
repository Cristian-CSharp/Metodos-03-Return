# Método Return
Los métodos `return` en C# son aquellos que devuelven un valor al ser llamados. A diferencia de los métodos `void`, que no devuelven nada, los métodos `return` siempre especifican un **tipo de dato de retorno** y deben incluir la palabra clave `return` dentro de su cuerpo.

## Estructura de un Método con `return`
```c#
tipoDato NombreMetodo(parámetros)
{
    // Lógica del método
    return valor;
}
```
Donde:

-   `tipoDato`: Especifica el tipo de dato que devuelve el método (int, double, string, etc.).
-   `NombreMetodo`: Es el nombre del método.
-   `parámetros`: Son los valores que el método recibe al ser llamado (opcional).
-   `return valor;`: Devuelve un valor del tipo especificado.
---

###  📝 **Ejemplos de Métodos con `return`**

#### *Ejemplo 1: Método sin parámetros*
Un método que devuelve un número entero sin recibir parámetros.
```c#
static int ObtenerNumero()
{
    return 10;
}

static void Main()
{
    int numero = ObtenerNumero();
    Console.WriteLine("El número es: " + numero);
}
```

#### *Ejemplo 2: Método con parámetros*
Un método que recibe dos números y devuelve la suma.
```c#
static int Sumar(int a, int b)
{
    return a + b;
}

static void Main()
{
    int resultado = Sumar(5, 7);
    Console.WriteLine("La suma es: " + resultado);
}
```

#### *Ejemplo 3: Método que devuelve una cadena*
Un método que recibe un nombre y devuelve un saludo.
```c#
static string Saludar(string nombre)
{
    return "Hola, " + nombre + "!";
}

static void Main()
{
    string mensaje = Saludar("Cristian");
    Console.WriteLine(mensaje);
}
```

## 🏋 Ejercicios :
 **** 🖥️ Ejercicio 1: Validación de Números Primos****
 
Crea un método que reciba un número entero y devuelva `true` si es primo y `false` si no lo es.

** 🖥️ Ejercicio 2: Conversión de Temperatura**

Crea un método que reciba una temperatura en grados Celsius y devuelva la temperatura equivalente en Fahrenheit.

** 🖥️ Ejercicio 3: Contar Palabras en una Cadena**

Crea un método que reciba una cadena de texto y devuelva cuántas palabras tiene.

---
🔥 Importante
Estos ejercicios, ya están resueltos y los puedes encontrar en este repositorios, cada ejercicio esta en una carpeta...
---
