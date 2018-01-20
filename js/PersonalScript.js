function Alerta(mens,stat) {
    swal({
        title: "Un momento",
        text: mens,
        icon: stat,
        dangerMode: true,
    })
}