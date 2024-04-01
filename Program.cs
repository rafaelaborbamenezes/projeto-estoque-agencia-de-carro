namespace projeto_estoque_agencia_de_carro;

class Program
{
    static void Main(string[] args)
    {
         
        int menu =0; 

        do{    
        Console.WriteLine("\n\nO que você deseja fazer?");
        Console.WriteLine("1. NOVO");
        Console.WriteLine("2. LISTAR PRODUTOS");
        Console.WriteLine("3. REMOVER PRODUTOS");
        Console.WriteLine("4. ENTRADA ESTOQUE"); 
        Console.WriteLine("5. SAÍDA ESTOQUE"); 
        Console.WriteLine("0. SAIR");
        menu = Convert.ToInt32(Console.ReadLine());    

        switch(menu) 
        { 

            case1: 

            Veiculo novoVeiculo = new Veiculo();
                 
            Console.WriteLine("\n\nInforme o nome do modelo do carro: ");
            novoVeiculo.Modelo = Console.ReadLine();  

            Console.WriteLine("Informe o valor do carro: "); 
            novoVeiculo.Preco = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Informe a quantidade em estoque: "); 
            novoVeiculo.QuantidadeEstoque = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Informe qual o ano do carro: "); 
            novoVeiculo.Ano = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("Informe o nome da marca do carro: "); 
            novoVeiculo.Marca = Console.ReadLine();  

            Console.WriteLine("Informe qual o tipo da direção do carro: "); 
            novoVeiculo.Direcao = Console.ReadLine();  

            Console.WriteLine("Veículo "+ novoVeiculo.Modelo +  " adicionado!");
             
           // agencia.Cadastrar(novoVeiculo); 
            break; 

        



        

        }    
            
        } while (menu !=0);
    }   
}      

    
