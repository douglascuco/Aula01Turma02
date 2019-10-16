$(document).ready(
    function () {
        function number_format(number, decimals, dec_point, thousands_sep) {
            var n = number, c = isNaN(decimals = Math.abs(decimals)) ? 2 : decimals;
            var d = dec_point == undefined ? "," : dec_point;
            var t = thousands_sep == undefined ? "." : thousands_sep, s = n < 0 ? "-" : "";
            var i = parseInt(n = Math.abs(+n || 0).toFixed(c)) + "", j = (j = i.length) > 3 ? j % 3 : 0;
            return "$ " + s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
        }






        $('input[name="dolar"]').mask("R$ 9999999.99")
        $('input[name="converter"]').click(
            function () {
                var dolar = $('input[name="dolar"]').val();
                dolar = dolar.replace("R$", "");
                dolar = dolar.replace(" ", "");
                var real = dolar * 4.18;
                $('input[name="resultado"]').val(number_format(real, 2, ',', '.'));

            })
    }
);