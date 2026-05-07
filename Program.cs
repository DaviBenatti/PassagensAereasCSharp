namespace PassagensAereasCSharp;

class Program
{
    static void Main(string[] args)
    {
        Console.Write($"Digite a senha para acessar o sistema: ");
        string senha = Console.ReadLine();
        
        int opcao = 1;

        List<Passagem> Bilhete = new List<Passagem>();

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

                switch(opcao)
                {
                    case 1:
                        int qtdBilhete = 0;

                        do
                        {
                            Console.WriteLine($"Digite o nome do passageiro: ");
                            string nomeBilhete = Console.ReadLine();
                            Console.WriteLine($"Digite a origem do voo: ");
                            string origemBilhete = Console.ReadLine();
                            Console.WriteLine($"Digite o destino do voo: ");
                            string destinoBilhete = Console.ReadLine();
                            Console.WriteLine($"Digite a data da viagem no formato DD/MM/AA: ");
                            string dataBilhete = Console.ReadLine();
                            
                            Bilhete.Add(new Passagem(nomeBilhete, origemBilhete, destinoBilhete, dataBilhete));
                            qtdBilhete += 1;

                            Console.WriteLine($"Reserva realizada com sucesso!");
                            
                            Console.WriteLine($"Você pode comprar mais 1 passagem, deseja realizar a reserva? ([1] Sim / [2] Não): ");
                            int confirmacao = int.Parse(Console.ReadLine());
                            
                            if(confirmacao == 2)
                            {
                                qtdBilhete = 2;
                            }

                        } while(qtdBilhete <= 2);
                        
                        
                        
                        
                        
                }
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
