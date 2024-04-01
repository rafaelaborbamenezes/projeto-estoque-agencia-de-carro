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
   
    
     
      
      }