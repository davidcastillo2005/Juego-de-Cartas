namespace Juego_de_Cartas;

class Program
{
    static void Main(string[] args)
    {
        int[] juego = [2, 3, 1, 5, 4];
        int[] salida = Ejecutar(juego);
        for (int i = 0; i < salida.Length; i++)
        {
            System.Console.WriteLine(salida[i]);
        }
    }

    static int[] Ejecutar(int[] juego)
    {
        List<int> lista = [];
        int[] temp = juego;
        for (int i = 1; i <= temp.Length; i++)
        {
            for (int j = 0; j < juego.Length; j++)
            {
                if (i != juego[j])
                {
                    continue;
                }
                lista.Add(j);
                juego = Quitar(juego, j);
                j = -1;
                break;
            }
        }
        return lista.ToArray();
    }

    static int[] Quitar(int[] str, int pos)
    {
        List<int> lista = [];
        for (int i = 0; i < str.Length; i++)
        {
            if (i == pos) continue;
            lista.Add(str[i]);
        }
        return lista.ToArray();
    }
}
