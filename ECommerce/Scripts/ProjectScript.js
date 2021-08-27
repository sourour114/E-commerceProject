/// <reference path="jquery-3.4.1.min.js" />
//<reference path="https://cdn.jsdelivr.net/npm/sweetalert2@11"/>
//$('#Phone').on('blur', function () {
//    var longueur = $(this).val().length();
//    if (longueur != 8) {
//        $(this).addClass("error");
//    }
//    else {
//        $(this).removeClass("error");
//    }
////});
//}
//$(document).ready(function () {
//    $('#form input[type="text"]').blur(function () {
//        if (!$(this).val()) {
//            $(this).addClass("error");
//        } else {
//            $(this).removeClass("error");
//        }
//    });
//});


function SuppressionAlert(id) {
    alert("attention : <br> vous voulez effacer ce champ?")
    //swal({
    //    icon: 'error',
    //    title: 'Oops...',
    //    text: 'Something went wrong!',
    //    buttons: true
    //})
    //    .then((ok) => {
    //        if (ok) {
    //$.ajax({
    //    url: "Admin/supprimer",

    //})
}
//            }
//        })
$(document).ready(function () {
    //menu
    $(".dropdown-toggle").click(function (event) {
        var val = event.target.children[1];
        var menuState = 0;
        if (menuState === 0) {
            $(val).slideDown("slow");
            menuState = 1;
        } else {
            $(val).slideUp("slow");
            menuState = 0;
        }
    });



    //verifier @ mail
    $("#AdrMail").blur(function (event) {
         var vall = $(this).val();
        if (!(vall.includes("@"))) {
            $(this).css("border-color", "red");
        }
        else {
            $(this).removeAttr('style');

        }
    });
})
