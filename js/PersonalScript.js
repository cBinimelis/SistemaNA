function Alerta(tit, mens, stat) {
    swal({
        title: tit,
        text: mens,
        icon: stat,
        dangerMode: true,
    })
}

function Delete(ctl, event) {
    var defaultAction = $(ctl).prop("href");
    event.preventDefault();
    swal({
        title: "Confirmacion",
        text: "Quieres borrar esto?",
        icon: "warning",
        buttons: true,
        dangerMode: true,
    }).then((willDelete) => {
        if (willDelete) {
            window.location.href = defaultAction;
            return true;
        } else {
            swal("Your imaginary file is safe!");
            return false;
        }
    });
}