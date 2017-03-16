$(document).ready(function () {
    $("body").on("change", "#deskMaterial", function () {
        $('.materialImage').attr('src', $('#deskMaterial option:selected').data('imagesource'));
    });
});