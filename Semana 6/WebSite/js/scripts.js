function atualizaData() {
    setInterval(function () {
        $('span[name="data_atual"]').text(Date());
    }, 100);
}

$(document).ready(
    function () { atualizaData(); }
);