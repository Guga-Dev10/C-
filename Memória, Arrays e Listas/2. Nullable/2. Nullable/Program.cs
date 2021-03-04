using System;

namespace _2._Nullable {
    class Program {
        static void Main(string[] args) {

            Nullable<double> x = null;
            double? y = 10;

            // As duas formas querem dizer a mesma coisa, são duas formas de se atribuir
            // o valor Null á um Tipo Valor. que normalmente não aceitaria um valor Null.

            Console.WriteLine(x.GetValueOrDefault());
            // este comando "GetValueOrDefault()" manda pegar o valor de uma variável, se esse valor não 
            // não existir ela manda retornar o valor padrão da variável, no caso do double é o valor zero.
            
            Console.WriteLine(y.GetValueOrDefault()); // irá retornar o valor 10 por ter sido atribuída;

            Console.WriteLine();
            Console.WriteLine(x.HasValue);  // Irá retornar a informação de que há ou não algum valor 
            Console.WriteLine(y.HasValue);  // atribuído em uma variável

            Console.WriteLine();

            // o <var.Value> não irá funcionar se tentar chamar a partir de um objeto que esstá valendo
            // Null. Só podemos usar caso esteja dentro de um If, por exemplo.s

            if (x.HasValue) {
                Console.WriteLine(x.Value);
            }
            else {
                Console.WriteLine("X é Null");
            }
            if (y.HasValue) {
                Console.WriteLine(y.Value);
            }
            else {
                Console.WriteLine("Y é Null");
            }

            // Operador de coalescência Nula

            // Se você quiser atribuir o valor de uma variável com o valor de outra variável
            // e caso você não saiba se o valor atribuído será null ou não
            // você pode usar o operador de coalescência Nula para que o valor atríbuido não seja Null

            double a = x ?? 5; // Não receberá o valor null de x e irá atribuir o valor 5
            double b = y ?? 5; // Irá receber o vaior de Y, pois o valor de Y = 10

            Console.WriteLine();
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
