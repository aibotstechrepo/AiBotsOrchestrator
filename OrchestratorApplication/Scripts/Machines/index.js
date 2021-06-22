function createButton() {
    var $input = $('<a href="#" title="Template machine" class="btn btn-primary btn-circle" data-toggle="modal" data-target="#myModal"><i class="fa fa-cogs"></i></a>&nbsp<a href="#" title="Standard machine" class="btn btn-primary btn-circle" data-toggle="modal" data-target="#myModal1"><i class="fa fa-sticky-note"></i></a>');
    var hideele = document.getElementById('hidebtnplus');
    $input.appendTo($("#append"));
    hideele.style.display = 'none';
    
}

//$(document).ready(function () {
//    $("#hidebtnplus").click(function () {
//        $("#append2").html('<a href="#" title="Template machine" class="btn btn-primary btn-circle" data-toggle="modal" data-target="#myModal"><i class="fa fa-cogs"></i></a>&nbsp<a href="#" title="Standard machine" class="btn btn-primary btn-circle" data-toggle="modal" data-target="#myModal1"><i class="fa fa-sticky-note"></i></a>');
//        $("#append").hide();
//    });
//});