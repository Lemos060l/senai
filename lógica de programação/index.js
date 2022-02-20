var listadeparticipante = ["Marcos","Gabriel,Thaigo"] //Array

let idadeparticipante = 18; //idade da pessoa em questão

let dataEvento = new Date("2022-02-20"); // data do evento , (ano,mês,dia.)
let dataAtual = new Date("2022-02-18"); 

if (listadeparticipante.length >= 100) {

    console.log ("Cadastro negado, número de participante superior.") //número de participante acima do permitido.

} else if (idadeparticipante > 18) { //idade maior que 18 negar cadastor.

    console.log("Cadastro negado , idade não permitida.")

} else if(dataAtual > dataEvento) { // a data atual for superior ao dia do evento , negar cadastro.

    console.log("Cadastro negado, data não permitida.")

} else { //cadastro deu certo , adicionar nome a lista.

    listadeparticipante.push("Matheus")
    console.log(listadeparticipante)
}