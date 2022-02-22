
var listaDePecas = ["Amortecedor", "Motor", "Filtro do Ar", "ar"] // vetor ou array

let peso = 200 //definido a váriavel 

// o peso
if (peso < 100){
    console.log("O peso deve ser menor ou igual 100")
}else{
    console.log("A peça tem o peso adequado")
}

// máximo 10 pesa
if(listaDePecas.length < 10){ //length significa tamanho
    console.log("É possível cadastrar mais peças")
}else{
    console.log("Não tem mais espaço na lista")
}

// comando pra caracteres de um nome de peça determinado.
if(listaDePecas[3].length <= 3 ){
    console.log("Erro no cadatro do nome, não está completo, deve ter mais que 3 letras")
}else
if(listaDePecas[3].length > 3 ){
    console.log("Nome acima de 3 caracteres , ideal.")
}else
if (listaDePecas[3].length == 0 ){
    console.log("Nome não pode ser vazio")
}