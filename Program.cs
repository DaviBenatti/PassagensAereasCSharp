namespace PassagensAereasCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write($"Digite a senha para acessar o sistema: ");
        string senha = Console.ReadLine();
        
        int opcao = 1;

        do
        {
            if(senha == "123456")
            {
                Console.WriteLine($"<--- BEM VINDO AO SENAI AIRLINES --->");
                Console.WriteLine($"[1] - Cadastrar novo passageiro");
                Console.WriteLine($"[2] - Listagem de passagens");
                Console.WriteLine($"[0] - Sair");
                
                Console.Write($"Selecione a opção: ");
                opcao = int.Parse(Console.ReadLine());
            }
            else
            {
                while(senha != "123456")
                {
                    Console.Write($"Senha incorreta, digite novamente: ");
                    senha = Console.ReadLine();
                }
            }    
        } while(opcao != 0);
    }
}
