$(document).ready(function () {
    $('#Button1').click(function () {
        $.get("https://viacep.com.br/ws/rs/porto%20alegre/all/json/", function (data) {
            var tbody = document.getElementById('table_body');
            $.each(data, function (key, value) {
                var tr = document.createElement('tr');
                $.each(value, function (key, value) {
                    if (key == "gia" || key == "unidade")
                        return;
                    var td = document.createElement('td');
                    var text = document.createTextNode(value);
                    switch (key) {
                        case "logradouro":
                            td.classList.add('col-4');
                            break;
                        case "bairro" :
                        case "complemento":
                            td.classList.add('col-2');
                            break;
                        default:
                            td.classList.add('col-1');
                            break;
                    }
                    td.classList.add('small');
                    td.appendChild(text);
                    tr.appendChild(td);
                });
                tbody.appendChild(tr);
            });
        });
    });
});