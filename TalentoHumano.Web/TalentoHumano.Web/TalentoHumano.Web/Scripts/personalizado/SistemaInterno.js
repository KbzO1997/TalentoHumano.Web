var SistemaInterno = {
    //Invocar Vista Contactos  SistemaInterno.VistaContactos();
    VistaContactos: function () {
        var accion = "/Home/Contact";
        Utileria.AjaxViewHtml(accion, Declaracion.DivContentModal);
        Utileria.ModalControl(Declaracion.IdModalDinamic, true);
    },
    //Invocar vista de notificacion Tiene Equipo y Persona SistemaInterno.VistaNotificacion();
    VistaNotificacion: function () {
        var accion = "/Home/NotificationPush";
        Utileria.AjaxViewHtml(accion, Declaracion.DivContentModal);
        Utileria.ModalControl(Declaracion.IdModalDinamic, true);
    }
}