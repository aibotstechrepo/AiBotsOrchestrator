$(document).ready(function () {

    $("#min").click(function () {
        $(".appendradioclick").html('<div class="row"><div class="col-sm-4"><label>Every</label></div><div class="col-sm-4"><input type="number" class="form-control" name="quantity" min="1" max="60"></div><div class="col-sm-4"><label>minute (s)</label></div></div>');
    });

    $("#hour").click(function () {
        $(".appendradioclick").html('<div class="row"><div class="col-sm-4"><label>Every</label></div><div class="col-sm-4"><input type="number" class="form-control" name="quantity" min="1" max="24"></div><div class="col-sm-4"><label>Hour</label></div></div><br/><div class="row"><div class="col-sm-4"><label>At</label></div><div class="col-sm-4"><input type="number" class="form-control" name="quantity" min="1" max="24"></div><div class="col-sm-4"><label>minute (s)</label></div></div>');
    });
   
    $("#daily").click(function () {
        $(".appendradioclick").html('<div class="row"><div class="col-sm-4"><label>Every day at</label></div><div class="col-sm-4"><input type="number" class="form-control" name="quantity" min="1" max="24"></div><div class="col-sm-4"><label>hour</label></div></div><br/><div class="row"><div class="col-sm-4"><label>And</label></div><div class="col-sm-4"><input type="number" class="form-control" name="quantity" min="1" max="60"></div><div class="col-sm-4"><label>minute (s)</label></div></div>');
    });

    $("#week").click(function () {
        $(".appendradioclick").html('<div class="row"><div class="col-sm-3"><label>Every</label></div ><div class="col-sm-3"><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Monday</label></div></div><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Thursday</label></div></div><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Sunday</label></div></div></div><div class="col-sm-3"><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Tuesday</label></div></div><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Friday</label></div></div></div><div class="col-sm-3"><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Wednesday</label></div></div><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Saturday</label></div></div></div></div><br/><div class="row"><div class="col-sm-4"><label>At</label></div><div class="col-sm-4"><input type="number" class="form-control" name="quantity" min="1" max="24"></div><div class="col-sm-4"><label>hour</label></div></div><br/><div class="row"><div class="col-sm-4"><label>And</label></div><div class="col-sm-4"><input type="number" class="form-control" name="quantity" min="1" max="60"></div><div class="col-sm-4"><label>minute (s)</label></div></div>');
    });

    $("#month").click(function () {
        $(".appendradioclick").html('<div class="row"><div class="col-sm-4"><label>Every</label></div><div class="col-sm-4"><input type="number" class="form-control" name="quantity" min="1" max="12"></div><div class="col-sm-4"><label>month</label></div></div><br/><div class="row"><div class="col-sm-3"><label>Every</label></div ><div class="col-sm-3"><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Monday</label></div></div><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Thursday</label></div></div><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Sunday</label></div></div></div><div class="col-sm-3"><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Tuesday</label></div></div><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Friday</label></div></div></div><div class="col-sm-3"><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Wednesday</label></div></div><div class="row"><div class="col-sm-12"><label><input type="checkbox"/>Saturday</label></div></div></div></div><br/><div class="row"><div class="col-sm-4"><label>At</label></div><div class="col-sm-4"><input type="number" class="form-control" name="quantity" min="1" max="24"></div><div class="col-sm-4"><label>hour</label></div></div><br/><div class="row"><div class="col-sm-4"><label>And</label></div><div class="col-sm-4"><input type="number" class="form-control" name="quantity" min="1" max="60"></div><div class="col-sm-4"><label>minute (s)</label></div></div>');
    });

    $("#adv").click(function () {
        $(".appendradioclick").html('<div class="row"><div class="col-sm-4"><label>Corn expression</label></div><div class="col-sm-8"><input type="text" class="form-control"></div></div>');
    });
    });