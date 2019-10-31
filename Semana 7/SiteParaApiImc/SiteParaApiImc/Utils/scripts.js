$(document).ready(function () {
    $('#calcular').click(function () {
        var obj = $("#formularioImc").serialize()
        console.log(obj)

        $.get("http://localhost:65170/api/CalculoIdade?" + obj, function (data) {

            $('#resultado').text(data)

        })
    })
})
