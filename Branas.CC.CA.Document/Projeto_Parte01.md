### **Cen�rio**

Vamos implementar um sistema de vendas online com a possibilidade de realizar pedidos com m�ltiplos itens, cada um deles com uma quantidade vari�vel, calculando o frete, os impostos, aplicando um cupom de desconto e ainda interagindo com o estoque. Al�m disso teremos ainda fluxos de pagamento e cancelamento do pedido realizado.

### **Testes**

1- N�o deve fazer um pedido com cpf inv�lido
2- Deve fazer um pedido com 3 itens (com descri��o, pre�o e quantidade)
3- Deve fazer um pedido com cupom de desconto (percentual sobre o total do pedido)

### **Considere**

- Refatorar o algoritmo de valida��o de cpf

### **Sugest�es**

- Utilize a sua linguagem e biblioteca de teste de sua prefer�ncia
- Fa�a a modelagem da forma que desejar e n�o se preocupe por enquanto, vamos implementar juntos na aula seguinte com influ�ncias de DDD e Clean Architecture

### **Dicas**

- Devem existir no m�nimo 2 arquivos, um de teste e outro que implementa os cen�rios propostos
- Tente seguir com disciplina, criando primeiro um teste que falha, depois fazendo e teste passar e refatorando

[Funcionamento do algoritmo do CPF](http://www.macoratti.net/alg_cpf.htm)