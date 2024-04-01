class Agencia{ 
     
      
       Veiculo[] veiculos = new Veiculo[0];
        
        public void Cadastrar(Veiculo veiculo){ 
            Veiculo[] novoVetor = new Veiculo[veiculos.Length +1]; 
            for (int pos = 0; pos < veiculos.Length; pos++)  
              {
                Veiculo item = veiculos[pos]; 
                novoVetor[pos] = item;      
              } 
                novoVetor[novoVetor.Length-1] = veiculo; 
                         
                veiculos = novoVetor; 
        } 
 
        public void Listar() {   
              int cont =1;
              foreach(Veiculo item in veiculos){ 
              
              Console.WriteLine($"{cont}. {item.Modelo} (R$ {item.Preco}) - {item.QuantidadeEstoque} no estoque"); 
              cont++; 
              } 
        }
   
        public void Remover(int posicao){  
           
            if (posicao >= 1 && posicao <= veiculos.Length)
            {
                Veiculo[] novoVetor = new Veiculo[veiculos.Length - 1];

                for (int i = 0, j = 0; i < veiculos.Length; i++)
                {
                if (i != posicao - 1)
                {
                novoVetor[j++] = veiculos[i];
                }
            }
                veiculos = novoVetor;

                Console.WriteLine("Veículo de posição " + posicao + " removido.");
            }
            else
            {
                Console.WriteLine("Posição inválida. Certifique-se de fornecer uma posição válida no intervalo do vetor.");
            }
     
        }  
     
        public void Entrada(int pos, int quant){ 

           Veiculo veiculo = veiculos[pos-1]; 
           veiculo.QuantidadeEstoque += quant;

        }
         
          
           
            
             
              
               

    }