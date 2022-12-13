# DIO - Trilha .NET - Fundamentos
### Resultado do Projeto no final!

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo: 
 ![image](https://user-images.githubusercontent.com/62121038/207397540-67230d92-674e-4c35-a44d-672ebc2c4b3d.png)


A classe contém três variáveis, sendo:

- precoInicial: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

- precoPorHora: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

- veiculos: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

- AdicionarVeiculo: Método responsável por receber uma placa digitada pelo usuário e guardar na variável veiculos.

- RemoverVeiculo: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: precoInicial * precoPorHora, exibindo para o usuário.

- ListarVeiculos: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:

## Resultado

### Tela Inicial
![image](https://user-images.githubusercontent.com/62121038/207406532-ba29275d-91a5-45eb-b319-6d9f2eec760b.png)

### Menu
![image](https://user-images.githubusercontent.com/62121038/207406602-448a196a-9d7d-413e-9205-28035849fee5.png)

### Cadastrar
![image](https://user-images.githubusercontent.com/62121038/207406772-fa11d055-ebe3-4889-bb43-02bfbe474db1.png)

### Listar
![image](https://user-images.githubusercontent.com/62121038/207406844-67077f9e-a281-4d43-b08b-6d775972ee03.png)

### Remover
![image](https://user-images.githubusercontent.com/62121038/207406953-7a6b80d0-344e-4e6a-921d-9a2a621d0208.png)

