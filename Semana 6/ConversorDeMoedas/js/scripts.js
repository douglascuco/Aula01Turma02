function insertTable(count, real, dolar, data) {
    var objTo = document.getElementById('table_body');
    var div_lista = document.createElement("tr");
    var div_lista2 = document.createElement("td");
    div_lista2.classList.add("col-md-2");
    var text_lista = document.createTextNode(count);
    div_lista2.appendChild(text_lista);
    div_lista.appendChild(div_lista2);


    var div_money1 = document.createElement("td");
    div_money1.classList.add("col-md-3");
    var text_money1 = document.createTextNode(real);
    div_money1.appendChild(text_money1);
    div_lista.appendChild(div_money1);


    var div_money2 = document.createElement("td");
    div_money2.classList.add("col-md-3");
    var text_money = document.createTextNode(dolar);
    div_money2.appendChild(text_money);
    div_lista.appendChild(div_money2);


    var div_data2 = document.createElement("td");
    div_data2.classList.add("col-md-4");
    var text_data = document.createTextNode(data);
    div_data2.appendChild(text_data);
    div_lista.appendChild(div_data2);

    objTo.appendChild(div_lista);
}

function gravaNoArray(id, real, dolar, data) {
    var session = {}
    var restoredSession = JSON.parse(localStorage.getItem("historico"));
    if (restoredSession == null)
        session = {
            'id': [],
            'real': [],
            'dolar': [],
            'data': []
        };
    else
        session = restoredSession;
    session.id.push(id);
    session.real.push(real);
    session.dolar.push(dolar);
    session.data.push(data.toLocaleString());
    localStorage.setItem("historico", JSON.stringify(session));

    insertTable(id, real, dolar, data.toLocaleString());
}

function inicializaBarraLateral(arrayElementos) {
    if (arrayElementos != null) {
        $(arrayElementos.id).each(function (element) {
            insertTable(arrayElementos.id[element], arrayElementos.real[element], arrayElementos.dolar[element], arrayElementos.data[element]);
        });
        return arrayElementos.id.length + 1;
    } else
        return 1;
}

$(document).ready(
    function () {
        function number_format(number, decimals, dec_point, thousands_sep) {
            var n = number, c = isNaN(decimals = Math.abs(decimals)) ? 2 : decimals;
            var d = dec_point == undefined ? "," : dec_point;
            var t = thousands_sep == undefined ? "." : thousands_sep, s = n < 0 ? "-" : "";
            var i = parseInt(n = Math.abs(+n || 0).toFixed(c)) + "", j = (j = i.length) > 3 ? j % 3 : 0;
            return "$ " + s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
        }
        var count = 1;
        count = inicializaBarraLateral(JSON.parse(localStorage.getItem("historico")));
        $('input[name="real"]').mask("R$ 999999999,99")

        $('input[name="converter"]').click(
            function () {
                var real = $('input[name="real"]').val();
                real = real.replace("R$ ", "").replace(",",".");
                var dolar = real / 4.18;
                $('input[name="resultado"]').val(number_format(dolar, 2, '.', ','));

                gravaNoArray(count, $('input[name="real"]').val(), $('input[name="resultado"]').val(), new Date());
                count++;
                
            }
        )
    }
);


