//Declarar Variables que se utilizan en el sistema - Declaracion.Variables
var Declaracion = {
    DivContentModal : "DivContentModal",
    IdModalDinamic : "modalDinamic"
};

var Utileria = {
    //Permite Controlar el estado de un Modal - Utileria.ModalControl('',true);
    ModalControl: function (nombreModal, isActive) {
        var accion = (isActive) ? 'show' : 'hide';
        $('#' + nombreModal).modal(accion);
    },
    //Permite Controlar los errores de un Ajax por modal - Utileria.ModalControlError('','');
    ModalControlError: function (nombreModal, mensaje) {
        $(".TipoError").html(mensaje);
        $('#' + nombreModal).modal('show');
    },
    //EventoAjax Para Mostar Vistas sin Param - Utileria.AjaxViewHtml('','');
    AjaxViewHtml: function (actionPetcion, content) {
        $.ajax({
            cache: false,
            type: "POST",
            url: actionPetcion,
            datatype: 'html',
            success: function (data) {
                $("." + content).empty().html(data);
            },
            error: function (status, error) {
                Utileria.ModalControlError(error +' '+ status);
            }
        });
    }
}