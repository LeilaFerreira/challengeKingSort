# challengeKingSort

##TESTE KING

Toda boa enciclopédia tem um índice. As entradas no índice geralmente são classificadas em
ordem alfabética. No entanto, existem algumas exceções notáveis. Nesta tarefa, iremos
considere uma dessas exceções: os nomes dos reis.
Em muitos países, era comum que reis com o mesmo nome recebessem números ordinais.
Esse número ordinal foi escrito como um número romano e anexado ao nome real do
rei. Por exemplo, "Luís XIII" (leia-se Luís XIII) foi o décimo terceiro rei de
França, tendo o nome real Louis.
No índice de uma enciclopédia, reis que compartilham o mesmo nome precisam ser classificados
de acordo com seus números ordinais. Por exemplo, Louis 9º deve ser listado após
Luís 8º.
Você recebe reis String []. Cada elemento dos reis é o nome de um rei. O nome
de cada rei consiste em seu nome real, um espaço único e um numeral romano. Retornar um
String [] contendo os nomes reorganizados em sua ordem correta: ou seja, os reis têm
estar em ordem lexicográfica crescente, de acordo com o nome real, e reis com o
mesmo nome deve estar na ordem numérica correta.

Definição
Classe: KingSort
Método: getSortedList
Parâmetros: String []
Retorna: String []
Assinatura do método: public String [] getSortedList (String [] reis)
***
Definition Class: KingSort 
Method: getSortedList 
Parameters: String[] 
Returns: String[] 
Method signature: public String[] getSortedList(String[] kings)
****

Notas
- Os números romanos de 1 a 10 são I, II, III, IV, V, VI, VII, VIII, IX e
X.
- Os algarismos romanos de 20, 30, 40 e 50 são XX, XXX, XL e L.
- O número romano para qualquer outro número de dois dígitos menor que 50 pode ser construído por
concatenando o numeral para as dezenas e o numeral para as unidades. Por exemplo, 47 é
40 + 7 = "XL" + "VII" = "XLVII".
- As rotinas padrão de comparação de strings fornecem a ordem correta para os nomes reais
dos reis.
- Formalmente, dadas duas cadeias A e B diferentes, dizemos que A é lexicograficamente
menor que B se (A é um prefixo de B) ou (existe pelo menos um índice em que A e
B diferem e, para o menor índice desse tipo, o caractere A possui um valor ASCII mais baixo do que
o caractere em B).
Restrições
2
- Cada nome real de um rei será uma string contendo entre 1 e 20 caracteres,
inclusive.
- Cada nome real começará com uma letra maiúscula ('A' - 'Z').
- Cada outro caractere em cada nome real será uma letra minúscula ('a' - 'z').
- reis conterão entre 1 e 50 elementos, inclusive.
- Cada elemento dos reis terá o formato "ACTUALNAME ORDINAL", onde ACTUALNAME é
um nome real, conforme definido acima, e ORDINAL é um número romano válido que representa um
número entre 1 e 50, inclusive.
- Os elementos dos reis serão distintos aos pares.

Exemplos
0) {"Louis IX", "Louis VIII"}
Retorna: {"Louis VIII", "Louis IX"}
Luís 9 deve ser listado depois de Luís 8.
1) {"Louis IX", "Philippe II"}
Retorna: {"Louis IX", "Philippe II"}
Os nomes reais têm precedência sobre os números ordinais.
2) {"Richard III", "Richard I", "Richard II"}
Retorna: {"Richard I", "Richard II", "Richard III"}
3) {"João X", "João I", "João L", "João V"}
Retorna: {"João I", "João V", "João X", "João L"}
4) {"Philippe VI", "Jean II", "Charles V", "Charles VI", "Charles VII", "Louis XI"}
Retorna: {"Carlos V", "Carlos VI", "Carlos VII", "Jean II", "Luís XI", "Philippe
VI "}
Estes são os monarcas franceses que governaram entre 1328 e 1483.
5) {"Philippe II", "Philip II"}
Retorna: {"Filipe II", "Filipe II"}
"Philippe" e "Philip" são nomes distintos, e "Philip" é lexicograficamente menor
do que "Philippe".
