$(document).ready(
    function () {
        function number_format(number, decimals, dec_point, thousands_sep) {
            var n = number, c = isNaN(decimals = Math.abs(decimals)) ? 2 : decimals;
            var d = dec_point == undefined ? "," : dec_point;
            var t = thousands_sep == undefined ? "." : thousands_sep, s = n < 0 ? "-" : "";
            var i = parseInt(n = Math.abs(+n || 0).toFixed(c)) + "", j = (j = i.length) > 3 ? j % 3 : 0;
            return "$ " + s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
        }

        $('input[name="real"]').mask("R$ 999999999.99")
        var count = 1;
        $('input[name="converter"]').click(
            function () {
                var real = $('input[name="real"]').val();
                real = real.replace("R$ ", "");
                var dolar = real / 4.18;
                $('input[name="resultado"]').val(number_format(dolar, 2, '.', ','));

                var objTo = document.getElementById('card');
                var div_lista = document.createElement("div");
                var div_lista2 = document.createElement("div");
                div_lista.classList.add("row", "form-group");
                div_lista2.classList.add("col-md-2");
                var text_lista = document.createTextNode(count++);
                div_lista2.appendChild(text_lista);
                div_lista.appendChild(div_lista2);


                var div_money1 = document.createElement("div");
                div_money1.classList.add("col-md-3");
                var text_money1 = document.createTextNode($('input[name="real"]').val());
                div_money1.appendChild(text_money1);
                div_lista.appendChild(div_money1);
                


                var div_money2 = document.createElement("div");
                div_money2.classList.add("col-md-3");
                var text_money = document.createTextNode($('input[name="resultado"]').val());
                div_money2.appendChild(text_money);
                div_lista.appendChild(div_money2);

                var div_data2 = document.createElement("div");
                div_data2.classList.add("col-md-4");
                /*function dataAgora() {
                    var data = new Date();
                    var data_atual = data.getHours() + ':' + data.getMinutes() + ':' + data.getSeconds();
                    return data_atual;
                }*/
                var data = new Date();
                var text_data = document.createTextNode(data.toLocaleString());
                div_data2.appendChild(text_data);
                div_lista.appendChild(div_data2);


                objTo.appendChild(div_lista);


            }
        )
    }
);