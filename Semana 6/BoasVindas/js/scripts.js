$(document).ready(
    $('input[name="enviar"]').click(
    function () {
        var nome = $('input[name="nome"]').val();
        alert("Ola " + nome + " seja bem vindo!!!");
        })
);