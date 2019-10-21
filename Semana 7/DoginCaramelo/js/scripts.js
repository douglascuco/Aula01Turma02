var Bicicleta = { Marca: "Caloi", Valor: 523.56, Peso: 98.56 };

$(document).ready(
    function () {
        $('input[name="valor"]').mask("R$ 999999999,99");
        $('input[name="peso"]').mask("Kg 999999999,99");

        $('input[name="bntsalvar"]').click(function () {
            Bicicleta.Marca = $('input[name="marca"]').val();
            Bicicleta.Valor = $('input[name="valor"]').val();
            Bicicleta.Peso = $('input[name="peso"]').val();

            LimparTela();
            document.getElementById('table-hist').removeAttribute("hidden");
            gravaNoArray(Bicicleta.Marca, Bicicleta.Valor, Bicicleta.Peso, new Date());
        });

        $('input[name="bntmostrar"]').click(function () {
            alert("Marca: " + Bicicleta.Marca + "\r\n" + "Valor: " + Bicicleta.Valor +"\r\n" +"Peso: " + Bicicleta.Peso);
        });
    }
);


function LimparTela() {
    var meusInputs = $('input[type="text"]');
    meusInputs.val("");
}

function insertTable(marca, valor, peso, data) {
    var objTo = document.getElementById('table_body');

    var div_lista = document.createElement("tr");
    var div_lista2 = document.createElement("td");
    div_lista2.classList.add("col-md-4");
    var text_lista = document.createTextNode(marca);
    div_lista2.appendChild(text_lista);
    div_lista.appendChild(div_lista2);


    var div_money1 = document.createElement("td");
    div_money1.classList.add("col-md-3");
    var text_money1 = document.createTextNode(valor);
    div_money1.appendChild(text_money1);
    div_lista.appendChild(div_money1);


    var div_money2 = document.createElement("td");
    div_money2.classList.add("col-md-2");
    var text_money = document.createTextNode(peso);
    div_money2.appendChild(text_money);
    div_lista.appendChild(div_money2);


    var div_data2 = document.createElement("td");
    div_data2.classList.add("col-md-3");
    var text_data = document.createTextNode(data);
    div_data2.appendChild(text_data);
    div_lista.appendChild(div_data2);

    objTo.appendChild(div_lista);
}

function gravaNoArray(marca, valor, peso, data) {
    var session = {}
    var restoredSession = JSON.parse(localStorage.getItem("historico"));
    if (restoredSession == null)
        session = {
            'marca': [],
            'valor': [],
            'peso': [],
            'data': []
        };
    else
        session = restoredSession;
    session.id.push(marca);
    session.real.push(valor);
    session.dolar.push(peso);
    session.data.push(data.toLocaleString());
    localStorage.setItem("historico", JSON.stringify(session));

    insertTable(marca, valor, peso, data.toLocaleString());
}

function inicializaBarraLateral(arrayElementos) {
    if (arrayElementos != null) {
        $(arrayElementos.id).each(function (element) {
            insertTable(arrayElementos.marca[element], arrayElementos.valor[element], arrayElementos.peso[element], arrayElementos.data[element]);
        });
    }
}