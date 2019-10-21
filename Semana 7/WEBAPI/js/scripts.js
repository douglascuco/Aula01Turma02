var meuNomeDeVariavel;
var jsoncep;
$(document).ready(
    function () {

        $('input[name="cep"]').mask("99999-999");
        $('input[type="button"]').click(
            function () {
                var campo_cep = $('input[name="cep"]').val();
                if (campo_cep == "") {
                    alert("CAMPO CEP NAO PODE SER NULO")
                    LimparCampos();
                    return;
                }
                jsoncep = "https://viacep.com.br/ws/" + campo_cep.replace(",", "") + "/json/"
                $.get(jsoncep, function (data) {
                    if (data.erro) {
                        alert("CEP INVALIDO!!! Digite novamente");
                        LimparCampos();
                        return;
                    }
                        
                    $('input[name="bairro"]').val(data.bairro);
                    $('input[name="uf"]').val(data.uf);
                    $('input[name="rua"]').val(data.logradouro);
                    $('input[name="cidade"]').val(data.localidade);
                    $('input[name="ibge"]').val(data.ibge);
                    $('input[name="complemento"]').val(data.complemento);
                });
            }
        );
    }
);

function LimparCampos() {
    var campos = $('input[type=text]');
    campos.val("");
}


