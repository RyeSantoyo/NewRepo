$(function () {
    GetProducts();
});

/*read data*/
//#region
function GetProducts() {
    $.ajax({
        url:'/Product/GetProducts',
        type:'get',
        dataType:'json',
        contentType: 'application/json;charset=utf-8',
        success: function (response) {
            if (response == null || response == undefined || response.length == 0) {
                var object = '';
                object += '<tr>';
                object += '<td colspan="15">' + 'No available data' + '</td>';
                object += '</tr>';
                $('#tblBody').empty().html(object);
            }
            else {
                var object = '';
                $.each(response, function (index, item) {
                    object += '<tr>';
                    object += '<td>' + item.id + '</td>';
                    object += '<td> '+ item.productName + '</td>';
                    object += '<td>' + item.category + '</td>';
                    object += '<td>' + item.serialNumber + '</td>';
                    object += '<td>' + item.description + '</td>';
                    object += '<td>' + item.price + '</td>';
                    object += '<td>' + item.quantity + '</td>';
                    object += '<td>' + item.uom + '</td>';
                    object += '<td>' + item.totalCost + '</td>';
                    object += '<td>' + item.costPerUnit + '</td>';
                    object += '<td>' + item.grossIncome + '</td>';
                    object += '<td>' + item.totalIncome + '</td>';
                    object += '<td>' + item.status + '</td>';
                    object += `<td>
                                <div style="display: flex; gap: 5px;">
                                    <a href="#" class="btn btn-primary btn-sm" onclick="Edit(${item.id})">Edit</a>
                                    <a href="#" class="btn btn-danger btn-sm" onclick="Delete(${item.id})">Delete</a>
                                </div>
                            </td>`;
                    object += '</tr>';
                });
                $('#tblBody').empty().html(object);
            }
        },
        error: function () {
            alert('Unable to read the data.')
        }
    });
}
//#endregion
//#region
$('#btnAdd').on('click', function () {
    $('#ProductModal').modal('show');
    $('#modalTitle').text('Add Product');
});
//#endregion
//#region Insert Function
function Insert() {
    var result = Validate();
    if (result == false) {
        return false; 
    }

    var formData = new Object();
    formData.id = $('#Id').val();
    formData.productName = $('#ProductName').val();
    formData.category = $('#Category').val();
    formData.serialNumber = $('#SerialNumber').val();
    formData.description = $('#Description').val();
    formData.uom = $('#UOM').val();

    formData.price = parseFloat($('#Price').val())||0;
    formData.quantity = parseFloat($('#Quantity').val()) || 0;
    formData.totalCost = parseFloat($('#TotalCost').val()) || 0;

    //formData.totalCost = parseFloat($(formdata.price) * (formData.quantity).val())|| 0;
    formData.costPerUnit = formData.price;

    formData.grossIncome = formData.price * formData.quantity;
    formData.totalIncome = formData.grossIncome - formData.totalCost;

    console.log(formData);

    $.ajax({
        url: '/product/Insert',
        data: formData,
        type: 'post',
        success: function (response) {
            if (response == null || response == undefined || response.length == 0) {
                alert('Unable to save data.')
            }
            else {
                HideModal();
                GetProducts();
                alert(response);
            }
        },
        error: function () {
            alert('Unable to process.')
        }
    });
}
//#endregion

//#region Hide

function HideModal() {
    ClearData();
    $('#ProductModal').modal('hide');
}
//#endregion

function ClearData() {
    $('#ProductName').val('');
    $('#Category').val('');
    $('#SerialNumber').val('');
    $('#Description').val('');
    $('#UOM').val('');
    $('#Price').val('');
    $('#Quantity').val('');

    $('#ProductName').css('border-color', 'light-grey');
    $('#Category').css('border-color', 'light-grey');
    $('#SerialNumber').css('border-color', 'light-grey');
    $('#Description').css('border-color', 'light-grey');
    $('#UOM').css('border-color', 'light-grey');
    $('#Price').css('border-color', 'light-grey');
    $('#Quantity').css('border-color', 'light-grey');
}

function Validate() {
    var isValid = true;

    if ($('#ProductName').val().trim() == "") {
        $('#ProductName').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#ProductName').css('border-color', 'light-grey');
    }
    if ($('#Category').val().trim() == "") {
        $('#Category').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Category').css('border-color', 'light-grey');
    }
    if ($('#SerialNumber').val().trim() == "") {
        $('#SerialNumber').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#SerialNumber').css('border-color', 'light-grey');
    }
    if ($('#Description').val().trim() == "") {
        $('#Description').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Description').css('border-color', 'light-grey');
    }
    if ($('#UOM').val().trim() == "") {
        $('#UOM').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#UOM').css('border-color', 'light-grey');
    }
    if ($('#Price').val().trim() == "") {
        $('#Price').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Price').css('border-color', 'light-grey');
    }
    if ($('#Quantity').val().trim() == "") {
        $('#Quantity').css('border-color', 'Red');
        isValid = false;
    }
    else {
        $('#Quantity').css('border-color', 'light-grey');
    }

    return isValid;
}
//#region Validation
$('#ProductName').on('change', function () {
    Validate();
});

$('#Category').on('change', function () {
    Validate();
});

$('#SerialNumber').on('change', function () {
    Validate();
});

$('#Description').on('change', function () {
    Validate();
});

$('#UOM').on('change', function () {
    Validate();
});

$('#Price').on('change', function () {
    Validate();
});

$('#Quantity').on('change', function () {
    Validate();
});
//#endregion