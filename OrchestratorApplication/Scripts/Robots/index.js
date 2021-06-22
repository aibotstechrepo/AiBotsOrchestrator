function CreateLinks() {
    var $input = $('<a href="#" class="btn btn-primary btn-circle" title="Standard Robot" data-toggle="modal" data-target="#myModal"><i class="fa fa-stop-circle"></i></a>&nbsp<a href="#" class="btn btn-primary btn-circle" data-toggle="modal" title="Floating Robot" data-target="#myModal1"><i class="fa fa-th-large"></i></a>');
    $input.appendTo($("#append"));
    return;
}

//$(document).ready(function () {
//    $("#btnclick").click(function () {
//        $("#appending").html('<a href="#" title="Template machine" class="btn btn-primary btn-circle" data-toggle="modal" data-target="#myModal"><i class="fa fa-cogs"></i></a>&nbsp<a href="#" title="Standard machine" class="btn btn-primary btn-circle" data-toggle="modal" data-target="#myModal1"><i class="fa fa-sticky-note"></i></a>');
//        //$("#append").hide();
//    });
//});