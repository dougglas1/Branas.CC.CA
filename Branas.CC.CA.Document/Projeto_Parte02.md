### **Cen�rio**

Vamos implementar um sistema de vendas online com a possibilidade de realizar pedidos com m�ltiplos itens, cada um deles com uma quantidade vari�vel, calculando o frete, os impostos, aplicando um cupom de desconto e ainda interagindo com o estoque. Al�m disso teremos ainda fluxos de pagamento e cancelamento do pedido realizado.

### **Testes**

1- N�o deve aplicar cupom de desconto expirado
2- Deve calcular o valor do frete com base nas dimens�es (altura, largura e profundidade em cm) e o peso dos produtos (em kg)
3- Deve retornar o pre�o m�nimo de frete caso ele seja superior ao valor calculado

### **Considere**

- O valor do frete ser� calculado de acordo com a f�rmula
- O valor m�nimo � de R$10,00
- N�o existem diferentes modalidades de frete (normal, expresso, �) e a origem dos produtos � sempre a mesma, al�m disso n�o existe diferen�a no destino, se � capital ou interior, o c�lculo � feito basicamente considerando a dist�ncia, o volume e a densidade transportados

### **F�rmula de C�lculo do Frete**

Pre�o do Frete = dist�ncia (km) * volume (m3) * (densidade/100)

**Exemplos de volume ocupado (cubagem)**

Camera: 20cm x 15 cm x 10 cm = 0,003 m3
Guitarra: 100cm x 30cm x 10cm = 0,03 m3
Geladeira: 200cm x 100cm x 50cm = 1 m3

**Exemplos de densidade**

Camera: 1kg / 0,003 m3 = 333kg/m3
Guitarra: 3kg / 0,03 m3 = 100kg/m3
Geladeira: 40kg / 1 m3 = 40kg/m3

**Exemplos**

dist�ncia: 1000 (fixo)
volume: 0,003
densidade: 333
pre�o: R$9,90 (1000 * 0,003 * (333/100))

dist�ncia: 1000 (fixo)
volume: 0,03
densidade: 100
pre�o: R$30,00 (1000 * 0,03 * (100/100))

dist�ncia: 1000 (fixo)
volume: 1
densidade: 40
pre�o: R$400,00 (1000 * 1 * (40/100))