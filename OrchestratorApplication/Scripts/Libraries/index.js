function createButton() {
    var $input = $('<a href="#" class="btn btn-primary btn-circle" title="Upload Library" data-toggle="modal" data-target="#myModal"><i class="fa fa-upload"></i></a>&nbsp<a href="#" class="btn btn-primary btn-circle" title="Package versions" data-toggle="modal" data-target="#myModal1"><i class="fa fa-sticky-note"></i></a>');
    $input.appendTo($("#append"));
    return;
}