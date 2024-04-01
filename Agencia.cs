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
}}