### **Cenário**

Vamos implementar um sistema de vendas online com a possibilidade de realizar pedidos com múltiplos itens, cada um deles com uma quantidade variável, calculando o frete, os impostos, aplicando um cupom de desconto e ainda interagindo com o estoque. Além disso teremos ainda fluxos de pagamento e cancelamento do pedido realizado.

### **Testes**

1- Deve gerar o código do pedido
2- Deve fazer um pedido (caso de uso)
3- Deve simular o frete (caso de uso)
4- Deve validar o cupom de desconto (caso de uso)

### **Considere**

- O código do pedido é formado por AAAAPPPPPPPP onde AAAA representa o ano e o PPPPPPPP representa um sequencial do pedido
- Implementar um mecanismo de persistência desacoplado utilizando banco de dados

### **Importante**

- Implemente os testes de unidade que faltam para cada uma das entities
- Implemente os DTOs para cada um dos use cases